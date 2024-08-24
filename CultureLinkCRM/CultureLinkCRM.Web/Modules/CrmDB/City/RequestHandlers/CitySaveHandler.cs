using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.CityRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.CityRow;

namespace CultureLinkCRM.CrmDB;

public interface ICitySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class CitySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICitySaveHandler
{
    public CitySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}