using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.AddressRow>;
using MyRow = CultureLinkCRM.CrmDB.AddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IAddressRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AddressRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAddressRetrieveHandler
{
    public AddressRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}