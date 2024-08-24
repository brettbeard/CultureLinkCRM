using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.ZipCodeRow>;
using MyRow = CultureLinkCRM.CrmDB.ZipCodeRow;

namespace CultureLinkCRM.CrmDB;

public interface IZipCodeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ZipCodeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IZipCodeListHandler
{
    public ZipCodeListHandler(IRequestContext context)
            : base(context)
    {
    }
}