import { StringEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface PersonForm {
    FirstName: StringEditor;
    LastName: StringEditor;
    GenderId: LookupEditor;
}

export class PersonForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.Person';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!PersonForm.init)  {
            PersonForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(PersonForm, [
                'FirstName', w0,
                'LastName', w0,
                'GenderId', w1
            ]);
        }
    }
}