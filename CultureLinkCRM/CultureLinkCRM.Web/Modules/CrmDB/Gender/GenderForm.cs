using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.Gender")]
[BasedOnRow(typeof(GenderRow), CheckNames = true)]
public class GenderForm
{
    public string Name { get; set; }
}