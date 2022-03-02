using BuildingBlocks.Domain.Events;

namespace  MyApp.Domain.Operations.Events;

public record SaveOperationEvent(Operation Operation) : DomainEventBase;