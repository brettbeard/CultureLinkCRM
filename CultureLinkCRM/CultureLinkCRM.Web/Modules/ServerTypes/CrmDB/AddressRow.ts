import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface AddressRow {
    AddressId?: number;
    AddressLine1?: string;
    AddressLine2?: string;
    AddressLine3?: string;
    InternationalLine1?: string;
    InternationalLine2?: string;
    InternationalLine3?: string;
    MailCode?: string;
    PostalCode?: string;
    CityId?: number;
    CityName?: string;
    JurisdictionId?: number;
    JurisdictionName?: string;
    JurisdictionAbbreviation?: string;
    ZipCodeId?: number;
    ZipCodeName?: string;
}

export abstract class AddressRow {
    static readonly idProperty = 'AddressId';
    static readonly nameProperty = 'AddressLine1';
    static readonly localTextPrefix = 'CrmDB.Address';
    static readonly lookupKey = 'CrmDB.Address';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<AddressRow>('CrmDB.Address') }
    static async getLookupAsync() { return getLookupAsync<AddressRow>('CrmDB.Address') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<AddressRow>();
}