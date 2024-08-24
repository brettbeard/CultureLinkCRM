using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(ZipCodeRow))]
public class ZipCodePage : Controller
{
    [Route("CrmDB/ZipCode")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/ZipCode/ZipCodePage",
            ZipCodeRow.Fields.PageTitle());
    }
}