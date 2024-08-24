using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(ContactAddressRow))]
public class ContactAddressPage : Controller
{
    [Route("CrmDB/ContactAddress")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/ContactAddress/ContactAddressPage",
            ContactAddressRow.Fields.PageTitle());
    }
}