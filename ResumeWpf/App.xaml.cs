using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Autofac;
using ResumeWpf.Screens;
using ResumeWpf.Services;
using ResumeWpf.ViewModels;
using ResumeWpf.Views;

namespace ResumeWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IContainer _iocContainer;
        protected override void OnActivated(EventArgs e)
        {
            try
            {
                MainWindow.DataContext = this._iocContainer.Resolve<MainScreen>();
            }
            catch (Exception ex)
            {
                throw;
            }

            base.OnActivated(e);
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            this.BuildIocContainer();

            base.OnStartup(e);
        }

        private void BuildIocContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SkillsService>();
            builder.RegisterType<PersonalPageViewModel>();
            builder.RegisterType<SkillsPageViewModel>();
            builder.RegisterType<MainScreen>();

            this._iocContainer = builder.Build();
        }
    }
}
