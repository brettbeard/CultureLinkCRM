﻿import { PersonColumns, PersonRow, PersonService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { PersonDialog } from './PersonDialog';

@Decorators.registerClass('CultureLinkCRM.CrmDB.PersonGrid')
export class PersonGrid extends EntityGrid<PersonRow, any> {
    protected getColumnsKey() { return PersonColumns.columnsKey; }
    protected getDialogType() { return PersonDialog; }
    protected getRowDefinition() { return PersonRow; }
    protected getService() { return PersonService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }
}