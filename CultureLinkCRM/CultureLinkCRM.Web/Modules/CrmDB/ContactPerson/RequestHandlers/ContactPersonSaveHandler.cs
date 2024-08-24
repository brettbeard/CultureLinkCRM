using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.ContactPersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactPersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactPersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContactPersonSaveHandler
{
    public ContactPersonSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}