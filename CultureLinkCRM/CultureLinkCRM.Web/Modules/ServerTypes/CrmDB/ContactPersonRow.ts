import { fieldsProxy } from "@serenity-is/corelib";

export interface ContactPersonRow {
    ContactPersonId?: number;
    ContactId?: number;
    PersonId?: number;
    Future?: string;
    ContactName?: string;
    PersonFullName?: string;
}

export abstract class ContactPersonRow {
    static readonly idProperty = 'ContactPersonId';
    static readonly nameProperty = 'Future';
    static readonly localTextPrefix = 'CrmDB.ContactPerson';
    static readonly deletePermission = 'Administration:General';
    static readonly insertPermission = 'Administration:General';
    static readonly readPermission = 'Administration:General';
    static readonly updatePermission = 'Administration:General';

    static readonly Fields = fieldsProxy<ContactPersonRow>();
}