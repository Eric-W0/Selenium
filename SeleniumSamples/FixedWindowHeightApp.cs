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

using Hyperplan.Fluor.Library;
using System;

namespace Hyperplan.Selenium.Samples
{
    public static class FixedWindowHeightApp
    {
        [STAThread]
        public static void Main()
        {
            System.Windows.Application app = new System.Windows.Application();
            app.Run(new Window()
            {
                Title = "Fixed Window Height",
                Width = 525.0,
                _Height_ = new Driver<double>(() => 300.0)
            });
        }
    }
}
