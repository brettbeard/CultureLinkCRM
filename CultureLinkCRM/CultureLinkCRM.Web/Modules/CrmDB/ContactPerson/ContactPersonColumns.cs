using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.ContactPerson")]
[BasedOnRow(typeof(ContactPersonRow), CheckNames = true)]
public class ContactPersonColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ContactPersonId { get; set; }

    [EditLink]
    public string PersonFullName { get; set; }    
}