import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface CityRow {
    CityId?: number;
    Name?: string;
}

export abstract class CityRow {
    static readonly idProperty = 'CityId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'CrmDB.City';
    static readonly lookupKey = 'CrmDB.City';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<CityRow>('CrmDB.City') }
    static async getLookupAsync() { return getLookupAsync<CityRow>('CrmDB.City') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<CityRow>();
}