import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContactGrid } from './ContactGrid';

export default function pageInit() {
    initFullHeightGridPage(new ContactGrid($('#GridDiv')).element);
}