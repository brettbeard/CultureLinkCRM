using Serenity.ComponentModel;

namespace CultureLinkCRM.CrmDB.Forms;

[FormScript("CrmDB.TaxCategory")]
[BasedOnRow(typeof(TaxCategoryRow), CheckNames = true)]
public class TaxCategoryForm
{
    public string SystemCode { get; set; }
    public string SystemName { get; set; }
    public string UserCode { get; set; }
    public string UserName { get; set; }
}