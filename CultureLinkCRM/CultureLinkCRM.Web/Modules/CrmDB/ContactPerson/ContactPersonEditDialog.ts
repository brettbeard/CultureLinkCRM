import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { GridEditorDialog } from "@serenity-is/extensions";
import { ContactPersonForm, ContactPersonRow, ContactPersonService } from '@/ServerTypes/CrmDB';


@Decorators.registerClass('CultureLinkCRM.CrmDB.ContactPersonEditDialog')
export class ContactPersonEditDialog extends GridEditorDialog<ContactPersonRow> {

    protected getFormKey() { return ContactPersonForm.formKey; }
    protected getNameProperty() { return ContactPersonRow.nameProperty; }
    protected getLocalTextPrefix() { return ContactPersonRow.localTextPrefix; }

    //protected getRowDefinition() { return ContactPersonRow; }
    //protected getService() { return ContactPersonService.baseUrl; }

    protected form = new ContactPersonForm(this.idPrefix);
}