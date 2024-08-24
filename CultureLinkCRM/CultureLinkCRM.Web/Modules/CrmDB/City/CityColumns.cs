using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.City")]
[BasedOnRow(typeof(CityRow), CheckNames = true)]
public class CityColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int CityId { get; set; }
    [EditLink]
    public string Name { get; set; }
}