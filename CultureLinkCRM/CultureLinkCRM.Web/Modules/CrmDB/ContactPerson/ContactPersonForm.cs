using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.ContactPerson")]
[BasedOnRow(typeof(ContactPersonRow), CheckNames = true)]
public class ContactPersonForm
{    
    public int PersonId { get; set; }    
}