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
using Hyperplan.Selenium.Core;
using System;
using System.Reflection;
using System.Windows;

namespace Hyperplan.Selenium.Core
{
    class RegularPropertyBridge<T> : BasePropertyBridge<T, object, object>
    {
        Monitor monitor;

        internal RegularPropertyBridge(T owner, string name) : base(owner, name)
        {
            monitor = new Monitor(() =>
            {
                var value = ExternalValue;
                if (!object.Equals(value, InternalValue))
                {
                    InternalValue = value;
                }
            });
        }
    }
}
