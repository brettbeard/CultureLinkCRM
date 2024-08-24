using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.TaxCategoryRow>;
using MyRow = CultureLinkCRM.CrmDB.TaxCategoryRow;

namespace CultureLinkCRM.CrmDB;

public interface ITaxCategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TaxCategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITaxCategoryRetrieveHandler
{
    public TaxCategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}