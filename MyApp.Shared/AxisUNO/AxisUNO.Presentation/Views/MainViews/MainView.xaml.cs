using MyApp.Application.ViewModels.MainViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;

namespace  MyApp.Presentation.Views.MainViews;

public sealed partial class MainView : Page
{
    public MainView()
    {
        ViewModel = Ioc.Default.GetRequiredService<MainViewModel>();

        InitializeComponent();

        ViewModel.NavigationService.Frame = frame;
        ViewModel.NavigationViewService.Initialize(navigationView);
    }

    public MainViewModel ViewModel { get; }
}