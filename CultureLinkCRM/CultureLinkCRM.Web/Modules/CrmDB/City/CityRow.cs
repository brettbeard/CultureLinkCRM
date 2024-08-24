using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("City")]
[DisplayName("City"), InstanceName("City")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class CityRow : Row<CityRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("City Id"), PrimaryKey, IdProperty]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field CityId;
        public StringField Name;

    }
}