using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(PersonRow))]
public class PersonPage : Controller
{
    [Route("CrmDB/Person")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/Person/PersonPage",
            PersonRow.Fields.PageTitle());
    }
}