using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("Person")]
[DisplayName("People"), InstanceName("Person")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class PersonRow : Row<PersonRow.RowFields>, IIdRow, INameRow
{
    const string jGender = nameof(jGender);

    [DisplayName("Person Id"), PrimaryKey, Identity, IdProperty]
    public int? PersonId { get => fields.PersonId[this]; set => fields.PersonId[this] = value; }

    [DisplayName("First Name"), NotNull]
    public string FirstName { get => fields.FirstName[this]; set => fields.FirstName[this] = value; }

    [DisplayName("Last Name"), NotNull]
    public string LastName { get => fields.LastName[this]; set => fields.LastName[this] = value; }

    [DisplayName("Full Name"), Concat("t0.FirstName", "' '", "t0.LastName"), QuickSearch, NameProperty]
    public string FullName { get => fields.FullName[this]; set => fields.FullName[this] = value; }

    [DisplayName("Gender"), ForeignKey(typeof(GenderRow)), LeftJoin(jGender)]
    [LookupEditor(typeof(GenderRow))]
    public int? GenderId { get => fields.GenderId[this]; set => fields.GenderId[this] = value; }

    [DisplayName("Gender"), Expression($"{jGender}.Name")]
    public string GenderName { get => fields.GenderName[this]; set => fields.GenderName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field PersonId;
        public StringField FirstName;
        public StringField LastName;

        public StringField FullName;

        public Int32Field GenderId;
        public StringField GenderName;
    }
}