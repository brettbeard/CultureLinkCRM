using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.ContactAddressRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactAddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactAddressRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactAddressRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContactAddressRetrieveHandler
{
    public ContactAddressRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}