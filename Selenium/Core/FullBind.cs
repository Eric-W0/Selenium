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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hyperplan.Selenium.Core
{
    class FullBind<T>
    {
        Monitor targetMonitor;
        Monitor sourceMonitor;

        public FullBind(Expression<Func<T>> target, Expression<Func<T>> source)
        {
            var targetGetter = target.Compile();
            var targetSetter = Hyperplan.Fluor.Library.Utils.SetterFromExpression(target);

            var sourceGetter = source.Compile();
            var sourceSetter = Hyperplan.Fluor.Library.Utils.SetterFromExpression(source);

            sourceMonitor = new Monitor(() =>
            {
                var sourceValue = sourceGetter();
                using (new Snapshot())
                {
                    var targetValue = targetGetter();
                    if (!object.Equals(sourceValue, targetValue))
                    {
                        return () => targetSetter(sourceValue);
                    }
                }
                return null;
            });

            targetMonitor = new Monitor(() =>
            {
                var targetValue = targetGetter();
                using (new Snapshot())
                {
                    var sourceValue = sourceGetter();
                    if (!object.Equals(targetValue, sourceValue))
                    {
                        return () =>
                        {
                            sourceSetter(targetValue);

                            // Sometimes the source is not impacted by the setter, so Fluor knows nothing
                            // about that update. So we need to send the data back to the target as
                            // a kind gesture.

                            var sourceValue2 = sourceGetter();
                            if (!object.Equals(sourceValue2, targetValue))
                            {
                                targetSetter(sourceValue2);
                            }
                        };
                    }
                }
                return null;
            });
        }
    }
}
