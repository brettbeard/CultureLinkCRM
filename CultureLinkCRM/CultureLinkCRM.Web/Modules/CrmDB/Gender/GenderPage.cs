using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(GenderRow))]
public class GenderPage : Controller
{
    [Route("CrmDB/Gender")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/Gender/GenderPage",
            GenderRow.Fields.PageTitle());
    }
}