using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("Gender")]
[DisplayName("Gender"), InstanceName("Gender")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class GenderRow : Row<GenderRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Gender Id"), PrimaryKey, Identity, IdProperty]
    public int? GenderId { get => fields.GenderId[this]; set => fields.GenderId[this] = value; }

    [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field GenderId;
        public StringField Name;

    }
}