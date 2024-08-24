using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.Administration.LanguageRow>;
using MyRow = CultureLinkCRM.Administration.LanguageRow;


namespace CultureLinkCRM.Administration;
public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
{
    public LanguageListHandler(IRequestContext context)
         : base(context)
    {
    }
}