import { initFullHeightGridPage } from '@serenity-is/corelib';
import { JurisdictionGrid } from './JurisdictionGrid';

export default function pageInit() {
    initFullHeightGridPage(new JurisdictionGrid($('#GridDiv')).element);
}