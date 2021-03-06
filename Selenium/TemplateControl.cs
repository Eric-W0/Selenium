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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hyperplan.Selenium
{
    public class TemplateControl : ContentControl
    {
        public static readonly DependencyProperty GeneratorProperty =
            DependencyProperty.Register(
                "Generator",
                typeof(Func<object, object>),
                typeof(TemplateControl)
            );

        public TemplateControl()
        {
            _Content_ = new Driver<object>(() => Content);
        }

        public Func<object, object> Generator
        {
            get
            {
                return (Func<object, object>)GetValue(GeneratorProperty);
            }

            set
            {
                SetValue(GeneratorProperty, value);
            }
        }

        new object Content
        {
            get
            {
                if ((Generator != null) && (DataContext != null))
                {
                    return Generator(DataContext);
                }
                else
                {
                    return base.Content;
                }
            }
        }
    }
}
