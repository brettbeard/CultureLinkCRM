using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("ContactAddress")]
[DisplayName("Contact Address"), InstanceName("Contact Address")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
public sealed class ContactAddressRow : Row<ContactAddressRow.RowFields>, IIdRow, INameRow
{
    const string jContact = nameof(jContact);
    const string jAddress = nameof(jAddress);
    const string jCity = nameof(jCity);

    [DisplayName("Contact Address Id"), PrimaryKey, IdProperty]
    public int? ContactAddressId { get => fields.ContactAddressId[this]; set => fields.ContactAddressId[this] = value; }

    [DisplayName("Contact"), NotNull, ForeignKey(typeof(ContactRow)), LeftJoin(jContact), TextualField(nameof(ContactName))]
    [ServiceLookupEditor(typeof(ContactRow), Service = "CrmDB/Contact/List")]
    public int? ContactId { get => fields.ContactId[this]; set => fields.ContactId[this] = value; }

    [DisplayName("Address"), NotNull, ForeignKey(typeof(AddressRow)), LeftJoin(jAddress), TextualField(nameof(AddressLine1))]
    [LookupEditor(typeof(AddressRow), Async = true, InplaceAdd =true)]
    public int? AddressId { get => fields.AddressId[this]; set => fields.AddressId[this] = value; }

    [DisplayName("Future"), QuickSearch, NameProperty]
    public string Future { get => fields.Future[this]; set => fields.Future[this] = value; }

    [DisplayName("Contact Name"), Origin(jContact, nameof(ContactRow.Name))]
    public string ContactName { get => fields.ContactName[this]; set => fields.ContactName[this] = value; }

    [DisplayName("Address Line1"), Origin(jAddress, nameof(AddressRow.AddressLine1))]
    public string AddressLine1 { get => fields.AddressLine1[this]; set => fields.AddressLine1[this] = value; }

    [DisplayName("City"), Origin(jAddress, nameof(AddressRow.CityId))]    
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("City"), Origin(jAddress, nameof(AddressRow.CityName))]
    public string CityName { get => fields.CityName[this]; set => fields.CityName[this] = value; }

    [DisplayName("State"), Origin(jAddress, nameof(AddressRow.JurisdictionId))]
    public int? JurisdictionId { get => fields.JurisdictionId[this]; set => fields.JurisdictionId[this] = value; }

    [DisplayName("State"), Origin(jAddress, nameof(AddressRow.JurisdictionName))]
    public string JurisdictionName { get => fields.JurisdictionName[this]; set => fields.JurisdictionName[this] = value; }
    
    //[DisplayName("State"), Origin(jAddress, nameof(AddressRow.JurisdictionAbbreviation))]
    //public string JurisdictionAbbr { get => fields.JurisdictionAbbr[this]; set => fields.JurisdictionAbbr[this] = value; }

    [DisplayName("Zip Code"), Origin(jAddress, nameof(AddressRow.ZipCodeId))]
    public int? ZipCodeId { get => fields.ZipCodeId[this]; set => fields.ZipCodeId[this] = value; }

    [DisplayName("Zip Code"), Origin(jAddress, nameof(AddressRow.ZipCodeName))]
    public string ZipCodeName { get => fields.ZipCodeName[this]; set => fields.ZipCodeName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field ContactAddressId;
        public Int32Field ContactId;
        public Int32Field AddressId;
        public StringField Future;

        public StringField ContactName;
        public StringField AddressLine1;

        public Int32Field CityId;
        public StringField CityName;

        public Int32Field JurisdictionId;
        public StringField JurisdictionName;
        //public StringField JurisdictionAbbr;

        public Int32Field ZipCodeId;
        public StringField ZipCodeName;
    }
}