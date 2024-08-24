using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("ContactPerson")]
[DisplayName("Contact Person"), InstanceName("Contact Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ContactPersonRow : Row<ContactPersonRow.RowFields>, IIdRow, INameRow
{
    const string jContact = nameof(jContact);
    const string jPerson = nameof(jPerson);

    [DisplayName("Contact Person Id"), PrimaryKey, Identity, IdProperty]
    public int? ContactPersonId { get => fields.ContactPersonId[this]; set => fields.ContactPersonId[this] = value; }

    [DisplayName("Contact"), NotNull, ForeignKey(typeof(ContactRow)), LeftJoin(jContact), TextualField(nameof(ContactName))]
    [ServiceLookupEditor(typeof(ContactRow), Service = "CrmDB/Contact/List")]
    public int? ContactId { get => fields.ContactId[this]; set => fields.ContactId[this] = value; }

    [DisplayName("Person"), NotNull, ForeignKey(typeof(PersonRow)), LeftJoin(jPerson), TextualField(nameof(PersonFullName))]
    [LookupEditor(typeof(PersonRow), Async = true, InplaceAdd =true)]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }

    [DisplayName("Future"), QuickSearch, NameProperty]
    public string Future { get => fields.Future[this]; set => fields.Future[this] = value; }

    [DisplayName("Contact Name"), Origin(jContact, nameof(ContactRow.Name))]
    public string ContactName { get => fields.ContactName[this]; set => fields.ContactName[this] = value; }

    [DisplayName("Person"), Origin(jPerson, nameof(PersonRow.FullName))]
    public string PersonFullName { get => fields.PersonFullName[this]; set => fields.PersonFullName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ContactPersonId;
        public Int32Field ContactId;
        public Int32Field PersonId;
        public StringField Future;

        public StringField ContactName;
        public StringField PersonFullName;
    }
}