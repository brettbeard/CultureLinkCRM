import { CityColumns, CityRow, CityService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CityDialog } from './CityDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.CityGrid')
export class CityGrid extends EntityGrid<CityRow, any> {
    protected getColumnsKey() { return CityColumns.columnsKey; }
    protected getDialogType() { return CityDialog; }
    protected getRowDefinition() { return CityRow; }
    protected getService() { return CityService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}