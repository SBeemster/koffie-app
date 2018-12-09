import { Component, OnInit } from '@angular/core';
import { ReportService } from 'src/app/core/services/report.service';
import * as Echarts from 'echarts';

@Component({
  selector: 'app-top-drinker',
  templateUrl: './top-drinker.component.html',
  styleUrls: ['./top-drinker.component.scss']
})
export class TopDrinkerComponent implements OnInit {
  reportData = [];
  topDrinkerChart;
  constructor(private reportService: ReportService) { }

  ngOnInit() {
    this.topDrinkerChart = Echarts.init(document.getElementById('graph'));
    this.reportService.getTopDrinkers().subscribe(
      report => {
        this.reportData.push(report);
      },
      console.error,
      () => {
        console.log('Done fetching report data');
        var option = {
          title: { text: 'TopDrinkers' },
          legend: { orient: 'vertical', pageButtonPosition: 'end' },
          series: [
            {
              name: 'TopDrinkers',
              type: 'pie',
              radius: '55%',
              label: {
                show: true,
                formatter: '{b}: {c}'
              },
              data: this.reportData
            }
          ]
        };
        this.topDrinkerChart.setOption(option);

      }
    );
  }
  buildReport(periode: string) {
    let begintijd;
    let eindtijd;
    var tzoffset = (new Date()).getTimezoneOffset() * 60000; //offset in milliseconds
    if (periode === "today") {
      begintijd = new Date();
      begintijd.setHours(0, 0, 0, 0);
      eindtijd = new Date(begintijd)
      eindtijd.setHours(23, 59, 59);
    } else if (periode === "week") {
      begintijd = new Date();
      begintijd.setHours(0, 0, 0, 0)
      let firstDay = begintijd.getDate() + 1 - begintijd.getDay(); // First day is the day of the month - the day of the week
      begintijd.setDate(firstDay);
      eindtijd = new Date(begintijd)
      eindtijd.setHours(23, 59, 59);
      let lastDay = firstDay + 6; // last day is the first day + 6
      eindtijd.setDate(lastDay);
    } else if (periode === "month") {
      begintijd = new Date();
      begintijd.setHours(0, 0, 0, 0)
      begintijd.setDate(1);
      eindtijd = new Date(begintijd)
      eindtijd.setHours(23, 59, 59);
      eindtijd.setMonth(begintijd.getMonth() + 1);
      eindtijd.setDate(0);
    } else if (periode === "year") {
      begintijd = new Date();
      begintijd.setHours(0, 0, 0, 0)
      begintijd.setDate(1);
      begintijd.setMonth(0);
      eindtijd = new Date(begintijd)
      eindtijd.setHours(23, 59, 59);
      eindtijd.setMonth(11);
      eindtijd.setDate(31);
    }
    this.reportData = [];


    const stringBegintijd = new Date(begintijd - tzoffset).toISOString().slice(0, -1);
    const stringEindtijd = new Date(eindtijd - tzoffset).toISOString().slice(0, -1);

    this.reportService.getTopServers(stringBegintijd, stringEindtijd).subscribe(
      report => {
        this.reportData.push(report);
      },
      console.error,
      () => {
        console.log('Done fetching report data');
        var option = {
          title: { text: 'TopDrinkers' },
          legend: { orient: 'vertical', pageButtonPosition: 'end' },
          series: [
            {
              name: 'TopDrinkers',
              type: 'pie',
              radius: '55%',
              label: {
                show: true,
                formatter: '{b}: {c}'
              },
              data: this.reportData
            }
          ]
        };
        this.topDrinkerChart.setOption(option);

      }
    );
  }
}
