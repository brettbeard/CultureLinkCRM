using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.Gender")]
[BasedOnRow(typeof(GenderRow), CheckNames = true)]
public class GenderColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int GenderId { get; set; }
    [EditLink]
    public string Name { get; set; }
}