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
//using Hyperplan.Selenium;

//namespace Hyperplan.Selenium.Samples
//{
//    public class ConverterMultiApp : System.Windows.Application
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

//        readonly IProperty<bool> _UseTabbedView = new Cell<bool>();
//        bool UseTabbedView
//        {
//            get
//            {
//                return _UseTabbedView.Get();
//            }

//            set
//            {
//                _UseTabbedView.Set(value);
//            }
//        }

//        object TabbedCenterView => new TabControl()
//        {
//            Items = new object[]
//            {
//                new TabItem()
//                {
//                    Header = "First View",
//                    Content = new ConverterView()
//                    {
//                        _Model = _Model,
//                        HorizontalAlignment = HorizontalAlignment.Center,
//                        VerticalAlignment = VerticalAlignment.Center
//                    }
//                },
//                new TabItem()
//                {
//                    Header = "Second View",
//                    Content = new ConverterView2()
//                    {
//                        _Model = _Model,
//                        HorizontalAlignment = HorizontalAlignment.Center,
//                        VerticalAlignment = VerticalAlignment.Center
//                    }
//                }
//            }
//        };

//        object StackedCenterView => new Grid()
//        {
//            RowDefinitions = new RowDefinition[]
//            {
//                new RowDefinition(),
//                new RowDefinition()
//            },
//            ColumnDefinitions = new ColumnDefinition[]
//            {
//                new ColumnDefinition()
//            },
//            Children = new UIElement[]
//            {
//                new GroupBox().Let(o =>
//                {
//                    o.Header = "First View";
//                    o.Content = new ConverterView()
//                    {
//                        _Model = _Model
//                    };
//                    o.HorizontalAlignment = HorizontalAlignment.Center;
//                    o.VerticalAlignment = VerticalAlignment.Center;
//                    Grid.SetRow(o, 0);
//                }),
//                new GroupBox().Let(o =>
//                {
//                    o.Header = "Second View";
//                    o.Content = new ConverterView2()
//                    {
//                        _Model = _Model
//                    };
//                    o.HorizontalAlignment = HorizontalAlignment.Center;
//                    o.VerticalAlignment = VerticalAlignment.Center;
//                    Grid.SetRow(o, 1);
//                })
//            }
//        };

//        object CenterView => UseTabbedView ? TabbedCenterView : StackedCenterView;

//        UIElement MenuSection => new Menu().Let(o =>
//        {
//            o.Items = new object[]
//            {
//                new MenuItem()
//                {
//                    Header = "_File",
//                    Items = new object[]
//                    {
//                        new MenuItem().Let(o2 =>
//                        {
//                            o2.Header = "E_xit";
//                            o2.Click += (s, e) => Shutdown();
//                        })
//                    }
//                },
//                new MenuItem()
//                {
//                    Header = "_View",
//                    Items = new object[]
//                    {
//                        new MenuItem().Let(o2 =>
//                        {
//                            o2.Header = "Use Tabbed View";
//                            o2.IsCheckable = true;
//                            o2._IsChecked = _UseTabbedView;
//                        })
//                    }
//                }
//            };
//            DockPanel.SetDock(o, System.Windows.Controls.Dock.Top);
//        });

//        UIElement CenterSection => new ContentControl()
//        {
//            _Content = new Property<object>(() => CenterView, null),
//            Margin = ConvertApi.Convert<int, Thickness>(10)
//        };

//        UIElement ButtonSection => new Button().Let(o =>
//        {
//            o.Content = "Reset";
//            o.Margin = ConvertApi.Convert<int, Thickness>(10);
//            o.Width = 80;
//            o.VerticalAlignment = VerticalAlignment.Center;
//            o.HorizontalAlignment = HorizontalAlignment.Center;
//            o.Click += (s, e) => Model = new ConverterModel();
//            DockPanel.SetDock(o, System.Windows.Controls.Dock.Bottom);
//        });

//        new void Run()
//        {
//            base.Run(new Hyperplan.Selenium.Window()
//            {
//                Title = "Temperature Converter - 3",
//                Content = new DockPanel()
//                {
//                    Children = new UIElement[]
//                    {
//                        MenuSection,
//                        ButtonSection,
//                        CenterSection
//                    }
//                },
//                WindowStartupLocation = WindowStartupLocation.CenterScreen,
//                Width = 600,
//                Height = 400
//            });
//        }

//        [STAThread]
//        public static void Main()
//        {
//            new ConverterMultiApp().Run();
//        }
//    }
//}
