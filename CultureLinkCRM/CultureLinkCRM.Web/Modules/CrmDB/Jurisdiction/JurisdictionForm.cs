using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.Jurisdiction")]
[BasedOnRow(typeof(JurisdictionRow), CheckNames = true)]
public class JurisdictionForm
{    
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    
}