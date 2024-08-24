import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContactRow } from "./ContactRow";

export interface ContactColumns {
    ContactId: Column<ContactRow>;
    Name: Column<ContactRow>;
    TaxCategoryName: Column<ContactRow>;
    TaxNumber: Column<ContactRow>;
}

export class ContactColumns extends ColumnsBase<ContactRow> {
    static readonly columnsKey = 'CrmDB.Contact';
    static readonly Fields = fieldsProxy<ContactColumns>();
}