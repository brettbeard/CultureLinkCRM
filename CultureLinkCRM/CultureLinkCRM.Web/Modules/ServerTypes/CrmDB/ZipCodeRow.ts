import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface ZipCodeRow {
    ZipCodeId?: number;
    ZipCode?: string;
    ListInd?: number;
}

export abstract class ZipCodeRow {
    static readonly idProperty = 'ZipCodeId';
    static readonly nameProperty = 'ZipCode';
    static readonly localTextPrefix = 'CrmDB.ZipCode';
    static readonly lookupKey = 'CrmDB.ZipCode';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<ZipCodeRow>('CrmDB.ZipCode') }
    static async getLookupAsync() { return getLookupAsync<ZipCodeRow>('CrmDB.ZipCode') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ZipCodeRow>();
}