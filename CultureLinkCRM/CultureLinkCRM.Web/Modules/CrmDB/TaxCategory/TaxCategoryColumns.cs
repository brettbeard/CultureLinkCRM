using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.TaxCategory")]
[BasedOnRow(typeof(TaxCategoryRow), CheckNames = true)]
public class TaxCategoryColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int TaxCategoryId { get; set; }
    [EditLink]
    public string SystemCode { get; set; }
    public string SystemName { get; set; }
    public string UserCode { get; set; }
    public string UserName { get; set; }
}