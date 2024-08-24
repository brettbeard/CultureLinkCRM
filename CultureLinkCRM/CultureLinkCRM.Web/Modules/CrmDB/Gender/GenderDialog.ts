import { GenderForm, GenderRow, GenderService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.GenderDialog')
export class GenderDialog extends EntityDialog<GenderRow, any> {
    protected getFormKey() { return GenderForm.formKey; }
    protected getRowDefinition() { return GenderRow; }
    protected getService() { return GenderService.baseUrl; }

    protected form = new GenderForm(this.idPrefix);
}