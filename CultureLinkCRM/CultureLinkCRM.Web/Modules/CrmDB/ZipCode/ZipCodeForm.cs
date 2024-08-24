using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.ZipCode")]
[BasedOnRow(typeof(ZipCodeRow), CheckNames = true)]
public class ZipCodeForm
{
    public string ZipCode { get; set; }    
}