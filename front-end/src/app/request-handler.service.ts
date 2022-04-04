import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class RequestHandlerService {
  constructor(private http: HttpClient) {}

  sendRequest() {
    return this.http.get('https://localhost:44379/api/FrontEnd');
  }
}
