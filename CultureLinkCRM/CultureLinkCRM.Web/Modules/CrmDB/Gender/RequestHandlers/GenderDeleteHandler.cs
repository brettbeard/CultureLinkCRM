using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.GenderRow;

namespace CultureLinkCRM.CrmDB;

public interface IGenderDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class GenderDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGenderDeleteHandler
{
    public GenderDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}