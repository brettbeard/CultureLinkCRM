using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.Contact")]
[BasedOnRow(typeof(ContactRow), CheckNames = true)]
public class ContactForm
{
    public string Name { get; set; }

    public int TaxCategoryId { get; set; }

    public string TaxNumber { get; set; }

    [DisplayName("People"), ContactPersonEditor, IgnoreName]
    public List<ContactPersonRow> PersonList { get; set; }

    [DisplayName("Address"), ContactAddressEditor, IgnoreName]
    public List<ContactAddressRow> AddressList { get; set; }
}