import { CityForm, CityRow, CityService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.CityDialog')
export class CityDialog extends EntityDialog<CityRow, any> {
    protected getFormKey() { return CityForm.formKey; }
    protected getRowDefinition() { return CityRow; }
    protected getService() { return CityService.baseUrl; }

    protected form = new CityForm(this.idPrefix);
}