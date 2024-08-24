using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.JurisdictionRow>;
using MyRow = CultureLinkCRM.CrmDB.JurisdictionRow;

namespace CultureLinkCRM.CrmDB;

public interface IJurisdictionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class JurisdictionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IJurisdictionListHandler
{
    public JurisdictionListHandler(IRequestContext context)
            : base(context)
    {
    }
}