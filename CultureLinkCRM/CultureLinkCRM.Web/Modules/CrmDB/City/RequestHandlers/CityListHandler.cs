using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.CityRow>;
using MyRow = CultureLinkCRM.CrmDB.CityRow;

namespace CultureLinkCRM.CrmDB;

public interface ICityListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class CityListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICityListHandler
{
    public CityListHandler(IRequestContext context)
            : base(context)
    {
    }
}