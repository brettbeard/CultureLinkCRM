import { initFullHeightGridPage } from '@serenity-is/corelib';
import { TaxCategoryGrid } from './TaxCategoryGrid';

export default function pageInit() {
    initFullHeightGridPage(new TaxCategoryGrid($('#GridDiv')).element);
}