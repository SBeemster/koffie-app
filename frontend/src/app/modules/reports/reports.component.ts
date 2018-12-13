import { Component, OnInit, ElementRef, ViewChildren, QueryList } from '@angular/core';
import { ChartVisible } from './chart-visible';

@Component({
    selector: 'app-reports',
    templateUrl: './reports.component.html',
    styleUrls: ['./reports.component.scss']
})
export class ReportsComponent implements OnInit {
    @ViewChildren('chart') charts: QueryList<ChartVisible>;

    constructor(
        private elementRef: ElementRef
    ) { }

    ngOnInit() {
        const observer = new IntersectionObserver(this.isVisible.bind(this), { root: document.documentElement });
        observer.observe(this.elementRef.nativeElement);
    }

    isVisible(entries, observer): void {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                this.charts.forEach(chart => {
                    chart.onChartVisible();
                });
            }
        });
    }
}
