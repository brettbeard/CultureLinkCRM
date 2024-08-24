import { ZipCodeForm, ZipCodeRow, ZipCodeService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.ZipCodeDialog')
export class ZipCodeDialog extends EntityDialog<ZipCodeRow, any> {
    protected getFormKey() { return ZipCodeForm.formKey; }
    protected getRowDefinition() { return ZipCodeRow; }
    protected getService() { return ZipCodeService.baseUrl; }

    protected form = new ZipCodeForm(this.idPrefix);
}