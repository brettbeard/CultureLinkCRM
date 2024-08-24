import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContactPersonRow } from "./ContactPersonRow";

export interface ContactPersonColumns {
    ContactPersonId: Column<ContactPersonRow>;
    PersonFullName: Column<ContactPersonRow>;
}

export class ContactPersonColumns extends ColumnsBase<ContactPersonRow> {
    static readonly columnsKey = 'CrmDB.ContactPerson';
    static readonly Fields = fieldsProxy<ContactPersonColumns>();
}