import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface TaxCategoryRow {
    TaxCategoryId?: number;
    SystemCode?: string;
    SystemName?: string;
    UserCode?: string;
    UserName?: string;
}

export abstract class TaxCategoryRow {
    static readonly idProperty = 'TaxCategoryId';
    static readonly nameProperty = 'SystemName';
    static readonly localTextPrefix = 'CrmDB.TaxCategory';
    static readonly lookupKey = 'CrmDB.TaxCategory';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<TaxCategoryRow>('CrmDB.TaxCategory') }
    static async getLookupAsync() { return getLookupAsync<TaxCategoryRow>('CrmDB.TaxCategory') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<TaxCategoryRow>();
}