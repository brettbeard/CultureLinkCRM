using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactAddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactAddressDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ContactAddressDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContactAddressDeleteHandler
{
    public ContactAddressDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}