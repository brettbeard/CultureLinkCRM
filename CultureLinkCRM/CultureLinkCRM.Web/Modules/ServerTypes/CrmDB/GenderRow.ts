import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface GenderRow {
    GenderId?: number;
    Name?: string;
}

export abstract class GenderRow {
    static readonly idProperty = 'GenderId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'CrmDB.Gender';
    static readonly lookupKey = 'CrmDB.Gender';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<GenderRow>('CrmDB.Gender') }
    static async getLookupAsync() { return getLookupAsync<GenderRow>('CrmDB.Gender') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<GenderRow>();
}