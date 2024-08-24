using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

public partial class ContactAddressEditorAttribute : CustomEditorAttribute
{
    public const string Key = "CultureLinkCRM.CrmDB.ContactAddressEditor";

    public ContactAddressEditorAttribute()
        : base(Key)
    {
    }
}