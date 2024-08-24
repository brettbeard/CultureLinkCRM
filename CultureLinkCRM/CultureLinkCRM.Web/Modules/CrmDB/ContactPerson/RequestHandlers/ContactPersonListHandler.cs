using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.ContactPersonRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactPersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ContactPersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContactPersonListHandler
{
    public ContactPersonListHandler(IRequestContext context)
            : base(context)
    {
    }
}