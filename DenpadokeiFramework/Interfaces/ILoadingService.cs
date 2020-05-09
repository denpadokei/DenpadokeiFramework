using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DenpadokeiFramework.Interfaces
{
    public interface ILoadingService : INotifyPropertyChanged
    {
        public bool IsLoading { get; set; }

        public Task LoadAsync(Action action);

        public Task LoadAsync(Func<bool> func, Action reLoad);
    }
}
