using DenpadokeiFramework.Interfaces;
using DenpadokeiFramework.Services;
using DenpadokeiFramework.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace DenpadokeiFramework
{
    public class DenpadokeiFrameworkModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ILoadingService, LoadingService>();
            containerRegistry.RegisterDialog<ConfimationDialog>(nameof(ConfimationDialog));
        }
    }
}