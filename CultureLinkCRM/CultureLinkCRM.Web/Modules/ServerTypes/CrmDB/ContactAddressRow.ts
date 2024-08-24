import { fieldsProxy } from "@serenity-is/corelib";

export interface ContactAddressRow {
    ContactAddressId?: number;
    ContactId?: number;
    AddressId?: number;
    Future?: string;
    ContactName?: string;
    AddressLine1?: string;
    CityId?: number;
    CityName?: string;
    JurisdictionId?: number;
    JurisdictionName?: string;
    ZipCodeId?: number;
    ZipCodeName?: string;
}

export abstract class ContactAddressRow {
    static readonly idProperty = 'ContactAddressId';
    static readonly nameProperty = 'Future';
    static readonly localTextPrefix = 'CrmDB.ContactAddress';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContactAddressRow>();
}