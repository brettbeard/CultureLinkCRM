import { ZipCodeColumns, ZipCodeRow, ZipCodeService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ZipCodeDialog } from './ZipCodeDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.ZipCodeGrid')
export class ZipCodeGrid extends EntityGrid<ZipCodeRow, any> {
    protected getColumnsKey() { return ZipCodeColumns.columnsKey; }
    protected getDialogType() { return ZipCodeDialog; }
    protected getRowDefinition() { return ZipCodeRow; }
    protected getService() { return ZipCodeService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}