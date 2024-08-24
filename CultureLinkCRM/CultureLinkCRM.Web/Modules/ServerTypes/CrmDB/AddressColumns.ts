import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { AddressRow } from "./AddressRow";

export interface AddressColumns {
    AddressId: Column<AddressRow>;
    AddressLine1: Column<AddressRow>;
    CityName: Column<AddressRow>;
    JurisdictionAbbreviation: Column<AddressRow>;
    ZipCodeName: Column<AddressRow>;
}

export class AddressColumns extends ColumnsBase<AddressRow> {
    static readonly columnsKey = 'CrmDB.Address';
    static readonly Fields = fieldsProxy<AddressColumns>();
}