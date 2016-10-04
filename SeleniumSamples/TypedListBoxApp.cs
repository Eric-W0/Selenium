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
using Hyperplan.Selenium.Typed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Hyperplan.Selenium.Samples
{
    public class TypedListBoxApp : System.Windows.Application
    {
        Window AppWindow
        {
            get
            {
                var lb = new ListBox<FontFamily>()
                {
                    ItemTemplate = ff => new TextBlock()
                    {
                        Text = "ABCDEFGabcdefg",
                        FontFamily = ff,
                        FontSize = 20.0
                    },
                    Items = Fonts.SystemFontFamilies,
                    SelectionMode = SelectionMode.Single
                };

                var desc = new TextBlock()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                };
                DockPanel.SetDock(desc, Dock.Bottom);

                desc.AttachOneWay(() => desc.Text, () =>
                {
                    if (lb.SelectedItem != null)
                    {
                        return $"You have selected [{lb.SelectedItem.Source}]";
                    }
                    else
                    {
                        return "No family selected";
                    }
                });

                return new Window()
                {
                    Title = "Typed ListBox",
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                    Width = 600,
                    Height = 400,
                    Content = new DockPanel()
                    {
                        Children = new UIElement[]
                        {
                            desc,
                            lb
                        }
                    }
                };
            }
        }

        [STAThread]
        public static void Main()
        {
            var app = new TypedListBoxApp();
            app.Run(app.AppWindow);
        }
    }
}
