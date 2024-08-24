import { Decorators } from '@serenity-is/corelib';
import { GridEditorBase } from '@serenity-is/extensions';
import { AddressRow, ContactAddressColumns, ContactAddressRow } from '@/ServerTypes/CrmDB';
import { ContactAddressEditDialog } from './ContactAddressEditDialog';

@Decorators.registerEditor('CultureLinkCRM.CrmDB.ContactAddressEditor')
export class ContactAddressEditor extends GridEditorBase<ContactAddressRow> {
    protected getColumnsKey() { return ContactAddressColumns.columnsKey; }
    protected getLocalTextPrefix() { return ContactAddressRow.localTextPrefix; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getDialogType() { return ContactAddressEditDialog; }

    protected getAddButtonCaption() { return "Add"; }

    protected validateEntity(row: ContactAddressRow, id: number) {
        if (!super.validateEntity(row, id))
            return false;

        var itemId = id ?? row[this.getIdProperty()];

        AddressRow.getLookupAsync().then(x => {
            var item = this.view?.getItemById(itemId);
            if (item) {
                item.AddressLine1 = x.itemById[row.AddressId].AddressLine1;
                item.CityName = x.itemById[row.AddressId].CityName;
                
                this.view.updateItem(itemId, item);
            }
        });

        return true;
    }
}