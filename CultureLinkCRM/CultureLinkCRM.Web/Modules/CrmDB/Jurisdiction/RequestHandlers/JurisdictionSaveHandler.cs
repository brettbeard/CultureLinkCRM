using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.JurisdictionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.JurisdictionRow;

namespace CultureLinkCRM.CrmDB;

public interface IJurisdictionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class JurisdictionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IJurisdictionSaveHandler
{
    public JurisdictionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}