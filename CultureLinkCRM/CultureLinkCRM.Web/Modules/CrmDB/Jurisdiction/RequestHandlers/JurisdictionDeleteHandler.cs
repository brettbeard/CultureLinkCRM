using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.JurisdictionRow;

namespace CultureLinkCRM.CrmDB;

public interface IJurisdictionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class JurisdictionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IJurisdictionDeleteHandler
{
    public JurisdictionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}