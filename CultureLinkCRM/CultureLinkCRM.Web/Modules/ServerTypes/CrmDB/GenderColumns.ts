import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { GenderRow } from "./GenderRow";

export interface GenderColumns {
    GenderId: Column<GenderRow>;
    Name: Column<GenderRow>;
}

export class GenderColumns extends ColumnsBase<GenderRow> {
    static readonly columnsKey = 'CrmDB.Gender';
    static readonly Fields = fieldsProxy<GenderColumns>();
}