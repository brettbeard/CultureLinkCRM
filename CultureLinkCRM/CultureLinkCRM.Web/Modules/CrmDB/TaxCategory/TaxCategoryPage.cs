using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace CultureLinkCRM.CrmDB.Pages;

[PageAuthorize(typeof(TaxCategoryRow))]
public class TaxCategoryPage : Controller
{
    [Route("CrmDB/TaxCategory")]
    public ActionResult Index()
    {
        return this.GridPage("@/CrmDB/TaxCategory/TaxCategoryPage",
            TaxCategoryRow.Fields.PageTitle());
    }
}