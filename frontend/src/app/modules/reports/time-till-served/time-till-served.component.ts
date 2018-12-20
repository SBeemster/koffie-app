import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import * as Echarts from 'echarts';
import { ReportService } from 'src/app/core/services/report.service';
import { ChartVisible } from '../chart-visible';

@Component({
    selector: 'app-time-till-served',
    templateUrl: './time-till-served.component.html',
    styleUrls: ['./time-till-served.component.scss']
})
export class TimeTillServedComponent implements OnInit, ChartVisible {

    @ViewChild('graphTime') graphTime: ElementRef;
    reportData = [];
    timeTillServedChart;
    constructor(private reportService: ReportService) { }

    ngOnInit() {
        this.timeTillServedChart = Echarts.init(this.graphTime.nativeElement);
        this.buildReport('Deze maand');
    }

    buildReport(periode: string) {
        let begintijd;
        let eindtijd;
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
        }
        this.reportData = [];


        const stringBegintijd = new Date(begintijd - tzoffset).toISOString().slice(0, -1);
        const stringEindtijd = new Date(eindtijd - tzoffset).toISOString().slice(0, -1);

        this.reportService.getTimeTillServed(stringBegintijd, stringEindtijd).subscribe(
            report => {
                this.reportData.push(report);
            },
            console.error,
            () => {
                const option = {
                    title: {
                        text: 'TimeTillServed: ' + periode
                    },
                    xAxis: {
                        type: 'category',
                        data: this.reportData.map(r => r.name),
                    },
                    tooltip: {
                        trigger: 'axis',
                        formatter: 'Gemiddelde tijd : <br/>{b} : {c} minuten'
                    },
                    yAxis: {
                        type: 'value',
                        axisLabel: {
                            formatter: '{value} min'
                        }
                    },
                    series: [
                        {
                            data: this.reportData,
                            type: 'line'
                        }
                    ]
                };
                this.timeTillServedChart.setOption(option);

            }
        );
    }

    onChartVisible(): void {
        this.timeTillServedChart.resize();
    }

}
