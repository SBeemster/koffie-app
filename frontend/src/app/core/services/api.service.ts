import { Injectable } from '@angular/core';
import { environment } from "src/environments/environment";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable, throwError, pipe } from "rxjs";
import { catchError, finalize } from 'rxjs/operators';
import { HttpOptions } from "../classes/http-options";

@Injectable({
    providedIn: 'root'
})
export class ApiService {

    apiUrl = environment.apiUrl;
    awaitingResponse = false;

    constructor(private http: HttpClient) { }

    get(endpoint: string, options?: HttpOptions): Observable<object> {
        this.awaitingResponse = true;
        let httpOptions = this.addBearer(options);
        return this.http.get(this.apiUrl + endpoint, httpOptions)
            .pipe(this.catchFinally());
    }

    delete(endpoint: string, options?: HttpOptions): Observable<object> {
        this.awaitingResponse = true;
        let httpOptions = this.addBearer(options);
        return this.http.delete(this.apiUrl + endpoint, httpOptions)
            .pipe(this.catchFinally());
    }

    post(endpoint: string, postBody: object, options?: HttpOptions): Observable<object> {
        this.awaitingResponse = true;
        let httpOptions = this.addBearer(options);
        httpOptions.headers.append('Content-Type', 'application/json');
        return this.http.post(this.apiUrl + endpoint, postBody ,httpOptions)
            .pipe(this.catchFinally());
    }

    put(endpoint: string, putBody: object, options?: HttpOptions): Observable<object> {
        this.awaitingResponse = true;
        let httpOptions = this.addBearer(options);
        httpOptions.headers.append('Content-Type', 'application/json');
        return this.http.put(this.apiUrl + endpoint, putBody ,httpOptions)
            .pipe(this.catchFinally());
    }

    private catchFinally() {
        return pipe(
            catchError((error: Response) => {
                if (error.status === 401 || error.status === 403) {
                    localStorage.removeItem("id_token");
                }
                return throwError(error);
            }),
            finalize(() => {
                this.awaitingResponse = false;
            })
        );
    }

    private addBearer(options?: HttpOptions): HttpOptions {
        let idToken = `Bearer ${localStorage.getItem("id_token")}`;
        let httpOptions: HttpOptions = options ? options : new HttpOptions();

        if (httpOptions.headers) {
            if (!httpOptions.headers.get('Authorization')) {
                httpOptions.headers = httpOptions.headers.append('Authorization', idToken);
            }
        } else {
            httpOptions.headers = new HttpHeaders({
                'Authorization': idToken
            })
        }

        return httpOptions;
    }
}