using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.ZipCodeRow;

namespace CultureLinkCRM.CrmDB;

public interface IZipCodeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ZipCodeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IZipCodeDeleteHandler
{
    public ZipCodeDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}