import { Component, OnInit, ElementRef, ViewChildren, QueryList } from '@angular/core';
import { ChartVisible } from './chart-visible';

@Component({
    selector: 'app-reports',
    templateUrl: './reports.component.html',
    styleUrls: ['./reports.component.scss']
})
export class ReportsComponent implements OnInit {
    @ViewChildren('chart') charts: QueryList<ChartVisible>;

    resizeTimeout: boolean;

    constructor(
        private elementRef: ElementRef
    ) { }

    ngOnInit() {
        const options = {
            root: document.body.parentElement,
            rootMargin: '20000px'
        };

        const observer = new IntersectionObserver(this.isVisible.bind(this), options);
        observer.observe(this.elementRef.nativeElement);

        window.addEventListener('resize', this.resizeThrottler.bind(this), false);
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

    resizeThrottler() {
        if (!this.resizeTimeout) {
            this.resizeTimeout = true;
            setTimeout(function () {
                this.resizeTimeout = false;
                this.charts.forEach(chart => {
                    chart.onChartVisible();
                });
            }.bind(this), 66);
        }
    }
}
