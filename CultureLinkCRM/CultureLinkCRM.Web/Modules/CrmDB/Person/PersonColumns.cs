using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.Person")]
[BasedOnRow(typeof(PersonRow), CheckNames = true)]
public class PersonColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int PersonId { get; set; }
    [EditLink]
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GenderName { get; set; }
}