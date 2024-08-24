using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.PersonRow>;
using MyRow = CultureLinkCRM.CrmDB.PersonRow;

namespace CultureLinkCRM.CrmDB;

public interface IPersonRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class PersonRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonRetrieveHandler
{
    public PersonRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}