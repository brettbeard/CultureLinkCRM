import { Decorators } from '@serenity-is/corelib';
import { GridEditorDialog } from '@serenity-is/extensions';
import { ContactAddressForm, ContactAddressRow } from '@/ServerTypes/CrmDB';


@Decorators.registerClass('CultureLinkCRM.CrmDB.ContactAddressEditDialog')
export class ContactAddressEditDialog extends GridEditorDialog<ContactAddressRow> {
    protected getFormKey() { return ContactAddressForm.formKey; }
    protected getNameProperty() { return ContactAddressRow.nameProperty; }
    protected getLocalTextPrefix() { return ContactAddressRow.localTextPrefix; }
    

    protected form = new ContactAddressForm(this.idPrefix);
}