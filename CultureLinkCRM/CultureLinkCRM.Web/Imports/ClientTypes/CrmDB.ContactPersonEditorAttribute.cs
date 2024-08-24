using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CultureLinkCRM.CrmDB;

public partial class ContactPersonEditorAttribute : CustomEditorAttribute
{
    public const string Key = "CultureLinkCRM.CrmDB.ContactPersonEditor";

    public ContactPersonEditorAttribute()
        : base(Key)
    {
    }
}