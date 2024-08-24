using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<CultureLinkCRM.CrmDB.ContactRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = CultureLinkCRM.CrmDB.ContactRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContactSaveHandler
{
    private readonly IServiceResolver<IContactPersonDeleteHandler> contactPersonDelete;
    private readonly IServiceResolver<IContactPersonSaveHandler> contactPersonSave;

    private readonly IServiceResolver<IContactAddressDeleteHandler> contactAddressDelete;
    private readonly IServiceResolver<IContactAddressSaveHandler> contactAddressSave;


    public ContactSaveHandler(IRequestContext context)
            : base(context)
    {
        /*this.contactPersonDelete = contactPersonDelete;
        this.contactPersonSave = contactPersonSave;

        this.contactAddressDelete = contactAddressDelete;
        this.contactAddressSave = contactAddressSave;*/
    }

    /*protected override void AfterSave()
    {
        base.AfterSave();

        this.HandlePersonList();

        this.HandleAddressList();
    }*/

    private void HandlePersonList()
    {
        if (Row.PersonList == null)
        {
            return;
        }

        var fields = ContactPersonRow.Fields;
        var oldList = IsCreate ? new List<ContactPersonRow>()
            : Connection.List<ContactPersonRow>(fields.ContactId == Row.ContactId.Value);

        var oldById = oldList.ToDictionary(x => x.ContactPersonId.Value);
        var newById = Row.PersonList.ToLookup(x => x.ContactPersonId);

        foreach (var row in oldList.Where(x => !newById.Contains(x.ContactPersonId)))
        {
            contactPersonDelete.Resolve().Delete(UnitOfWork, new() { EntityId = row.ContactPersonId });
        }

        foreach (var row in Row.PersonList)
        {
            var entity = row.Clone();
            entity.ContactId = Row.ContactId.Value;

            if (row.ContactPersonId == null || !oldById.ContainsKey(row.ContactPersonId.Value))
            {
                entity.ContactPersonId = null;
                contactPersonSave.Resolve().Create(UnitOfWork, new() { Entity = entity });
            }
            else
            {
                contactPersonSave.Resolve().Update(UnitOfWork, new() { Entity = entity });
            }
        }
    }

    private void HandleAddressList()
    {
        if (Row.AddressList == null)
        {
            return;
        }

        var fields = ContactPersonRow.Fields;
        var oldList = IsCreate ? new List<ContactAddressRow>()
            : Connection.List<ContactAddressRow>(fields.ContactId == Row.ContactId.Value);

        var oldById = oldList.ToDictionary(x => x.ContactAddressId.Value);
        var newById = Row.AddressList.ToLookup(x => x.ContactAddressId);

        foreach (var row in oldList.Where(x => !newById.Contains(x.ContactAddressId)))
        {
            contactAddressDelete.Resolve().Delete(UnitOfWork, new() { EntityId = row.ContactAddressId });
        }

        foreach (var row in Row.AddressList)
        {
            var entity = row.Clone();
            entity.ContactId = Row.ContactId.Value;

            if (row.ContactAddressId == null || !oldById.ContainsKey(row.ContactAddressId.Value))
            {
                entity.ContactAddressId = null;
                contactAddressSave.Resolve().Create(UnitOfWork, new() { Entity = entity });
            }
            else
            {
                contactAddressSave.Resolve().Update(UnitOfWork, new() { Entity = entity });
            }
        }
    }
}