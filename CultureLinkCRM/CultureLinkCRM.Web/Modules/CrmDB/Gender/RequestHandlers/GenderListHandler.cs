using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.GenderRow>;
using MyRow = CultureLinkCRM.CrmDB.GenderRow;

namespace CultureLinkCRM.CrmDB;

public interface IGenderListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GenderListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGenderListHandler
{
    public GenderListHandler(IRequestContext context)
            : base(context)
    {
    }
}