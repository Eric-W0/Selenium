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
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;

//namespace Hyperplan.Selenium.Samples
//{
//    class ConverterView2 : StackPanel
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

//        string InputText => Model.InputValue.ToString();

//        string OperationText
//        {
//            get
//            {
//                if (Delta > 0)
//                {
//                    return $"add {Delta}";
//                }
//                else if (Delta < 0)
//                {
//                    return $"subtract {Delta}";
//                }
//                else
//                {
//                    return $"keep the same";
//                }
//            }
//        }

//        int Delta => Model.OutputValue - Model.InputValue;

//        object InputMeasure => Model.IsInputInCelsius ? "Celsius" : "Fahrenheit";
//        object OutputMeasure => Model.IsInputInCelsius ? "Fahrenheit" : "Celsius";

//        public override IEnumerable<UIElement> Children => new UIElement[]
//        {
//            new Label()
//            {
//                Content ="If you have",
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Canvas() { Width = 5 },
//            new TextBox()
//            {
//                _Text = new Property<string>(() => InputText),
//                Width = 50,
//                VerticalAlignment = VerticalAlignment.Center,
//                IsReadOnly = true
//            },
//            new Canvas() { Width = 5 },
//            new Label()
//            {
//                _Content = new Property<object>(() => InputMeasure),
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Label()
//            {
//                Content = " , you'll have to ",
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Label()
//            {
//                _Content = new Property<object>(() => OperationText),
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Label()
//            {
//                Content = " to get ",
//                VerticalAlignment = VerticalAlignment.Center
//            },
//            new Label()
//            {
//                _Content = new Property<object>(() => OutputMeasure),
//                VerticalAlignment = VerticalAlignment.Center
//            }
//        };

//        public override Orientation Orientation => Orientation.Horizontal;
//    }

//    public class ConverterDualApp : System.Windows.Application
//    {
//        readonly IProperty<ConverterModel> _Model = new Cell<ConverterModel>(new ConverterModel());
//        ConverterModel Model
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

//        [STAThread]
//        public static void Main()
//        {
//            var app = new ConverterDualApp();
//            app.Run(new Hyperplan.Selenium.Window()
//            {
//                Title = "Temperature Converter - 2",
//                Content = new DockPanel()
//                {
//                    Children = new UIElement[]
//                    {
//                        new ContentControl().Let(o1 =>
//                        {
//                            o1.Content = new Button().Let(o2 =>
//                            {
//                                o2.Content = "Reset";
//                                o2.Margin = ConvertApi.Convert<int, Thickness>(10);
//                                o2.Width = 80;
//                                o2.VerticalAlignment = VerticalAlignment.Center;
//                                o2.HorizontalAlignment = HorizontalAlignment.Center;
//                                o2.Click += (s, e) => app.Model = new ConverterModel();
//                            });
//                            DockPanel.SetDock(o1, Dock.Bottom);
//                        }),
//                        new Grid()
//                        {
//                            RowDefinitions = new RowDefinition[]
//                            {
//                                new RowDefinition(),
//                                new RowDefinition()
//                            },
//                            ColumnDefinitions = new ColumnDefinition[]
//                            {
//                                new ColumnDefinition()
//                            },
//                            Children = new UIElement[]
//                            {
//                                new GroupBox().Let(o =>
//                                {
//                                    o.Header = "First View";
//                                    o.Content = new ConverterView()
//                                    {
//                                        _Model = app._Model
//                                    };
//                                    o.HorizontalAlignment = HorizontalAlignment.Center;
//                                    o.VerticalAlignment = VerticalAlignment.Center;
//                                    Grid.SetRow(o, 0);
//                                }),
//                                new GroupBox().Let(o =>
//                                {
//                                    o.Header = "Second View";
//                                    o.Content = new ConverterView2()
//                                    {
//                                        _Model = app._Model
//                                    };
//                                    o.HorizontalAlignment = HorizontalAlignment.Center;
//                                    o.VerticalAlignment = VerticalAlignment.Center;
//                                    Grid.SetRow(o, 1);
//                                })
//                            }
//                        }
//                    }
//                }
//            });
//        }
//    }
//}
