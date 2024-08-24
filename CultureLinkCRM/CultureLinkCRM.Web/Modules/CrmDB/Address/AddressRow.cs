using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("Address")]
[DisplayName("Address"), InstanceName("Address")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class AddressRow : Row<AddressRow.RowFields>, IIdRow, INameRow
{
    const string jCity = nameof(jCity);

    const string jJurisdiction = nameof(jJurisdiction);

    const string jZipCode = nameof(jZipCode);

    [DisplayName("Address Id"), PrimaryKey, Identity, IdProperty]
    public int? AddressId { get => fields.AddressId[this]; set => fields.AddressId[this] = value; }

    [DisplayName("Address 1"), QuickSearch, NameProperty]
    public string AddressLine1 { get => fields.AddressLine1[this]; set => fields.AddressLine1[this] = value; }

    [DisplayName("Address 2")]
    public string AddressLine2 { get => fields.AddressLine2[this]; set => fields.AddressLine2[this] = value; }

    [DisplayName("Address 3")]
    public string AddressLine3 { get => fields.AddressLine3[this]; set => fields.AddressLine3[this] = value; }

    [DisplayName("International Line1")]
    public string InternationalLine1 { get => fields.InternationalLine1[this]; set => fields.InternationalLine1[this] = value; }

    [DisplayName("International Line2")]
    public string InternationalLine2 { get => fields.InternationalLine2[this]; set => fields.InternationalLine2[this] = value; }

    [DisplayName("International Line3")]
    public string InternationalLine3 { get => fields.InternationalLine3[this]; set => fields.InternationalLine3[this] = value; }

    [DisplayName("Mail Code")]
    public string MailCode { get => fields.MailCode[this]; set => fields.MailCode[this] = value; }

    [DisplayName("Postal Code")]
    public string PostalCode { get => fields.PostalCode[this]; set => fields.PostalCode[this] = value; }

    [DisplayName("City"), ForeignKey(typeof(CityRow)), LeftJoin(jCity)]
    [LookupEditor(typeof(CityRow), InplaceAdd = true)]
    public int? CityId { get => fields.CityId[this]; set => fields.CityId[this] = value; }

    [DisplayName("City"), Expression($"{jCity}.Name")]
    public string CityName { get => fields.CityName[this]; set => fields.CityName[this] = value; }

    [DisplayName("State"), ForeignKey(typeof(JurisdictionRow)), LeftJoin(jJurisdiction)]
    [LookupEditor(typeof(JurisdictionRow), InplaceAdd =true)]
    public int? JurisdictionId { get => fields.JurisdictionId[this]; set => fields.JurisdictionId[this] = value; }

    [DisplayName("State"), Expression($"{jJurisdiction}.Name")]
    public string JurisdictionName { get => fields.JurisdictionName[this]; set => fields.JurisdictionName[this] = value; }

    [DisplayName("State"), Expression($"{jJurisdiction}.Abbreviation")]
    public string JurisdictionAbbreviation { get => fields.JurisdictionAbbreviation[this]; set => fields.JurisdictionAbbreviation[this] = value; }

    [DisplayName("Zip Code"), ForeignKey(typeof(ZipCodeRow)), LeftJoin(jZipCode)]
    [LookupEditor(typeof(ZipCodeRow), InplaceAdd = true)]
    public int? ZipCodeId { get => fields.ZipCodeId[this]; set => fields.ZipCodeId[this] = value; }

    [DisplayName("Zip Code"), Expression($"{jZipCode}.ZipCode")]
    public string ZipCodeName { get => fields.ZipCodeName[this]; set => fields.ZipCodeName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field AddressId;
        public StringField AddressLine1;
        public StringField AddressLine2;
        public StringField AddressLine3;
        public StringField InternationalLine1;
        public StringField InternationalLine2;
        public StringField InternationalLine3;
        public StringField MailCode;
        public StringField PostalCode;

        public Int32Field CityId;
        public StringField CityName;

        public Int32Field JurisdictionId;
        public StringField JurisdictionName;
        public StringField JurisdictionAbbreviation;

        public Int32Field ZipCodeId;
        public StringField ZipCodeName;
    }
}