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

using System;
using System.Windows;

namespace Hyperplan.Selenium.Samples
{
    public static class RawHelloWorldApp
    {
        [STAThread]
        public static void Main()
        {
            var button = new Button()
            {
                Content = "OK",
                Width = 80
            };
            button.Click = (s, e) => Application.Current.Shutdown();

            Application app = new Application();
            app.Run(new Window()
            {
                Title = "Hello World!",
                Height = 350.0,
                Width = 525.0,
                Content = new Grid()
                {
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    Children = new UIElement[] { button }
                }
            });
        }
    }
}
