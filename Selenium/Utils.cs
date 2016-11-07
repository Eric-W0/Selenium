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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium
{
    static class Utils
    {
        internal static Type SearchType(string path)
        {
            Type result;

            // Try the fully-qualified version
            result = Type.GetType(path);
            if (result != null)
            {
                return result;
            }

            // Try all the assemblies one by one
            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                result = assembly.GetType(path);
                if (result != null)
                {
                    return result;
                }
            }

            // Found nothing
            return null;
        }

        internal static PropertyInfo SearchPublicProperty(Type type, string name)
        {
            var infos = new List<PropertyInfo>(
                from info in type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                where info.Name == name
                select info
            );
            while (type != null)
            {
                foreach (var info in infos)
                {
                    if (info.DeclaringType == type)
                    {
                        return info;
                    }
                }
                type = type.BaseType;
            }
            return null;
        }

        internal static EventInfo SearchPublicEvent(Type type, string name)
        {
            var infos = new List<EventInfo>(
                from info in type.GetEvents(BindingFlags.Public | BindingFlags.Instance)
                where info.Name == name
                select info
            );
            while (type != null)
            {
                foreach (var info in infos)
                {
                    if (info.DeclaringType == type)
                    {
                        return info;
                    }
                }
                type = type.BaseType;
            }
            return null;
        }
    }
}
