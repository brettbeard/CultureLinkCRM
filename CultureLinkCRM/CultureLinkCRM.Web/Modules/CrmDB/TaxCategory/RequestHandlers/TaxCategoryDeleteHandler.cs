using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.TaxCategoryRow;

namespace CultureLinkCRM.CrmDB;

public interface ITaxCategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TaxCategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITaxCategoryDeleteHandler
{
    public TaxCategoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}