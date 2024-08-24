using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.ContactAddressRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactAddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactAddressListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ContactAddressListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContactAddressListHandler
{
    public ContactAddressListHandler(IRequestContext context)
            : base(context)
    {
    }
}