using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(ContactRow))]
public class ContactPage : Controller
{
    [Route("CrmDB/Contact")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/Contact/ContactPage",
            ContactRow.Fields.PageTitle());
    }
}