using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.AddressRow>;
using MyRow = CultureLinkCRM.CrmDB.AddressRow;

namespace CultureLinkCRM.CrmDB;

public interface IAddressListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AddressListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAddressListHandler
{
    public AddressListHandler(IRequestContext context)
            : base(context)
    {
    }
}