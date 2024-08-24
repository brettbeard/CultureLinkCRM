import { initFullHeightGridPage } from '@serenity-is/corelib';
import { CityGrid } from './CityGrid';

export default function pageInit() {
    initFullHeightGridPage(new CityGrid($('#GridDiv')).element);
}