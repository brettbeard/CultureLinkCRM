import { AddressColumns, AddressRow, AddressService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { AddressDialog } from './AddressDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.AddressGrid')
export class AddressGrid extends EntityGrid<AddressRow, any> {
    protected getColumnsKey() { return AddressColumns.columnsKey; }
    protected getDialogType() { return AddressDialog; }
    protected getRowDefinition() { return AddressRow; }
    protected getService() { return AddressService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}