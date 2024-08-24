import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { JurisdictionRow } from "./JurisdictionRow";

export interface JurisdictionColumns {
    JurisdictionId: Column<JurisdictionRow>;
    JurisdictionTypeSystemCode: Column<JurisdictionRow>;
    Name: Column<JurisdictionRow>;
    Abbreviation: Column<JurisdictionRow>;
    ListInd: Column<JurisdictionRow>;
}

export class JurisdictionColumns extends ColumnsBase<JurisdictionRow> {
    static readonly columnsKey = 'CrmDB.Jurisdiction';
    static readonly Fields = fieldsProxy<JurisdictionColumns>();
}