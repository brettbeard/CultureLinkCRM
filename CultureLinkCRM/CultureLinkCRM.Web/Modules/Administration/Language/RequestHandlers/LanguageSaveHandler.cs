using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.Administration.LanguageRow;


namespace CultureLinkCRM.Administration;
public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
{
    public LanguageSaveHandler(IRequestContext context)
         : base(context)
    {
    }
}