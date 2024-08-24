import { JurisdictionForm, JurisdictionRow, JurisdictionService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.JurisdictionDialog')
export class JurisdictionDialog extends EntityDialog<JurisdictionRow, any> {
    protected getFormKey() { return JurisdictionForm.formKey; }
    protected getRowDefinition() { return JurisdictionRow; }
    protected getService() { return JurisdictionService.baseUrl; }

    protected form = new JurisdictionForm(this.idPrefix);
}