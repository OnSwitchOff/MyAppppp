using MyApp.Domain.Operations;
using MyApp.Domain.Operations.Sale;
using BuildingBlocks.Domain.Entities;

namespace  MyApp.Domain.OperationHeaders;

public class OperationHeader : Entity
{
    private OperationHeader()
    {
    }

    public int Id { get; private set; }

    public int OperType { get; private set; }

    public int Acct { get; private set; }

    public DateTime Date { get; private set; }

    public string UniqueSaleNumber { get; private set; } = string.Empty;

    public int PartnerId { get; private set; }

    public int PaymentId { get; private set; }

    public string Note { get; private set; } = string.Empty;

    public int SourceDocumentId { get; private set; }

    // TODO: Переименовать
    public int ECRReceiptType { get; private set; }

    public int ECRReceiptNumber { get; private set; }

    public DateTime UserRealTime { get; private set; }

    public int Status { get; private set; }

    public static OperationHeader FromOperation(Operation operation, IAcctProvider provider, IUniqueSaleNumberProvider uniqueSaleNumberProvider)
    {
        return new OperationHeader()
        {
            OperType = (int)operation.OperationType,
            Acct = provider.GetNextAcct(operation.OperationType),
            Date = DateTime.Now,
            UniqueSaleNumber = uniqueSaleNumberProvider.GetSaleNumber(),
            PartnerId = operation.Partner.Id,
            PaymentId = operation.Payment.Id,
            Note = string.Empty,
            SourceDocumentId = operation.SourceDocumentId,
        };
    }
}