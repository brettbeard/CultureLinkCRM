import { initFullHeightGridPage } from '@serenity-is/corelib';
import { GenderGrid } from './GenderGrid';

export default function pageInit() {
    initFullHeightGridPage(new GenderGrid($('#GridDiv')).element);
}