using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.Jurisdiction")]
[BasedOnRow(typeof(JurisdictionRow), CheckNames = true)]
public class JurisdictionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int JurisdictionId { get; set; }
    public string JurisdictionTypeSystemCode { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public int ListInd { get; set; }
}