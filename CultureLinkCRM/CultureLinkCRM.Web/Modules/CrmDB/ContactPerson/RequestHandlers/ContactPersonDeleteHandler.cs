using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactPersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactPersonDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ContactPersonDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContactPersonDeleteHandler
{
    public ContactPersonDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}