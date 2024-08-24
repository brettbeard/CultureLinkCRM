using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

[ConnectionKey("Default"), Module("CrmDB"), TableName("Jurisdiction")]
[DisplayName("Jurisdiction"), InstanceName("Jurisdiction")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[ServiceLookupPermission("Administration:General")]
[LookupScript]
public sealed class JurisdictionRow : Row<JurisdictionRow.RowFields>, IIdRow, INameRow
{
    const string jJurisdictionType = nameof(jJurisdictionType);

    [DisplayName("Jurisdiction Id"), PrimaryKey, IdProperty]
    public int? JurisdictionId { get => fields.JurisdictionId[this]; set => fields.JurisdictionId[this] = value; }

    [DisplayName("Jurisdiction Type"), ForeignKey("JurisdictionType", "JurisdictionTypeId"), LeftJoin(jJurisdictionType)]
    [TextualField(nameof(JurisdictionTypeSystemCode))]
    public int? JurisdictionTypeId { get => fields.JurisdictionTypeId[this]; set => fields.JurisdictionTypeId[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Abbreviation")]
    public string Abbreviation { get => fields.Abbreviation[this]; set => fields.Abbreviation[this] = value; }

    [DisplayName("List Ind"), Column("list_ind")]
    public int? ListInd { get => fields.ListInd[this]; set => fields.ListInd[this] = value; }

    [DisplayName("Jurisdiction Type System Code"), Expression($"{jJurisdictionType}.[SystemCode]")]
    public string JurisdictionTypeSystemCode { get => fields.JurisdictionTypeSystemCode[this]; set => fields.JurisdictionTypeSystemCode[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field JurisdictionId;
        public Int32Field JurisdictionTypeId;
        public StringField Name;
        public StringField Abbreviation;
        public Int32Field ListInd;

        public StringField JurisdictionTypeSystemCode;
    }
}