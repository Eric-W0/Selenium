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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium.Core
{
    class CollectionBridge<TOwner, TElement> : PropertyBridge<TOwner, IEnumerable<TElement>, IList>
    {
        IEnumerable<TElement> store;
        HalfBind<IEnumerable<TElement>> bind;

        internal CollectionBridge(TOwner owner, string name) : base(owner, name) { }

        internal IEnumerable<TElement> InternalValue
        {
            get
            {
                if (store == null)
                {
                    var result = new List<TElement>();
                    foreach (var elt in NativeValue)
                    {
                        result.Add((TElement)elt);
                    }
                    store = result;
                }
                return store;
            }

            set
            {
                int extIndex = 0;
                foreach (var extElement in value)
                {
                    int intIndex = NativeValue.IndexOf(extElement);
                    if (intIndex != -1)
                    {
                        if (intIndex != extIndex)
                        {
                            NativeValue.RemoveAt(intIndex);
                            NativeValue.Insert(extIndex, extElement);
                        }
                    }
                    else
                    {
                        NativeValue.Insert(extIndex, extElement);
                    }
                    extIndex++;
                }
                while (NativeValue.Count > extIndex)
                {
                    NativeValue.RemoveAt(extIndex);
                }
                store = value;
            }
        }

        internal void Activate()
        {
            bind = new HalfBind<IEnumerable<TElement>>(() => InternalValue, () => ExternalCachedValue);
        }
    }
}
