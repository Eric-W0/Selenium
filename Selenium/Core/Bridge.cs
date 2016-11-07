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
using Hyperplan.Selenium.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium.Core
{
    class Bridge<TOwner, TValue>
    {
        protected TOwner owner;
        PropertyInfo externalInfo;
        LazyCache<TValue> externalCache;

        internal Bridge(TOwner owner, string name)
        {
            this.owner = owner;
            externalInfo = Utils.SearchPublicProperty(typeof(TOwner), name);
            externalCache = new LazyCache<TValue>(() => (TValue)externalInfo.GetValue(owner));
        }

        internal TValue ExternalCachedValue
        {
            get
            {
                return externalCache.Value;
            }

            set
            {
                externalInfo.SetValue(owner, value);
            }
        }
    }
}
