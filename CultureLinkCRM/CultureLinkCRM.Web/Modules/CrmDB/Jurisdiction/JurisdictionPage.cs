using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(JurisdictionRow))]
public class JurisdictionPage : Controller
{
    [Route("CrmDB/Jurisdiction")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/Jurisdiction/JurisdictionPage",
            JurisdictionRow.Fields.PageTitle());
    }
}