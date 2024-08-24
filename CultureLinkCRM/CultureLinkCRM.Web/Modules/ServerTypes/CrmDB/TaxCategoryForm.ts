import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface TaxCategoryForm {
    SystemCode: StringEditor;
    SystemName: StringEditor;
    UserCode: StringEditor;
    UserName: StringEditor;
}

export class TaxCategoryForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.TaxCategory';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!TaxCategoryForm.init)  {
            TaxCategoryForm.init = true;

            var w0 = StringEditor;

            initFormType(TaxCategoryForm, [
                'SystemCode', w0,
                'SystemName', w0,
                'UserCode', w0,
                'UserName', w0
            ]);
        }
    }
}