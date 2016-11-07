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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Hyperplan.Selenium.Samples
{
    class ConverterView2
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

        string InputText => Model.InputValue.ToString();

        string OperationText
        {
            get
            {
                if (Delta > 0)
                {
                    return $"add {Delta}";
                }
                else if (Delta < 0)
                {
                    return $"subtract {Delta}";
                }
                else
                {
                    return $"keep the same";
                }
            }
        }

        int Delta => Model.OutputValue - Model.InputValue;

        object InputMeasure => Model.IsInputInCelsius ? "Celsius" : "Fahrenheit";
        object OutputMeasure => Model.IsInputInCelsius ? "Fahrenheit" : "Celsius";

        public UIElement UIElement
        {
            get
            {
                return new StackPanel()
                {
                    Children = new UIElement[]
                    {
                        new Label()
                        {
                            Content ="If you have",
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new Canvas() { Width = 5 },
                        new TextBox()
                        {
                            Width = 50,
                            VerticalAlignment = VerticalAlignment.Center,
                            IsReadOnly = true,
                            _Text_ = new Driver<string>(() => InputText)
                        },
                        new Canvas() { Width = 5 },
                        new Label()
                        {
                            VerticalAlignment = VerticalAlignment.Center,
                            _Content_ = new Driver<object>(() => InputMeasure)
                        },
                        new Label()
                        {
                            Content = " , you'll have to ",
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new Label()
                        {
                            VerticalAlignment = VerticalAlignment.Center,
                            _Content_ = new Driver<object>(() => OperationText)
                        },
                        new Label()
                        {
                            Content = " to get ",
                            VerticalAlignment = VerticalAlignment.Center
                        },
                        new Label()
                        {
                            VerticalAlignment = VerticalAlignment.Center,
                            _Content_ = new Driver<object>(() => OutputMeasure)
                        }
                    },
                    Orientation = Orientation.Horizontal
                };
            }
        }
    }

    public class ConverterDualApp : System.Windows.Application
    {
        Cell<ConverterModel> model = new Cell<ConverterModel>(new ConverterModel());

        ConverterModel Model
        {
            get
            {
                return model.Value;
            }

            set
            {
                model.Value = value;
            }
        }

        [STAThread]
        public static void Main()
        {
            var app = new ConverterDualApp();
            app.Run(new Hyperplan.Selenium.Window()
            {
                Title = "Temperature Converter - 2",
                Content = new DockPanel()
                {
                    Children = new UIElement[]
                    {
                        new ContentControl()
                        {
                            Content = new Button()
                            {
                                Content = "Reset",
                                Margin = ConvertApi.Convert<int, Thickness>(10),
                                Width = 80,
                                VerticalAlignment = VerticalAlignment.Center,
                                HorizontalAlignment = HorizontalAlignment.Center,
                                Click = (s, e) =>
                                {
                                    app.Model = new ConverterModel();
                                }
                            },
                            DockPanel_Dock = Dock.Bottom
                        },

                        new Grid()
                        {
                            RowDefinitions = new RowDefinition[]
                            {
                                new RowDefinition(),
                                new RowDefinition()
                            },
                            ColumnDefinitions = new ColumnDefinition[]
                            {
                                new ColumnDefinition()
                            },
                            Children = new UIElement[]
                            {
                                new GroupBox()
                                {
                                    Header = "First View",
                                    Content = new ConverterView()
                                    {
                                        _Model_ = new Driver<ConverterModel>(() => app.Model)
                                    }.UIElement,
                                    HorizontalAlignment = HorizontalAlignment.Center,
                                    VerticalAlignment = VerticalAlignment.Center,
                                    Grid_Row = 0
                                },
                                new GroupBox()
                                {
                                    Header = "Second View",
                                    Content = new ConverterView2()
                                    {
                                        _Model_ = new Driver<ConverterModel>(() => app.Model)
                                    }.UIElement,
                                    HorizontalAlignment = HorizontalAlignment.Center,
                                    VerticalAlignment = VerticalAlignment.Center,
                                    Grid_Row = 1
                                }
                            }
                        }
                    }
                }
            });
        }
    }
}
