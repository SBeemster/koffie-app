import { Component, OnInit } from '@angular/core';
import { Echarts } from 'echarts';

@Component({
  selector: 'app-top-server',
  templateUrl: './top-server.component.html',
  styleUrls: ['./top-server.component.scss']
})
export class TopServerComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    var myChart = Echarts.init(document.getElementById('graph'));

    var option = {
      title: {
          text: 'ECharts entry example'
      },
      tooltip: {},
      legend: {
          data:['Sales']
      },
      xAxis: {
          data: ["shirt","cardign","chiffon shirt","pants","heels","socks"]
      },
      yAxis: {},
      series: [{
          name: 'Sales',
          type: 'bar',
          data: [5, 20, 36, 10, 10, 20]
      }]
  };

  // use configuration item and data specified to show chart
  myChart.setOption(option);
  }

}
