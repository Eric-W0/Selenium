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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hyperplan.Selenium
{
    public class FunctionTemplate<T> : DataTemplate
    {
        internal Func<T, object> function;

        public FunctionTemplate(Func<T, object> function)
        {
            this.function = function;
            DataType = typeof(T);
            var tc = new FrameworkElementFactory(typeof(TemplateControl));
            tc.SetValue(TemplateControl.GeneratorProperty, new Func<object, object>(Generate));
            VisualTree = tc;
        }

        object Generate(object data)
        {
            return function((T)data);
        }
    }
}
