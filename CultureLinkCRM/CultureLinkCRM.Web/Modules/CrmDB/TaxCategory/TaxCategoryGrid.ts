import { TaxCategoryColumns, TaxCategoryRow, TaxCategoryService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { TaxCategoryDialog } from './TaxCategoryDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.TaxCategoryGrid')
export class TaxCategoryGrid extends EntityGrid<TaxCategoryRow, any> {
    protected getColumnsKey() { return TaxCategoryColumns.columnsKey; }
    protected getDialogType() { return TaxCategoryDialog; }
    protected getRowDefinition() { return TaxCategoryRow; }
    protected getService() { return TaxCategoryService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}