import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { GridEditorBase } from "@serenity-is/extensions";
import { ContactPersonColumns, ContactPersonRow, ContactPersonService, PersonRow } from '@/ServerTypes/CrmDB';
import { ContactPersonEditDialog } from "./ContactPersonEditDialog";

@Decorators.registerEditor('CultureLinkCRM.CrmDB.ContactPersonEditor')
export class ContactPersonEditor extends GridEditorBase<ContactPersonRow> {
    protected getColumnsKey() { return ContactPersonColumns.columnsKey; }
    protected getLocalTextPrefix() { return ContactPersonRow.localTextPrefix; }

    protected getRowDefinition() { return ContactPersonRow; }
    protected getService() { return ContactPersonService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getDialogType() { return ContactPersonEditDialog; }

    protected getAddButtonCaption() {
        return "Add";
    }

    protected validateEntity(row: ContactPersonRow, id: number) {
        if (!super.validateEntity(row, id))
            return false;

        var itemId = id ?? row[this.getIdProperty()];

        PersonRow.getLookupAsync().then(x => {
            var item = this.view?.getItemById(itemId);
            if (item) {
                item.PersonFullName = x.itemById[row.PersonId].FullName;
                this.view.updateItem(itemId, item);
            }
        });

        return true;
    }
}