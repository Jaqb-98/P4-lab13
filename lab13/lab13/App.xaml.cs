using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace lab13
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            var builder = new ContainerBuilder();
            builder.RegisterType<RectangleGenerator>().As<IControlGenerator>();
            builder.RegisterType<PanelFiller>().As<IPanelFiller>();
            //builder.RegisterType<FileDataProvider>().As<IDataProvider>();
            builder.RegisterType<DbDataProvider>().As<IDataProvider>();
            builder.RegisterType<Context>().AsSelf();
            builder.RegisterType<MainWindow>().AsSelf();


            var container = builder.Build();

            using (var scope = container.BeginLifetimeScope())
            {
                var window = scope.Resolve<MainWindow>();
                window.Show();
            }
        }
    }
}
