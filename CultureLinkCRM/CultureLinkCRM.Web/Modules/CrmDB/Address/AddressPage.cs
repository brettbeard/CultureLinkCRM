using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(AddressRow))]
public class AddressPage : Controller
{
    [Route("CrmDB/Address")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/Address/AddressPage",
            AddressRow.Fields.PageTitle());
    }
}