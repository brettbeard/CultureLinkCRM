using CultureLinkCRM.CrmDB.Columns;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("Contact")]
[DisplayName("Contact"), InstanceName("Contact")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ContactRow : Row<ContactRow.RowFields>, IIdRow, INameRow
{
    const string jTaxCategory = nameof(jTaxCategory);

    [DisplayName("Contact Id"), PrimaryKey, Identity, IdProperty]
    public int? ContactId { get => fields.ContactId[this]; set => fields.ContactId[this] = value; }

    [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [MasterDetailRelation(foreignKey: nameof(ContactPersonRow.ContactId), ColumnsType = typeof(ContactPersonColumns))]
    [DisplayName("Person List"), NotMapped]
    public List<ContactPersonRow> PersonList { get => fields.PersonList[this]; set => fields.PersonList[this] = value; }

    [MasterDetailRelation(foreignKey: nameof(ContactAddressRow.ContactId), ColumnsType = typeof(ContactAddressColumns))]

    [DisplayName("Address List"), NotMapped]
    public List<ContactAddressRow> AddressList { get => fields.AddressList[this]; set => fields.AddressList[this] = value; }

    [DisplayName("Tax Number")]
    public string TaxNumber { get => fields.TaxNumber[this]; set => fields.TaxNumber[this] = value; }

    [DisplayName("Tax Category"), ForeignKey(typeof(TaxCategoryRow)), LeftJoin(jTaxCategory)]
    [LookupEditor(typeof(TaxCategoryRow))]
    public int? TaxCategoryId { get => fields.TaxCategoryId[this]; set => fields.TaxCategoryId[this] = value; }

    [DisplayName("Tax Category"), Expression($"{jTaxCategory}.SystemName")]
    public string TaxCategoryName { get => fields.TaxCategoryName[this]; set => fields.TaxCategoryName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ContactId;
        public StringField Name;

        public Int32Field TaxCategoryId;
        public StringField TaxCategoryName;

        public StringField TaxNumber;

        public RowListField<ContactPersonRow> PersonList;

        public RowListField<ContactAddressRow> AddressList;
    }
}