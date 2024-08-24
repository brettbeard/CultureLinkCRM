import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ZipCodeRow } from "./ZipCodeRow";

export interface ZipCodeColumns {
    ZipCodeId: Column<ZipCodeRow>;
    ZipCode: Column<ZipCodeRow>;
    ListInd: Column<ZipCodeRow>;
}

export class ZipCodeColumns extends ColumnsBase<ZipCodeRow> {
    static readonly columnsKey = 'CrmDB.ZipCode';
    static readonly Fields = fieldsProxy<ZipCodeColumns>();
}