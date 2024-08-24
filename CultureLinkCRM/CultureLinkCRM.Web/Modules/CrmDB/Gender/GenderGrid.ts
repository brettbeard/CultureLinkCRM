import { GenderColumns, GenderRow, GenderService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GenderDialog } from './GenderDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.GenderGrid')
export class GenderGrid extends EntityGrid<GenderRow, any> {
    protected getColumnsKey() { return GenderColumns.columnsKey; }
    protected getDialogType() { return GenderDialog; }
    protected getRowDefinition() { return GenderRow; }
    protected getService() { return GenderService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}