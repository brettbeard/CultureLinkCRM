using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.ZipCode")]
[BasedOnRow(typeof(ZipCodeRow), CheckNames = true)]
public class ZipCodeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ZipCodeId { get; set; }
    [EditLink]
    public string ZipCode { get; set; }
    public int ListInd { get; set; }
}