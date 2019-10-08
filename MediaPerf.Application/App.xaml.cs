using MediaPerf.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MediaPerf.Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App 
    {
        #region Methods

        private void InitializePrismBootstrap()
        {
            //Bootstrapper bootstrapper = new Bootstrapper();
            //bootstrapper.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            //ApplicationThemeHelper.UpdateApplicationThemeName();

            InitializePrismBootstrap();

            InitializeInstances();
        }

        private void InitializeInstances()
        {
            //var locator = InstanceLocator.Current;

            //locator.RegisterInstance<IMetaModelFactory, MetaModelFactory>();
            //locator.RegisterInstance<IApplicationModelFactory, ApplicationModelFactory>();
            //locator.RegisterInstance<IMetaModelRepository, MetaModelRepository>();
            //locator.RegisterInstance<IApplicationRepository, ApplicationRepository>();
            //locator.RegisterInstance<ICacheService, CacheService>();
            //locator.RegisterInstance<IEntityService, EntityService>();
            //var metaDataService = new MetaDataService();
            //locator.RegisterInstance<IMetaDataService>(metaDataService);
            //metaDataService.Initialize();
        }

        #endregion
    }
}
