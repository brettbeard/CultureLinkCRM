using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.GenderRow>;
using MyRow = CultureLinkCRM.CrmDB.GenderRow;

namespace CultureLinkCRM.CrmDB;

public interface IGenderRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class GenderRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGenderRetrieveHandler
{
    public GenderRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}