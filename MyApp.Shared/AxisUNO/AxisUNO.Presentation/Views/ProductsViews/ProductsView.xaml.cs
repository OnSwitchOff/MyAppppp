using MyApp.Application.ViewModels.ProductsViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.UI.Xaml.Controls;

namespace  MyApp.Presentation.Views.ProductsViews;

public sealed partial class ProductsView : Page
{
    public ProductsView()
    {
        ViewModel = Ioc.Default.GetRequiredService<ProductsViewModel>();
        InitializeComponent();
    }

    public ProductsViewModel ViewModel { get; }
}