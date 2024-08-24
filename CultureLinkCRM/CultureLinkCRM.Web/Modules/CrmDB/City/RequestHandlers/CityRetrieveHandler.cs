using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.CityRow>;
using MyRow = CultureLinkCRM.CrmDB.CityRow;

namespace CultureLinkCRM.CrmDB;

public interface ICityRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class CityRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICityRetrieveHandler
{
    public CityRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}