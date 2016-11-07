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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Hyperplan.Selenium;
using Hyperplan.Fluor.Library;

namespace Hyperplan.Selenium.Samples
{
    public class ConverterMultiApp : System.Windows.Application
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

        Cell<bool> useTabbedView = new Cell<bool>();

        bool UseTabbedView
        {
            get
            {
                return useTabbedView.Value;
            }

            set
            {
                useTabbedView.Value = value;
            }
        }

        object TabbedCenterView => new TabControl()
        {
            Items = new object[]
            {
                new TabItem()
                {
                    Header = "First View",
                    Content = new ConverterView()
                    {
                        _Model_ = model
                    }.UIElement
                },
                new TabItem()
                {
                    Header = "Second View",
                    Content = new ConverterView2()
                    {
                        _Model_ = model
                    }.UIElement
                }
            }
        };

        object StackedCenterView => new Grid()
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
                        _Model_ = model
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
                        _Model_ = model
                    }.UIElement,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Grid_Row = 1
                }
            }
        };

        object CenterView => UseTabbedView ? TabbedCenterView : StackedCenterView;

        UIElement MenuSection => new Menu().Let(o =>
        {
            o.Items = new object[]
            {
                new MenuItem()
                {
                    Header = "_File",
                    Items = new object[]
                    {
                        new MenuItem()
                        {
                            Header = "E_xit",
                            Click = (s, e) => Shutdown()
                        }
                    }
                },
                new MenuItem()
                {
                    Header = "_View",
                    Items = new object[]
                    {
                        new MenuItem()
                        {
                            Header = "Use Tabbed View",
                            IsCheckable = true,
                            _IsChecked_ = useTabbedView
                        }
                    }
                }
            };
            DockPanel.SetDock(o, System.Windows.Controls.Dock.Top);
        });

        UIElement CenterSection => new ContentControl()
        {
            Margin = ConvertApi.Convert<int, Thickness>(10),
            _Content_ = new Driver<object>(() => CenterView)
        };

        UIElement ButtonSection => new Button()
        {
            Content = "Reset",
            Margin = ConvertApi.Convert<int, Thickness>(10),
            Width = 80,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
            Click = (s, e) => Model = new ConverterModel(),
            DockPanel_Dock = System.Windows.Controls.Dock.Bottom
        };

        new void Run()
        {
            base.Run(new Hyperplan.Selenium.Window()
            {
                Title = "Temperature Converter - 3",
                Content = new DockPanel()
                {
                    Children = new UIElement[]
                    {
                        MenuSection,
                        ButtonSection,
                        CenterSection
                    }
                },
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                Width = 600,
                Height = 400
            });
        }

        [STAThread]
        public static void Main()
        {
            new ConverterMultiApp().Run();
        }
    }
}
