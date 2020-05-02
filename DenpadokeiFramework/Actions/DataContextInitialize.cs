using DenpadokeiFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace DenpadokeiFramework.Actions
{
    public class DataContextInitialize : TriggerAction<FrameworkElement>
    {
        protected override void Invoke(object parameter)
        {
            if (this.AssociatedObject.DataContext is IDataContextInitializable context) {
                context.OnInitialize();
            }
        }
    }
}
