import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ContactAddressEditor } from './ContactAddressEditor';

export default function pageInit() {
    initFullHeightGridPage(new ContactAddressEditor($('#GridDiv')).element);
}