// Selenium Framework
// Copyright(C) 2016 Eric Blond
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see <http://www.gnu.org/licenses/>.

using Hyperplan.Fluor;
using Hyperplan.Fluor.Library;
using Hyperplan.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows;
using System.Windows.Controls;

namespace Hyperplan.Selenium.Samples
{
    class ConverterModel
    {
        Cell<int> inputValue = new Cell<int>();

        public int InputValue
        {
            get
            {
                return inputValue.Value;
            }

            set
            {
                inputValue.Value = value;
            }
        }

        Cell<bool> isInputInCelsius = new Cell<bool>(true);

        public bool IsInputInCelsius
        {
            get
            {
                return isInputInCelsius.Value;
            }

            set
            {
                isInputInCelsius.Value = value;
            }
        }

        public int OutputValue
        {
            get
            {
                if (IsInputInCelsius)
                {
                    return (InputValue * 2) + 30;
                }
                else
                {
                    return (InputValue - 30) / 2;
                }
            }
        }

        public bool IsOutputInCelsius => !IsInputInCelsius;
    }

    class ConverterView
    {
        public IProperty<ConverterModel> _Model_ = new Cell<ConverterModel>(new ConverterModel());

        public ConverterModel Model
        {
            get
            {
                return _Model_.Value;
            }

            set
            {
                _Model_.Value = value;
            }
        }

        Cell<string> invalidInput = new Cell<string>();

        string InvalidInput
        {
            get
            {
                return invalidInput.Value;
            }

            set
            {
                invalidInput.Value = value;
            }
        }

        string InputText
        {
            get
            {
                if (InvalidInput != null)
                {
                    return InvalidInput;
                }
                else
                {
                    return Model.InputValue.ToString();
                }
            }

            set
            {
                int input;
                if (int.TryParse(value, out input))
                {
                    Model.InputValue = input;
                    InvalidInput = null;
                }
                else
                {
                    InvalidInput = value;
                }
            }
        }

        string OutputText
        {
            get
            {
                if (InvalidInput != null)
                {
                    if (InputText.Equals(""))
                    {
                        return "";
                    }
                    else
                    {
                        return "<error>";
                    }
                }
                else
                {
                    return Model.OutputValue.ToString();
                }
            }
        }

        bool? IsCelsiusChecked
        {
            get
            {
                return Model.IsInputInCelsius;
            }

            set
            {
                Model.IsInputInCelsius = value ?? true;
            }
        }

        bool? IsFahrenheitChecked
        {
            get
            {
                return !Model.IsInputInCelsius;
            }

            set
            {
                if (value == null)
                {
                    Model.IsInputInCelsius = false;
                }
                else
                {
                    Model.IsInputInCelsius = !value.Value;
                }
            }
        }

        public UIElement UIElement
        {
            get
            {
                return new StackPanel()
                {
                    Children = new UIElement[]
                    {
                        new TextBox()
                        {
                            Width = 50,
                            VerticalAlignment = VerticalAlignment.Center,
                            _Text_ = new Member<string>(() => InputText)
                        },
                        new Canvas() { Width = 10 },
                        new StackPanel()
                        {
                            Children = new UIElement[]
                            {
                                new RadioButton()
                                {
                                    Content = "Celsius",
                                    _IsChecked_ = new Member<bool?>(() => IsCelsiusChecked)
                                },
                                new RadioButton()
                                {
                                    Content = "Fahrenheit",
                                    _IsChecked_ = new Member<bool?>(() => IsFahrenheitChecked)
                                },
                            }
                        },
                        new Canvas() { Width = 10 },
                        new Label()
                        {
                            Content = "=",
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new Canvas() { Width = 10 },
                        new TextBox()
                        {
                            IsReadOnly = true,
                            Width = 50,
                            VerticalAlignment = VerticalAlignment.Center,
                            _Text_ = new Driver<string>(() => OutputText)
                        }
                    },
                    Orientation = Orientation.Horizontal,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center
                };
            }
        }
    }

    public static class ConverterModelApp
    {
        [STAThread]
        public static void Main()
        {
            System.Windows.Application app = new System.Windows.Application();
            app.Run(new Hyperplan.Selenium.Window()
            {
                Title = "Temperature Converter",
                Content = new ConverterView().UIElement
            });
        }
    }
}
