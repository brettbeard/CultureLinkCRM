using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.TaxCategoryRow>;
using MyRow = CultureLinkCRM.CrmDB.TaxCategoryRow;

namespace CultureLinkCRM.CrmDB;

public interface ITaxCategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TaxCategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITaxCategoryListHandler
{
    public TaxCategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}