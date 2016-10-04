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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium.Core
{
    class BasePropertyBridge<TOwner, TExternal, TInternal>
    {
        TOwner owner;
        PropertyInfo externalInfo;
        PropertyInfo internalInfo;

        protected BasePropertyBridge(TOwner owner, string name)
        {
            this.owner = owner;
            externalInfo = typeof(TOwner).GetTopMostProperty(name);
            internalInfo = typeof(TOwner).BaseType.GetProperty(name);

            _ExternalValue = new Cache<TExternal>(() => (TExternal)externalInfo.GetValue(owner));
        }

        readonly Cache<TExternal> _ExternalValue;

        protected TExternal ExternalValue
        {
            get
            {
                return _ExternalValue.Get();
            }

            set
            {
                externalInfo.SetValue(owner, value);
            }
        }

        protected TInternal InternalValue
        {
            get
            {
                return (TInternal)internalInfo.GetValue(owner);
            }

            set
            {
                internalInfo.SetValue(owner, value);
            }
        }
    }
}
