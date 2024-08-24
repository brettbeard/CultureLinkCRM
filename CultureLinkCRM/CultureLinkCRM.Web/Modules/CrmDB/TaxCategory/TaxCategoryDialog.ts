import { TaxCategoryForm, TaxCategoryRow, TaxCategoryService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityDialog } from '@serenity-is/corelib';

@Decorators.registerClass('CultureLinkCRM.CrmDB.TaxCategoryDialog')
export class TaxCategoryDialog extends EntityDialog<TaxCategoryRow, any> {
    protected getFormKey() { return TaxCategoryForm.formKey; }
    protected getRowDefinition() { return TaxCategoryRow; }
    protected getService() { return TaxCategoryService.baseUrl; }

    protected form = new TaxCategoryForm(this.idPrefix);
}