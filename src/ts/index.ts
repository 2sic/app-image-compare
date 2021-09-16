import BeerSlider from 'beerslider';
require('../scss/_style.scss');

declare let BeerSlider: any;

const winAny = (window as any);
winAny.appImageCompare2 = winAny.appImageCompare2 || {};
winAny.appImageCompare2.init = winAny.appImageCompare2.init || init;

export function init({ moduleId } : { moduleId: string }) {
    new BeerSlider(document.getElementById(moduleId));
}
