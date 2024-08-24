using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(CityRow))]
public class CityPage : Controller
{
    [Route("CrmDB/City")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/City/CityPage",
            CityRow.Fields.PageTitle());
    }
}