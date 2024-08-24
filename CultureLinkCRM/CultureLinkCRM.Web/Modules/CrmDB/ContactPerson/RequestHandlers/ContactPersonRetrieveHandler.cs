using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.ContactPersonRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactPersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactPersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContactPersonRetrieveHandler
{
    public ContactPersonRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}