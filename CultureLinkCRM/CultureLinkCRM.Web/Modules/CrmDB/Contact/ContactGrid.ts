import { ContactColumns, ContactRow, ContactService } from '@/ServerTypes/CrmDB';
import { Decorators, EntityGrid, ToolButton } from '@serenity-is/corelib';
import { ContactDialog } from './ContactDialog';
import { ExcelExportHelper, PdfExportHelper, ReportHelper } from "@serenity-is/extensions";

@Decorators.registerClass('CultureLinkCRM.CrmDB.ContactGrid')
export class ContactGrid extends EntityGrid<ContactRow, any> {
    protected getColumnsKey() { return ContactColumns.columnsKey; }
    protected getDialogType() { return ContactDialog; }
    protected getRowDefinition() { return ContactRow; }
    protected getService() { return ContactService.baseUrl; }

    constructor(container: JQuery) {
        super(container);
    }

    protected getButtons(): ToolButton[] {
        var buttons = super.getButtons();

        buttons.push(ExcelExportHelper.createToolButton({
            grid: this,
            service: ContactService.baseUrl + '/ListExcel',
            onViewSubmit: () => this.onViewSubmit(),
            separator: true
        }));

        buttons.push(PdfExportHelper.createToolButton({
            grid: this,
            onViewSubmit: () => this.onViewSubmit()
        }));

        return buttons;
    }
}