using Autofac;
using MyApp.Application.Services.Activation;
using MyApp.Services.Activation;
using MyApp.Services.Activation.Handlers;
using BuildingBlocks.Application.Services.Activation.Handlers;
using Microsoft.UI.Xaml;

namespace  MyApp.AutofacModules;

public sealed class ActivationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ActivationService>().As<IActivationService>().InstancePerLifetimeScope();

        builder.RegisterType<DefaultActivationHandler>().As<ActivationHandler<LaunchActivatedEventArgs>>().InstancePerDependency();
    }
}