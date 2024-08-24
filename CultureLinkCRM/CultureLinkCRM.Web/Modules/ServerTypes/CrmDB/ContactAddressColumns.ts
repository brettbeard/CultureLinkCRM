import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ContactAddressRow } from "./ContactAddressRow";

export interface ContactAddressColumns {
    ContactAddressId: Column<ContactAddressRow>;
    AddressLine1: Column<ContactAddressRow>;
    CityName: Column<ContactAddressRow>;
    JurisdictionName: Column<ContactAddressRow>;
    ZipCodeName: Column<ContactAddressRow>;
}

export class ContactAddressColumns extends ColumnsBase<ContactAddressRow> {
    static readonly columnsKey = 'CrmDB.ContactAddress';
    static readonly Fields = fieldsProxy<ContactAddressColumns>();
}