using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.City")]
[BasedOnRow(typeof(CityRow), CheckNames = true)]
public class CityForm
{
    public string Name { get; set; }
}