import { initFullHeightGridPage } from '@serenity-is/corelib';
import { ZipCodeGrid } from './ZipCodeGrid';

export default function pageInit() {
    initFullHeightGridPage(new ZipCodeGrid($('#GridDiv')).element);
}