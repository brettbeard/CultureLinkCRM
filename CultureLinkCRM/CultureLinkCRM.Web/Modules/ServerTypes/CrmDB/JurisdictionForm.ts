import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface JurisdictionForm {
    Name: StringEditor;
    Abbreviation: StringEditor;
}

export class JurisdictionForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.Jurisdiction';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!JurisdictionForm.init)  {
            JurisdictionForm.init = true;

            var w0 = StringEditor;

            initFormType(JurisdictionForm, [
                'Name', w0,
                'Abbreviation', w0
            ]);
        }
    }
}