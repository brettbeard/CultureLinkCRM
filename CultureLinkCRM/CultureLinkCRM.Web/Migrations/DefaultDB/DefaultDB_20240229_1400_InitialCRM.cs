using FluentMigrator;

namespace CultureLinkCRM.Migrations.DefaultDB;

[DefaultDB, MigrationKey(20240229_1400)]
public class DefaultDB_20240229_1400_InitialCRM : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Contact")
            .WithColumn("ContactId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).NotNullable()
            .WithColumn("TaxNumber").AsString(100).Nullable()
            .WithColumn("TaxCategoryId").AsInt32().Nullable()
                .ForeignKey("FK_Contact_TaxCategoryId", "TaxCategory", "TaxCategoryId");

        Create.Table("TaxCategory")
            .WithColumn("TaxCategoryId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("SystemCode").AsString(100).NotNullable()
            .WithColumn("SystemName").AsString(100).NotNullable()
            .WithColumn("UserCode").AsString(100).NotNullable()
            .WithColumn("UserName").AsString(100).NotNullable();

        Create.Table("Person")
            .WithColumn("PersonId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("FirstName").AsString(200).NotNullable()
            .WithColumn("LastName").AsString(200).NotNullable()
            .WithColumn("GenderId").AsInt32().NotNullable()
                .ForeignKey("FK_Person_GenderId", "Gender", "GenderId");

        Create.Table("Gender")
            .WithColumn("GenderId").AsInt32()
                .Identity().PrimaryKey().NotNullable()            
            .WithColumn("Name").AsString(100).NotNullable();        

        Create.Table("ContactPerson")
            .WithColumn("ContactPersonId").AsInt32().Identity()
                .PrimaryKey().NotNullable()
            .WithColumn("ContactId").AsInt32().NotNullable()
                .ForeignKey("FK_ContactPerson_ContactId", "Contact", "ContactId")
            .WithColumn("PersonId").AsInt32().NotNullable()
                .ForeignKey("FK_ContactPerson_PersonId", "Person", "PersonId")
            .WithColumn("Future").AsString(50).Nullable();

        Create.Table("Address")
            .WithColumn("AddressId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("AddressLine1").AsString(200).Nullable()
            .WithColumn("AddressLine2").AsString(200).Nullable()
            .WithColumn("AddressLine3").AsString(200).Nullable()
            .WithColumn("InternationalLine1").AsString(200).Nullable()
            .WithColumn("InternationalLine2").AsString(200).Nullable()
            .WithColumn("InternationalLine3").AsString(200).Nullable()
            .WithColumn("MailCode").AsString(100).Nullable()
            .WithColumn("PostalCode").AsString(100).Nullable()
            .WithColumn("CityId").AsInt32().Nullable()
                .ForeignKey("FK_City_CityId", "City", "CityId")
            .WithColumn("JurisdictionId").AsInt32().Nullable()
                .ForeignKey("FK_Jurisdiction_JurisdictionId", "Jurisdiction", "JurisdictionId")
            .WithColumn("ZipCodeId").AsInt32().Nullable()
                .ForeignKey("FK_ZipCode_ZipCodeId", "ZipCode", "ZipCodeId");

        Create.Table("Country")
            .WithColumn("CountryId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).Nullable()
            .WithColumn("Abbreviation").AsString(8).Nullable()
            .WithColumn("list_ind").AsInt16().WithDefaultValue(0);

        Insert.IntoTable("Country")
            .Row(new
            {
                Name = "United States",
                Abbreviation = "US"
            });

        Create.Table("Jurisdiction")
            .WithColumn("JurisdictionId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("JurisdictionTypeId").AsInt32().Nullable()
                .ForeignKey("FK_Juridiction_JurisdictionTypeId", "JurisdictionType", "JurisdictionTypeId")            
            .WithColumn("Name").AsString(200).Nullable()
            .WithColumn("Abbreviation").AsString(200).Nullable()
            .WithColumn("list_ind").AsInt16().WithDefaultValue(0);

        Create.Table("JurisdictionType")
            .WithColumn("JurisdictionTypeId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("SystemCode").AsString(100).NotNullable()
            .WithColumn("SystemName").AsString(100).NotNullable()
            .WithColumn("UserCode").AsString(100).NotNullable()
            .WithColumn("UserName").AsString(100).NotNullable()
            .WithColumn("list_ind").AsInt16().WithDefaultValue(0)
            .WithColumn("sort_order").AsInt16().WithDefaultValue(0);

        Insert.IntoTable("JurisdictionType")
            .Row(new
            {
                SystemCode = "DEF",
                SystemName = "Default",
                UserCode = "DEF",
                UserName = "Default"
            });

        Insert.IntoTable("Jurisdiction")
            .Row(new
            {
                JurisdictionTypeId = 1,
                Name = "Georgia",
                Abbreviation = "GA"
            })        
            .Row(new
            {
                JurisdictionTypeId = 1,
                Name = "Alabama",
                Abbreviation = "AL"
            });

        Create.Table("City")
            .WithColumn("CityId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("Name").AsString(200).Nullable()
            .WithColumn("list_ind").AsInt16().WithDefaultValue(0);

        Create.Table("ZipCode")
            .WithColumn("ZipCodeId").AsInt32()
                .Identity().PrimaryKey().NotNullable()
            .WithColumn("ZipCode").AsString(16).Nullable()
            .WithColumn("list_ind").AsInt16().WithDefaultValue(0);

        Create.Table("ContactAddress")
            .WithColumn("ContactAddressId").AsInt32().Identity()
                .PrimaryKey().NotNullable()
            .WithColumn("ContactId").AsInt32().NotNullable()
                .ForeignKey("FK_ContactAddress_ContactId", "Contact", "ContactId")
            .WithColumn("AddressId").AsInt32().NotNullable()
                .ForeignKey("FK_ContactAddress_AddressId", "Address", "AddressId")
            .WithColumn("Future").AsString(50).Nullable(); 

        Insert.IntoTable("Gender")
            .Row(new { Name = "Male" })
            .Row(new { Name = "Female" })
            .Row(new { Name = "Non-binary" });

        Insert.IntoTable("TaxCategory")
            .Row(new
            {
                SystemCode = "IND",
                SystemName = "Individual",
                UserCode = "IND",
                UserName = "Individual"
            })
             .Row(new
             {
                 SystemCode = "BUS",
                 SystemName = "Business",
                 UserCode = "BUS",
                 UserName = "Business"
             })
             .Row(new
             {
                 SystemCode = "OTH",
                 SystemName = "Other",
                 UserCode = "OTH",
                 UserName = "Other"
             });
    }
}
