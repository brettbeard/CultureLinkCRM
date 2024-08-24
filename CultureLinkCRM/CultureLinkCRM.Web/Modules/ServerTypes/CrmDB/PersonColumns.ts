import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { PersonRow } from "./PersonRow";

export interface PersonColumns {
    PersonId: Column<PersonRow>;
    FirstName: Column<PersonRow>;
    LastName: Column<PersonRow>;
    GenderName: Column<PersonRow>;
}

export class PersonColumns extends ColumnsBase<PersonRow> {
    static readonly columnsKey = 'CrmDB.Person';
    static readonly Fields = fieldsProxy<PersonColumns>();
}