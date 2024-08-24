using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.Address")]
[BasedOnRow(typeof(AddressRow), CheckNames = true)]
public class AddressForm
{
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    //public string AddressLine3 { get; set; }
    
    public string MailCode { get; set; }
    public string PostalCode { get; set; }

    public int CityId { get; set; }

    public int JurisdictionId { get; set; }

    public int ZipCodeId { get; set; }
}