import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Report } from '../classes/report';
import { Observable } from 'rxjs';
import { map, concatAll } from 'rxjs/operators';
import { getLocaleDateTimeFormat } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class ReportService {
  getTopServers(begintijd?, eindtijd?): Observable<Report> {
    let apiUrl = "/reports/topserver";
    if (begintijd != null || eindtijd != null) {
      apiUrl = apiUrl + "?";
      if (begintijd != null) {
        apiUrl = apiUrl + "begintijd=" + begintijd;
      }
      if (begintijd != null && eindtijd != null) {
        apiUrl = apiUrl + "&";
      }
      if (eindtijd != null) {
        apiUrl = apiUrl + "eindtijd=" + eindtijd;
      }
    }

    return this.api.get(apiUrl).pipe(
      concatAll(),
      map(obj => {
        const report: Report = {
          value: obj['aantal'],
          name: obj['server']
        };
        return report;

      })
    );
  }

  getTopDrinkers(begintijd?, eindtijd?): Observable<Report> {
    let apiUrl = '/reports/topdrinker';
    if (begintijd != null || eindtijd != null) {
      apiUrl = apiUrl + '?';
      if (begintijd != null) {
        apiUrl = apiUrl + 'begintijd=' + begintijd;
      }
      if (begintijd != null && eindtijd != null) {
        apiUrl = apiUrl + '&';
      }
      if (eindtijd != null) {
        apiUrl = apiUrl + 'eindtijd=' + eindtijd;
      }
    }

    return this.api.get(apiUrl).pipe(
      concatAll(),
      map(obj => {
        const report: Report = {
          value: obj['aantal'],
          name: obj['drinkers']
        };
        return report;

      })
    );
  }

  constructor(private api: ApiService) { }
}
