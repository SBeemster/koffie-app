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
        const options = {
            root: document.body.parentElement,
            rootMargin: "20000px"
        }
        const observer = new IntersectionObserver(this.isVisible.bind(this), options);
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
