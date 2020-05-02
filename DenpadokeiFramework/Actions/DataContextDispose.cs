using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace DenpadokeiFramework.Actions
{
    public class DataContextDispose : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            if (this.AssociatedObject.DataContext is IDisposable context) {
                context.Dispose();
            }
        }
    }
}
