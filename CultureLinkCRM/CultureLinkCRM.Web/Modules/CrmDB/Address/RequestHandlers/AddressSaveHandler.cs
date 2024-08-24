using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.AddressRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.AddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IAddressSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AddressSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAddressSaveHandler
{
    public AddressSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}