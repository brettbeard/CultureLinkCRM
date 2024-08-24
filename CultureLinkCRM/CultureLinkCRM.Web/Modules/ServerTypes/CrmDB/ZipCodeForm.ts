import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ZipCodeForm {
    ZipCode: StringEditor;
}

export class ZipCodeForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.ZipCode';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ZipCodeForm.init)  {
            ZipCodeForm.init = true;

            var w0 = StringEditor;

            initFormType(ZipCodeForm, [
                'ZipCode', w0
            ]);
        }
    }
}