using MyRequest = CultureLinkCRM.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<CultureLinkCRM.Administration.UserRow>;
using MyRow = CultureLinkCRM.Administration.UserRow;

namespace CultureLinkCRM.Administration;
public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
{
    public UserListHandler(IRequestContext context)
         : base(context)
    {
    }
}