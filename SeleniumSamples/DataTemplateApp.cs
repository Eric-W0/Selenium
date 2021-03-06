﻿// Selenium Framework
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
using System.Windows.Controls;
using System.Windows.Media;

namespace Hyperplan.Selenium.Samples
{
    public class DataTemplateApp : System.Windows.Application
    {
        DataTemplate NameTemplate = new FunctionTemplate<FontFamily>(ff => new TextBlock() { Text = ff.Source });

        DataTemplate ComposedTemplate = new FunctionTemplate<FontFamily>(ff => new CheckBox()
        {
            IsChecked = ff.Source.Contains(" "),
            IsHitTestVisible = false
        });

        DataTemplate SampleTemplate = new FunctionTemplate<FontFamily>(ff => new TextBlock()
        {
            Text = "ABCDEFGabcdefg",
            FontFamily = ff,
            FontSize = 20.0
        });

        Window AppWindow => new Window()
        {
            Title = "Data Template",
            WindowStartupLocation = WindowStartupLocation.CenterScreen,
            Width = 600,
            Height = 400,
            Content = new ListView()
            {
                View = new GridView().Let(o =>
                {
                    o.Columns.Add(new GridViewColumn()
                    {
                        Header = "Name",
                        CellTemplate = NameTemplate,
                        Width = 180
                    });
                    o.Columns.Add(new GridViewColumn()
                    {
                        Header = "Composed",
                        CellTemplate = ComposedTemplate,
                        Width = 70
                    });
                    o.Columns.Add(new GridViewColumn()
                    {
                        Header = "Sample",
                        CellTemplate = SampleTemplate,
                        Width = 300
                    });
                }),
                Items = Fonts.SystemFontFamilies
            }
        };

        [STAThread]
        public static void Main()
        {
            var app = new DataTemplateApp();
            app.Run(app.AppWindow);
        }
    }
}
