import { Injectable } from '@angular/core';
import { Http, RequestOptions, Response } from '@angular/http';
import { HttpHeaders } from '@angular/common/http';
import "rxjs/Rx";
import { Observable } from "rxjs/Observable";
import { environment } from '../../environments/environment';
import { AppSettings } from '../app.settings';

@Injectable()
export class HomeService {

  constructor(private http: Http) { }

  public saveUser(item) {
    return this.http.post(environment.API_ENDPOINT + "users", item).map(AppSettings.ExtractRequests).catch(AppSettings.HandleError);
  }

  public getUsers() {
    return this.http.get(environment.API_ENDPOINT + "users").map(AppSettings.ExtractRequests).catch(AppSettings.HandleError);
  }

  public updateUser(item) {
    return this.http.put(environment.API_ENDPOINT + "users/" + item.id, item).map(AppSettings.ExtractRequests).catch(AppSettings.HandleError);
  }

  public deleteUser(id) {
    return this.http.delete(environment.API_ENDPOINT + "users/" + id).map(AppSettings.ExtractRequests).catch(AppSettings.HandleError);
  }

}
