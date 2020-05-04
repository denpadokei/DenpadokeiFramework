using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using Microsoft.Xaml.Behaviors;

namespace DenpadokeiFramework.Actions
{
    /// <summary>
    /// <see cref="Microsoft.Xaml.Behaviors.TriggerAction"/>のイベント名UnLoadedで呼び出すといい感じになります。
    /// DataContextは<see cref="IDisposable"/>を継承している必要があります。
    /// </summary>
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
