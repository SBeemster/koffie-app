import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import * as Echarts from 'echarts';
import { ReportService } from 'src/app/core/services/report.service';
import { ChartVisible } from '../chart-visible';

@Component({
    selector: 'app-top-server',
    templateUrl: './top-server.component.html',
    styleUrls: ['./top-server.component.scss']
})
export class TopServerComponent implements OnInit, ChartVisible {
    @ViewChild('graphServer') graphServer: ElementRef;
    reportData = [];
    topServerChart;
    constructor(private reportService: ReportService) { }

    ngOnInit() {
        this.topServerChart = Echarts.init(this.graphServer.nativeElement);
        this.buildReport('All time');
    }
    buildReport(periode: string) {
        let begintijd;
        let eindtijd;
        let stringBegintijd;
        let stringEindtijd;
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
        if (begintijd != null && eindtijd != null) {
            stringBegintijd = new Date(begintijd - tzoffset).toISOString().slice(0, -1);
            stringEindtijd = new Date(eindtijd - tzoffset).toISOString().slice(0, -1);
        }
        this.reportData = [];
        this.reportService.getTopServers(stringBegintijd, stringEindtijd).subscribe(
            report => {
                this.reportData.push(report);
            },
            console.error,
            () => {
                console.log('Done fetching report data');
                const option = {
                    title: { text: 'TopServers: ' + periode },
                    legend: { orient: 'vertical', pageButtonPosition: 'end' },
                    tooltip: {
                        trigger: 'item',
                        formatter: '{b} <br/>{c}'
                    },
                    series: [
                        {
                            name: 'TopServers',
                            type: 'pie',
                            radius: '55%',
                            label: {
                                show: false
                            },
                            data: this.reportData
                        }
                    ]
                };
                this.topServerChart.setOption(option);

            }
        );
    }

    onChartVisible(): void {
        this.topServerChart.resize();
    }
}
