using System.Reflection;
using MyApp.Application.ViewModels.MainViewModels;

namespace  MyApp.Infrastructure.AutofacModules.Helpers;

internal static class MediatorAssemblies
{
    internal static readonly Assembly ApplicationLayer = typeof(MainViewModel).Assembly;
}