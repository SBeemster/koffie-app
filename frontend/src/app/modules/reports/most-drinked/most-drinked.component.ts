import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import * as Echarts from 'echarts';
import { ReportService } from 'src/app/core/services/report.service';
import { ChartVisible } from '../chart-visible';

@Component({
    selector: 'app-most-drinked',
    templateUrl: './most-drinked.component.html',
    styleUrls: ['./most-drinked.component.scss']
})
export class MostDrinkedComponent implements OnInit, ChartVisible {
    @ViewChild('graphDrinks') graphDrinks: ElementRef;
    reportData = [];
    mostDrinksChart;
    constructor(private reportService: ReportService) { }

    ngOnInit() {
        this.mostDrinksChart = Echarts.init(this.graphDrinks.nativeElement);
        this.buildReport('All time')
    }

    buildReport(periode: string) {
        this.mostDrinksChart.resize();
        let begintijd;
        let eindtijd;
        let stringBegintijd;
        let stringEindtijd
        const tzoffset = (new Date()).getTimezoneOffset() * 60000; // offset in milliseconds
        if (periode === 'Vandaag') {
            begintijd = new Date();
            begintijd.setHours(0, 0, 0, 0);
            eindtijd = new Date(begintijd);
            eindtijd.setHours(23, 59, 59);
        } else if (periode === 'Deze week') {
            begintijd = new Date();
            begintijd.setHours(0, 0, 0, 0);
            const firstDay = begintijd.getDate() - begintijd.getDay(); // First day is the day of the month - the day of the week
            begintijd.setDate(firstDay);
            eindtijd = new Date(begintijd);
            eindtijd.setHours(23, 59, 59);
            const lastDay = firstDay + 6; // last day is the first day + 6
            eindtijd.setDate(lastDay);
        } else if (periode === 'Deze maand') {
            begintijd = new Date();
            begintijd.setHours(0, 0, 0, 0);
            begintijd.setDate(1);
            eindtijd = new Date(begintijd);
            eindtijd.setHours(23, 59, 59);
            eindtijd.setMonth(begintijd.getMonth() + 1);
            eindtijd.setDate(0);
        } else if (periode === 'Dit jaar') {
            begintijd = new Date();
            begintijd.setHours(0, 0, 0, 0);
            begintijd.setDate(1);
            begintijd.setMonth(0);
            eindtijd = new Date(begintijd);
            eindtijd.setHours(23, 59, 59);
            eindtijd.setMonth(11);
            eindtijd.setDate(31);
        }
        if (begintijd != null) {
            stringBegintijd = new Date(begintijd - tzoffset).toISOString().slice(0, -1);
            stringEindtijd = new Date(eindtijd - tzoffset).toISOString().slice(0, -1);
        }
        this.reportData = [];
        this.reportService.getMostDrinked(stringBegintijd, stringEindtijd).subscribe(
            report => {
                this.reportData.push(report);
            },
            console.error,
            () => {
                const option = {
                    title: { text: 'Most drinked drinks: ' + periode },
                    tooltip: {
                        trigger: 'item',
                        type: 'shadow',
                        formatter: '{b} <br/>{c}'
                    },
                    grid: {
                        left: '3%',
                        right: '4%',
                        bottom: '3%',
                        containLabel: true
                    },
                    xAxis: {
                        type: 'category',
                        data: this.reportData.map(r => r.name),
                    },
                    yAxis: {
                        type: 'value',
                        axisLabel: {
                            formatter: '{value}'
                        }
                    },
                    series: [
                        {
                            name: 'Most drinked drinks',
                            type: 'bar',
                            barWidth: '60%',
                            label: {
                                show: false
                            },
                            data: this.reportData
                        }
                    ]
                };
                this.mostDrinksChart.setOption(option);

            }
        );
    }

    onChartVisible(): void {
        this.mostDrinksChart.resize();
    }
}
