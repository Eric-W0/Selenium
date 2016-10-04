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
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Hyperplan.Selenium.Typed
{
    public class ListBox<T> : ListBox
    {
        public new virtual IEnumerable<T> Items
        {
            get
            {
                foreach (var item in base.Items)
                {
                    yield return (T)item;
                }
            }

            set
            {
                var list = new List<object>();
                foreach (var item in value)
                {
                    list.Add(item);
                }
                base.Items = list;
            }
        }

        public new virtual Func<T, object> ItemTemplate
        {
            get
            {
                return ((FunctionTemplate<T>)base.ItemTemplate).function;
            }

            set
            {
                base.ItemTemplate = new FunctionTemplate<T>(value);
            }
        }

        public new virtual T SelectedItem
        {
            get
            {
                return (T)base.SelectedItem;
            }

            set
            {
                base.SelectedItem = value;
            }
        }

        public new virtual IEnumerable<T> SelectedItems
        {
            get
            {
                foreach (var item in base.SelectedItems)
                {
                    yield return (T)item;
                }
            }

            set
            {
                var list = new List<object>();
                foreach (var item in value)
                {
                    list.Add(item);
                }
                base.SelectedItems = list;
            }
        }
    }
}
