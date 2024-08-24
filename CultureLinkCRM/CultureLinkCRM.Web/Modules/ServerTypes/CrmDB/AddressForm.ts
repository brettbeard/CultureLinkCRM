import { CityDialog } from "@/CrmDB/City/CityDialog";
import { JurisdictionDialog } from "@/CrmDB/Jurisdiction/JurisdictionDialog";
import { ZipCodeDialog } from "@/CrmDB/ZipCode/ZipCodeDialog";
import { StringEditor, LookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface AddressForm {
    AddressLine1: StringEditor;
    AddressLine2: StringEditor;
    MailCode: StringEditor;
    PostalCode: StringEditor;
    CityId: LookupEditor;
    JurisdictionId: LookupEditor;
    ZipCodeId: LookupEditor;
}

export class AddressForm extends PrefixedContext {
    static readonly formKey = 'CrmDB.Address';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!AddressForm.init)  {
            AddressForm.init = true;

            var w0 = StringEditor;
            var w1 = LookupEditor;

            initFormType(AddressForm, [
                'AddressLine1', w0,
                'AddressLine2', w0,
                'MailCode', w0,
                'PostalCode', w0,
                'CityId', w1,
                'JurisdictionId', w1,
                'ZipCodeId', w1
            ]);
        }
    }
}

[CityDialog, JurisdictionDialog, ZipCodeDialog]; // referenced types