import { HttpHeaders, HttpParams } from '@angular/common/http';

export class HttpOptions {
    headers?: HttpHeaders;
    observe?: 'body';
    params?: HttpParams;
    reportProgress?: boolean;
    responseType?: 'json';
    withCredentials?: boolean;
}
