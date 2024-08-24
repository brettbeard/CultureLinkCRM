import { AddressForm, AddressRow, AddressService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.AddressDialog')
export class AddressDialog extends EntityDialog<AddressRow, any> {
    protected getFormKey() { return AddressForm.formKey; }
    protected getRowDefinition() { return AddressRow; }
    protected getService() { return AddressService.baseUrl; }

    protected form = new AddressForm(this.idPrefix);
}