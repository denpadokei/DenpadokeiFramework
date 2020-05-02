using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DenpadokeiFramework.Interfaces
{
    public interface ILoadingService : INotifyPropertyChanged
    {
        public bool IsLoading { get; set; }

        public void Load(Action action);

        public void Load(Func<bool> func, Action reLoad);
    }
}
