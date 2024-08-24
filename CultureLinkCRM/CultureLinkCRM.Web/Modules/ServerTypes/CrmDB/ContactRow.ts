import { fieldsProxy } from "@serenity-is/corelib";
import { ContactAddressRow } from "./ContactAddressRow";
import { ContactPersonRow } from "./ContactPersonRow";

export interface ContactRow {
    ContactId?: number;
    Name?: string;
    TaxCategoryId?: number;
    TaxCategoryName?: string;
    TaxNumber?: string;
    PersonList?: ContactPersonRow[];
    AddressList?: ContactAddressRow[];
}

export abstract class ContactRow {
    static readonly idProperty = 'ContactId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'CrmDB.Contact';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContactRow>();
}