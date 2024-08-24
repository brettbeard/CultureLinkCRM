import { ContactAddressEditor } from "@/CrmDB/ContactAddress/ContactAddressEditor";
import { ContactPersonEditor } from "@/CrmDB/ContactPerson/ContactPersonEditor";
import { StringEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContactForm {
    Name: StringEditor;
    TaxCategoryId: LookupEditor;
    TaxNumber: StringEditor;
    PersonList: ContactPersonEditor;
    AddressList: ContactAddressEditor;
}

export class ContactForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.Contact';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContactForm.init)  {
            ContactForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;
            var w2 = ContactPersonEditor;
            var w3 = ContactAddressEditor;

            initFormType(ContactForm, [
                'Name', w0,
                'TaxCategoryId', w1,
                'TaxNumber', w0,
                'PersonList', w2,
                'AddressList', w3
            ]);
        }
    }
}