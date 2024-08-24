import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface GenderForm {
    Name: StringEditor;
}

export class GenderForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.Gender';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!GenderForm.init)  {
            GenderForm.init = true;

            var w0 = StringEditor;

            initFormType(GenderForm, [
                'Name', w0
            ]);
        }
    }
}