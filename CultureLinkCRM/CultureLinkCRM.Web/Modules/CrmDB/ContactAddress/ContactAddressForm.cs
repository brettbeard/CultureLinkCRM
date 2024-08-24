using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.ContactAddress")]
[BasedOnRow(typeof(ContactAddressRow), CheckNames = true)]
public class ContactAddressForm
{    
    public int AddressId { get; set; }    
}