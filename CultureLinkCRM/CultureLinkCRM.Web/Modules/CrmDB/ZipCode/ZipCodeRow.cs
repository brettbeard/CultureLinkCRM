using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("ZipCode")]
[DisplayName("Zip Code"), InstanceName("Zip Code")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class ZipCodeRow : Row<ZipCodeRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Zip Code Id"), PrimaryKey, IdProperty]
    public int? ZipCodeId { get => fields.ZipCodeId[this]; set => fields.ZipCodeId[this] = value; }

    [DisplayName("Zip Code"), QuickSearch, NameProperty]
    public string ZipCode { get => fields.ZipCode[this]; set => fields.ZipCode[this] = value; }

    [DisplayName("List Ind"), Column("list_ind")]
    public int? ListInd { get => fields.ListInd[this]; set => fields.ListInd[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ZipCodeId;
        public StringField ZipCode;
        public Int32Field ListInd;

    }
}