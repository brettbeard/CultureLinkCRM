using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.PersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
{
    public PersonSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}