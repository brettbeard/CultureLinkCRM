using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.ContactAddress")]
[BasedOnRow(typeof(ContactAddressRow), CheckNames = true)]
public class ContactAddressColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ContactAddressId { get; set; }

    [DisplayName("Address"), EditLink]
    public string AddressLine1 { get; set; }

    [DisplayName("City"), EditLink]
    public string CityName { get; set; }

    [DisplayName("State"), EditLink, Width(50)]
    public string JurisdictionName { get; set; }

    [DisplayName("Zip Code"), EditLink, Width(60)]
    public string ZipCodeName { get; set; }

}