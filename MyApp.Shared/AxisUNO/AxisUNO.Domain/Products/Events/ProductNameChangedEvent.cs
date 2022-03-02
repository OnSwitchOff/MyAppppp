using BuildingBlocks.Domain.Events;

namespace  MyApp.Domain.Products.Events;

public record ProductCreatedEvent(Product Product) : DomainEventBase;