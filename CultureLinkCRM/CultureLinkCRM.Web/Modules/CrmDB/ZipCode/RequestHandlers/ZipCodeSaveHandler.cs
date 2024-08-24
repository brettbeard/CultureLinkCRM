using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.ZipCodeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.ZipCodeRow;

namespace CultureLinkCRM.CrmDB;

public interface IZipCodeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ZipCodeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IZipCodeSaveHandler
{
    public ZipCodeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}