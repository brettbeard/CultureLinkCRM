using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.ZipCodeRow>;
using MyRow = CultureLinkCRM.CrmDB.ZipCodeRow;

namespace CultureLinkCRM.CrmDB;

public interface IZipCodeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ZipCodeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IZipCodeRetrieveHandler
{
    public ZipCodeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}