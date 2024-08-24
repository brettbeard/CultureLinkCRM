import { getLookup, getLookupAsync, fieldsProxy } from "@serenity-is/corelib";

export interface PersonRow {
    PersonId?: number;
    FirstName?: string;
    LastName?: string;
    FullName?: string;
    GenderId?: number;
    GenderName?: string;
}

export abstract class PersonRow {
    static readonly idProperty = 'PersonId';
    static readonly nameProperty = 'FullName';
    static readonly localTextPrefix = 'CrmDB.Person';
    static readonly lookupKey = 'CrmDB.Person';

    /** @deprecated use getLookupAsync instead */
    static getLookup() { return getLookup<PersonRow>('CrmDB.Person') }
    static async getLookupAsync() { return getLookupAsync<PersonRow>('CrmDB.Person') }

    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<PersonRow>();
}