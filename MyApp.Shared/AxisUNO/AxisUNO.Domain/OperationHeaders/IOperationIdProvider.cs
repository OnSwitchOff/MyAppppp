using MyApp.Domain.Operations;

namespace  MyApp.Domain.OperationHeaders;

public interface IAcctProvider
{
    int GetNextAcct(OperationType operationType);
}