using Autofac;
using MyApp.Application.Services.Navigation;
using MyApp.Presentation.Views.MainViews;
using MyApp.Services.Navigation;
using Microsoft.UI.Xaml;

namespace MyApp.AutofacModules;

internal class NavigationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterInstance(App.MainWindow).As<Window>();

        builder.RegisterType<ViewsService>().As<IViewsService>().InstancePerLifetimeScope();
        builder.RegisterType<NavigationViewService>().As<INavigationViewService>().InstancePerLifetimeScope();
        builder.RegisterType<NavigationService>().As<INavigationService>().InstancePerLifetimeScope();

        builder.RegisterType<MainView>().InstancePerDependency();
    }
}