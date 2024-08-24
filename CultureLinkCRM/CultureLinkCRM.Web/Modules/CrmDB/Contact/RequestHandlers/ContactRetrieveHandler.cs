using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<CultureLinkCRM.CrmDB.ContactRow>;
using MyRow = CultureLinkCRM.CrmDB.ContactRow;

namespace CultureLinkCRM.CrmDB;

public interface IContactRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ContactRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContactRetrieveHandler
{
    public ContactRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }

    /*protected override void OnReturn()
    {
        base.OnReturn();

        var contactPersonFields = ContactPersonRow.Fields;

        Row.PersonList = Connection.List<ContactPersonRow>(q => q
            .SelectTableFields()
            .Select(contactPersonFields.PersonFullName)
            .Where(contactPersonFields.ContactId == Row.ContactId.Value));

        var contactAddressFields = ContactAddressRow.Fields;

        Row.AddressList = Connection.List<ContactAddressRow>(q => q
            .SelectTableFields()
            .Select(contactAddressFields.AddressLine1, contactAddressFields.CityName)
            .Where(contactAddressFields.ContactId == Row.ContactId.Value));
    }*/
}