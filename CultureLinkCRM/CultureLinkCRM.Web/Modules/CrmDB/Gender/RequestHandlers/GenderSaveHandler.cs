using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.GenderRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.GenderRow;

namespace CultureLinkCRM.CrmDB;

public interface IGenderSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GenderSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenderSaveHandler
{
    public GenderSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}