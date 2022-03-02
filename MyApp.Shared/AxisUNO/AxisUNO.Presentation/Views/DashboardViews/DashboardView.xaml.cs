using MyApp.Application.ViewModels.DashboardViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;

namespace  MyApp.Presentation.Views.DashboardViews;

public sealed partial class DashboardView : Page
{
    public DashboardView()
    {
        ViewModel = Ioc.Default.GetRequiredService<DashboardViewModel>();
        InitializeComponent();
    }

    public DashboardViewModel ViewModel { get; }
}