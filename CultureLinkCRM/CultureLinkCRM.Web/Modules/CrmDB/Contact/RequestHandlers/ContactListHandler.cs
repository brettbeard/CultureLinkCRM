using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.ContactRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ContactListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContactListHandler
{
    public ContactListHandler(IRequestContext context)
            : base(context)
    {
    }
}