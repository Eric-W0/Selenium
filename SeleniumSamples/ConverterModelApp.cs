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

//using Hyperplan.Fluor;
//using Hyperplan.Selenium;
//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using System.Windows;

//namespace Hyperplan.Selenium.Samples
//{
//    class ConverterModel
//    {
//        readonly Cell<int> _InputValue = new Cell<int>();

//        public int InputValue
//        {
//            get
//            {
//                return _InputValue.Get();
//            }

//            set
//            {
//                _InputValue.Set(value);
//            }
//        }

//        readonly Cell<bool> _IsInputInCelsius = new Cell<bool>(true);

//        public bool IsInputInCelsius
//        {
//            get
//            {
//                return _IsInputInCelsius.Get();
//            }

//            set
//            {
//                _IsInputInCelsius.Set(value);
//            }
//        }

//        public int OutputValue
//        {
//            get
//            {
//                if (IsInputInCelsius)
//                {
//                    return (InputValue * 2) + 30;
//                }
//                else
//                {
//                    return (InputValue - 30) / 2;
//                }
//            }
//        }

//        public bool IsOutputInCelsius => !IsInputInCelsius;
//    }

//    class ConverterView : StackPanel
//    {
//        internal IProperty<ConverterModel> _Model = new Cell<ConverterModel>(new ConverterModel());
//        public ConverterModel Model
//        {
//            get
//            {
//                return _Model.Get();
//            }

//            set
//            {
//                _Model.Set(value);
//            }
//        }

//        readonly Cell<string> _InvalidInput = new Cell<string>();
//        string InvalidInput
//        {
//            get
//            {
//                return _InvalidInput.Get();
//            }

//            set
//            {
//                _InvalidInput.Set(value);
//            }
//        }

//        string InputText
//        {
//            get
//            {
//                if (InvalidInput != null)
//                {
//                    return InvalidInput;
//                }
//                else
//                {
//                    return Model.InputValue.ToString();
//                }
//            }

//            set
//            {
//                int input;
//                if (int.TryParse(value, out input))
//                {
//                    Model.InputValue = input;
//                    InvalidInput = null;
//                }
//                else
//                {
//                    InvalidInput = value;
//                }
//            }
//        }

//        string OutputText
//        {
//            get
//            {
//                if (InvalidInput != null)
//                {
//                    if (InputText.Equals(""))
//                    {
//                        return "";
//                    }
//                    else
//                    {
//                        return "<error>";
//                    }
//                }
//                else
//                {
//                    return Model.OutputValue.ToString();
//                }
//            }
//        }

//        bool? IsCelsiusChecked
//        {
//            get
//            {
//                return Model.IsInputInCelsius;
//            }

//            set
//            {
//                Model.IsInputInCelsius = value ?? true;
//            }
//        }

//        bool? IsFahrenheitChecked
//        {
//            get
//            {
//                return !Model.IsInputInCelsius;
//            }

//            set
//            {
//                if (value == null)
//                {
//                    Model.IsInputInCelsius = false;
//                }
//                else
//                {
//                    Model.IsInputInCelsius = !value.Value;
//                }
//            }
//        }

//        public override IEnumerable<UIElement> Children => new UIElement[]
//        {
//            new TextBox()
//            {
//                _Text = new Link<string>(() => InputText),
//                Width = 50,
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Canvas() { Width = 10 },
//            new StackPanel()
//            {
//                Children = new UIElement[]
//                {
//                    new RadioButton()
//                    {
//                        Content = "Celsius",
//                        _IsChecked = new Link<bool?>(() => IsCelsiusChecked)
//                    },
//                    new RadioButton()
//                    {
//                        Content = "Fahrenheit",
//                        _IsChecked = new Link<bool?>(() => IsFahrenheitChecked)
//                    }
//                }
//            },
//            new Canvas() { Width = 10 },
//            new Label()
//            {
//                Content = "=",
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Canvas() { Width = 10 },
//            new TextBox()
//            {
//                _Text = new Property<string>(() => OutputText),
//                IsReadOnly = true,
//                Width = 50,
//                VerticalAlignment = VerticalAlignment.Center
//            }
//        };

//        public override System.Windows.Controls.Orientation Orientation => System.Windows.Controls.Orientation.Horizontal;
//    }

//    public static class ConverterModelApp
//    {
//        [STAThread]
//        public static void Main()
//        {
//            System.Windows.Application app = new System.Windows.Application();
//            app.Run(new Hyperplan.Selenium.Window()
//            {
//                Title = "Temperature Converter",
//                Content = new ConverterView()
//                {
//                    HorizontalAlignment = HorizontalAlignment.Center,
//                    VerticalAlignment = VerticalAlignment.Center
//                }
//            });
//        }
//    }
//}
