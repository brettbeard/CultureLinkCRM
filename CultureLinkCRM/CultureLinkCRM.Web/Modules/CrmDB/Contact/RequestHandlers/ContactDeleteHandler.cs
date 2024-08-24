using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ContactDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContactDeleteHandler
{
    public IServiceResolver<IContactPersonDeleteHandler> contactPersonDelete;

    public IServiceResolver<IContactAddressDeleteHandler> contactAddressDelete;

    public ContactDeleteHandler(IRequestContext context)
            : base(context)
    {
        //this.contactPersonDelete = contactPersonDelete ?? throw new ArgumentNullException(nameof(contactPersonDelete));
        //this.contactAddressDelete = contactAddressDelete ?? throw new ArgumentNullException(nameof(contactAddressDelete));
    }

    /*protected override void OnBeforeDelete()
    {
        base.OnBeforeDelete();

        var personRow = ContactPersonRow.Fields;
        foreach (var detailID in Connection.Query<Int32>(
            new SqlQuery()
                .From(personRow)
                .Select(personRow.ContactPersonId)
                .Where(personRow.ContactId == Row.ContactId.Value)))
        {
            contactPersonDelete.Resolve().Delete(this.UnitOfWork, new()
            {
                EntityId = detailID
            });
        }

        var addressRow = ContactAddressRow.Fields;
        foreach (var detailID in Connection.Query<Int32>(
            new SqlQuery()
                .From(addressRow)
                .Select(addressRow.ContactAddressId)
                .Where(addressRow.ContactId == Row.ContactId.Value)))
        {
            contactAddressDelete.Resolve().Delete(this.UnitOfWork, new()
            {
                EntityId = detailID
            });
        }
    }*/
}