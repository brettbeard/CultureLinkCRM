import { JurisdictionColumns, JurisdictionRow, JurisdictionService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { JurisdictionDialog } from './JurisdictionDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.JurisdictionGrid')
export class JurisdictionGrid extends EntityGrid<JurisdictionRow, any> {
    protected getColumnsKey() { return JurisdictionColumns.columnsKey; }
    protected getDialogType() { return JurisdictionDialog; }
    protected getRowDefinition() { return JurisdictionRow; }
    protected getService() { return JurisdictionService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}