import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { TaxCategoryRow } from "./TaxCategoryRow";

export interface TaxCategoryColumns {
    TaxCategoryId: Column<TaxCategoryRow>;
    SystemCode: Column<TaxCategoryRow>;
    SystemName: Column<TaxCategoryRow>;
    UserCode: Column<TaxCategoryRow>;
    UserName: Column<TaxCategoryRow>;
}

export class TaxCategoryColumns extends ColumnsBase<TaxCategoryRow> {
    static readonly columnsKey = 'CrmDB.TaxCategory';
    static readonly Fields = fieldsProxy<TaxCategoryColumns>();
}