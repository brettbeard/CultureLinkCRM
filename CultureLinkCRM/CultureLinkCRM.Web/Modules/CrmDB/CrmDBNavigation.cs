using Serenity.Navigation;
using MyPages = CultureLinkCRM.CrmDB.Pages;

[assembly: NavigationLink(int.MaxValue, "CrmDB/Contacts", typeof(MyPages.ContactPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CrmDB/People", typeof(MyPages.PersonPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "CrmDB/Gender", typeof(MyPages.GenderPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "CrmDB/Tax Category", typeof(MyPages.TaxCategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CrmDB/Address", typeof(MyPages.AddressPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "CrmDB/Contact Address", typeof(MyPages.ContactAddressPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CrmDB/City", typeof(MyPages.CityPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CrmDB/States", typeof(MyPages.JurisdictionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "CrmDB/Zip Code", typeof(MyPages.ZipCodePage), icon: null)]