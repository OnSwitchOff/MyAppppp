using BuildingBlocks.Application.Commands;

namespace  MyApp.Application.Products.AddNewProduct;

public record AddNewProductCommand(string Name, string Code) : CommandBase<int>;