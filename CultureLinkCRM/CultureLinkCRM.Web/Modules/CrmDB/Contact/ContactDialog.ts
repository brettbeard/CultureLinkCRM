import { ContactForm, ContactRow, ContactService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.ContactDialog')
export class ContactDialog extends EntityDialog<ContactRow, any> {
    protected getFormKey() { return ContactForm.formKey; }
    protected getRowDefinition() { return ContactRow; }
    protected getService() { return ContactService.baseUrl; }

    protected form = new ContactForm(this.idPrefix);
}