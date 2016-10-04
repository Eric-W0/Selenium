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
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium
{
    public static class ConvertApi
    {
        static Dictionary<Type, TypeConverter> cache = new Dictionary<Type, TypeConverter>();

        static TypeConverter GetConverter(Type valueType)
        {
            TypeConverter converter;
            if (!cache.TryGetValue(valueType, out converter))
            {
                var tca = (TypeConverterAttribute)valueType
                    .GetCustomAttributes(typeof(TypeConverterAttribute), false)
                    .FirstOrDefault();
                if (tca == null)
                {
                    throw new ArgumentException($"No converter for type {valueType}");
                }
                Type convType = tca.ConverterTypeName.SearchType();
                if (convType == null)
                {
                    throw new ArgumentException($"Converter for type {valueType} is not available");
                }
                converter = (TypeConverter)Activator.CreateInstance(convType);
                cache[valueType] = converter;
            }
            return converter;
        }

        public static TTarget Convert<TSource, TTarget>(TSource source)
        {
            TypeConverter converter = GetConverter(typeof(TTarget));
            if (!converter.CanConvertFrom(typeof(TSource)))
            {
                throw new ArgumentException($"Converter for type {typeof(TTarget)} doesn't accept values of type {typeof(TSource)}");
            }
            return (TTarget)converter.ConvertFrom(source);
        }

        public static T Convert<T>(string source)
        {
            return Convert<string, T>(source);
        }
    }
}
