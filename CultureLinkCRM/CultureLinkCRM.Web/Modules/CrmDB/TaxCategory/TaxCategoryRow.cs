using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("TaxCategory")]
[DisplayName("Tax Category"), InstanceName("Tax Category")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class TaxCategoryRow : Row<TaxCategoryRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Tax Category Id"), PrimaryKey, Identity, IdProperty]
    public int? TaxCategoryId { get => fields.TaxCategoryId[this]; set => fields.TaxCategoryId[this] = value; }

    [DisplayName("System Code"), NotNull, QuickSearch]
    public string SystemCode { get => fields.SystemCode[this]; set => fields.SystemCode[this] = value; }

    [DisplayName("System Name"), NotNull, NameProperty]
    public string SystemName { get => fields.SystemName[this]; set => fields.SystemName[this] = value; }

    [DisplayName("User Code"), NotNull]
    public string UserCode { get => fields.UserCode[this]; set => fields.UserCode[this] = value; }

    [DisplayName("User Name"), NotNull]
    public string UserName { get => fields.UserName[this]; set => fields.UserName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field TaxCategoryId;
        public StringField SystemCode;
        public StringField SystemName;
        public StringField UserCode;
        public StringField UserName;

    }
}