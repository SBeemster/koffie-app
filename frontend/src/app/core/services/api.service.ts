import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError, pipe, BehaviorSubject } from 'rxjs';
import { catchError, finalize, map } from 'rxjs/operators';
import { HttpOptions } from '../classes/http-options';
import { Router } from '@angular/router';

@Injectable({
    providedIn: 'root'
})
export class ApiService {

    apiUrl = environment.apiUrl;

    private _awaitingResponse = new BehaviorSubject<boolean>(false);
    awaitingResponse = this._awaitingResponse.asObservable();

    constructor(private http: HttpClient, private router: Router) { }

    get(endpoint: string, options?: HttpOptions): Observable<object> {
        this._awaitingResponse.next(true);
        const httpOptions = this.addBearer(options);
        return this.http.get(this.apiUrl + endpoint, httpOptions)
            .pipe(this.catchFinally());
    }

    delete(endpoint: string, options?: HttpOptions): Observable<object> {
        this._awaitingResponse.next(true);
        const httpOptions = this.addBearer(options);
        return this.http.delete(this.apiUrl + endpoint, httpOptions)
            .pipe(this.catchFinally());
    }

    post(endpoint: string, postBody: object, options?: HttpOptions): Observable<object> {
        this._awaitingResponse.next(true);
        const httpOptions = this.addBearer(options);
        httpOptions.headers.append('Content-Type', 'application/json');
        return this.http.post(this.apiUrl + endpoint, postBody , httpOptions)
            .pipe(this.catchFinally());
    }

    put(endpoint: string, putBody: object, options?: HttpOptions): Observable<object> {
        this._awaitingResponse.next(true);
        const httpOptions = this.addBearer(options);
        httpOptions.headers.append('Content-Type', 'application/json');
        return this.http.put(this.apiUrl + endpoint, putBody , httpOptions)
            .pipe(this.catchFinally());
    }

    private catchFinally() {
        return pipe(
            catchError((error: Response) => {
                if (error.status === 401 || error.status === 403) {
                    localStorage.removeItem('id_token');
                    this.router.navigate(['login']);
                }
                return throwError(error);
            }),
            finalize(() => {
                this._awaitingResponse.next(false);
            })
        );
    }

    private addBearer(options?: HttpOptions): HttpOptions {
        const idToken = `Bearer ${localStorage.getItem('id_token')}`;
        const httpOptions: HttpOptions = options ? options : new HttpOptions();

        if (httpOptions.headers) {
            if (!httpOptions.headers.get('Authorization')) {
                httpOptions.headers = httpOptions.headers.append('Authorization', idToken);
            }
        } else {
            httpOptions.headers = new HttpHeaders({
                'Authorization': idToken
            });
        }

        return httpOptions;
    }
}
