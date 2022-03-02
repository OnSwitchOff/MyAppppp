using Autofac;
using MyApp.Application.ProdcutGroups;
using MyApp.Application.Services.ThemeSelector;
using MyApp.Application.ViewModels.DashboardViewModels;
using MyApp.Application.ViewModels.MainViewModels;
using MyApp.Application.ViewModels.ProductsViewModels;
using MyApp.Application.ViewModels.ProductViewModels;
using MyApp.Application.ViewModels.SettingsViewModels;
using MyApp.Domain.ProductGroups;

namespace  MyApp.Application.AutofacModules;

public class ApplicationServicesModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<MainViewModel>().InstancePerDependency();
        builder.RegisterType<DashboardViewModel>().InstancePerDependency();
        builder.RegisterType<ProductsViewModel>().InstancePerDependency();
        builder.RegisterType<ProductViewModel>().InstancePerDependency();
        builder.RegisterType<SettingsViewModel>().InstancePerDependency();

        builder.RegisterType<ThemeSelectorService>().As<IThemeSelectorService>().InstancePerDependency();

        builder.RegisterType<GroupPathGenerator>().As<IGroupPathGenerator>().InstancePerDependency();

        base.Load(builder);
    }
}
