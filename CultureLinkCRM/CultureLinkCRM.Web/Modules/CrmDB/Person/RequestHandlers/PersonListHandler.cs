using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.CrmDB.PersonRow>;
using MyRow = CultureLinkCRM.CrmDB.PersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class PersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonListHandler
{
    public PersonListHandler(IRequestContext context)
            : base(context)
    {
    }
}