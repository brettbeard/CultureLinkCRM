using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonForm
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int GenderId { get; set; }
}