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
using System.Windows;
using System.Windows.Data;

namespace Hyperplan.Selenium.Core
{
    public sealed class PropertyChangeNotifier : DependencyObject, IDisposable
    {
        private WeakReference<DependencyObject> source;

        public PropertyChangeNotifier(DependencyObject source, string name)
        {
            this.source = new WeakReference<DependencyObject>(source);
            var binding = new Binding()
            {
                Path = new PropertyPath(name),
                Mode = BindingMode.OneWay,
                Source = source
            };
            BindingOperations.SetBinding(this, ValueProperty, binding);
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            "Value",
            typeof(object),
            typeof(PropertyChangeNotifier),
            new FrameworkPropertyMetadata(
                null,
                new PropertyChangedCallback(OnPropertyChanged)
            )
        );

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            PropertyChangeNotifier notifier = (PropertyChangeNotifier)d;
            notifier.ValueChanged?.Invoke(notifier, EventArgs.Empty);
        }

        public event EventHandler ValueChanged;

        public void Dispose()
        {
            BindingOperations.ClearBinding(this, ValueProperty);
        }
    }
}
