using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.JurisdictionRow>;
using MyRow = CultureLinkCRM.CrmDB.JurisdictionRow;

namespace CultureLinkCRM.CrmDB;

public interface IJurisdictionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class JurisdictionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IJurisdictionRetrieveHandler
{
    public JurisdictionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}