using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.Contact")]
[BasedOnRow(typeof(ContactRow), CheckNames = true)]
public class ContactColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ContactId { get; set; }
    [EditLink]
    public string Name { get; set; }

    public string TaxCategoryName { get; set; }

    public string TaxNumber { get; set; }
}