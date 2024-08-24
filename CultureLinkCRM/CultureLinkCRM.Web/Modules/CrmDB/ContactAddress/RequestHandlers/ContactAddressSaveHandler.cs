using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.ContactAddressRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactAddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactAddressSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactAddressSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContactAddressSaveHandler
{
    public ContactAddressSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}