using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.TaxCategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.TaxCategoryRow;

namespace CultureLinkCRM.CrmDB;

public interface ITaxCategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TaxCategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITaxCategorySaveHandler
{
    public TaxCategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}