import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface JurisdictionRow {
    JurisdictionId?: number;
    JurisdictionTypeId?: number;
    Name?: string;
    Abbreviation?: string;
    ListInd?: number;
    JurisdictionTypeSystemCode?: string;
}

export abstract class JurisdictionRow {
    static readonly idProperty = 'JurisdictionId';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'CrmDB.Jurisdiction';
    static readonly lookupKey = 'CrmDB.Jurisdiction';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<JurisdictionRow>('CrmDB.Jurisdiction') }
    static async getLookupAsync() { return getLookupAsync<JurisdictionRow>('CrmDB.Jurisdiction') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<JurisdictionRow>();
}