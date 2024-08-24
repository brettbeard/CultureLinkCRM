import { PersonDialog } from "@/CrmDB/Person/PersonDialog";
import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContactPersonForm {
    PersonId: LookupEditor;
}

export class ContactPersonForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.ContactPerson';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContactPersonForm.init)  {
            ContactPersonForm.init = true;

            var w0 = LookupEditor;

            initFormType(ContactPersonForm, [
                'PersonId', w0
            ]);
        }
    }
}

[PersonDialog]; // referenced types