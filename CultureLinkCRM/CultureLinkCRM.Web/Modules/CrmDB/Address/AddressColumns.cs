using Serenity.ComponentModel;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB.Columns;

[ColumnsScript("CrmDB.Address")]
[BasedOnRow(typeof(AddressRow), CheckNames = true)]
public class AddressColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int AddressId { get; set; }

    [EditLink, DisplayName("Address")]
    public string AddressLine1 { get; set; }    

    public string CityName { get; set; }

    //public string JurisdictionName { get; set; }

    public string JurisdictionAbbreviation { get; set; }    

    public string ZipCodeName { get; set; }
}