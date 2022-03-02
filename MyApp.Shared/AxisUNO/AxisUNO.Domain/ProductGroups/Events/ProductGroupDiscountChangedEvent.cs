using BuildingBlocks.Domain.Events;

namespace  MyApp.Domain.ProductGroups.Events;

public record ProductGroupDiscountChangedEvent(int ProductGroupId, decimal Discount) : DomainEventBase;