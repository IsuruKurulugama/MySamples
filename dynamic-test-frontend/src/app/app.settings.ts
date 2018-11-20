import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
import { Observable } from "rxjs/Observable";
import "rxjs/Rx";

export class AppSettings {
   
    public static ExtractRequests(res: Response) {
        //extract data from response
        if (res['_body']) {
            const data = JSON.parse(res['_body']);
            if (data != null && data.value) { return data.value; }
            else { return data; }
        }
    }

    public static HandleError(error: Response | any) {
        if (error.message == 'No JWT present or has expired') {
            location.reload();
        }
        //handle error from response
        let errMsg: string;
        if (error instanceof Response) {
            const body = error.json() || '';
            const err = body.error || JSON.stringify(body);
            errMsg = `${error.status} - ${error.statusText || ''} ${err}`;
        } else {
            errMsg = error.message ? error.message : error.toString();
        }
        console.error(errMsg);
        return Observable.throw(errMsg);
    }

}

