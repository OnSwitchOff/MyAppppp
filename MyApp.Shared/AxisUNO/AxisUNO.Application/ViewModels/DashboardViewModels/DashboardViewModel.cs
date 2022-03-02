using MyApp.Application.Products.AddNewProduct;
using MyApp.Domain.Products;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HarabaSourceGenerators.Common.Attributes;
using MediatR;
using Serilog;

namespace  MyApp.Application.ViewModels.DashboardViewModels;

[Inject]
public partial class DashboardViewModel : ObservableObject
{
    private readonly IMediator _mediator;
    private readonly IProductRepository _productRepository;
    private readonly ILogger _logger;

    [ICommand]
    private async void Click()
    {
        await foreach (var item in _productRepository.GetAllAsync(true))
        {
            _logger.Information($"{item.Name} + {item.Measure.Name} + {item.ProductGroup.Name}");
        }

        // await _mediator.Send(new AddNewProductCommand("name1", "code1"));
    }
}