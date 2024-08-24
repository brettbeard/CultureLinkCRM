import { AddressDialog } from "@/CrmDB/Address/AddressDialog";
import { LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ContactAddressForm {
    AddressId: LookupEditor;
}

export class ContactAddressForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.ContactAddress';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ContactAddressForm.init)  {
            ContactAddressForm.init = true;

            var w0 = LookupEditor;

            initFormType(ContactAddressForm, [
                'AddressId', w0
            ]);
        }
    }
}

[AddressDialog]; // referenced types