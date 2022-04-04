import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class RequestHandlerService {
  constructor(private http: HttpClient) {}

  sendRequest() {
    return this.http.get('http://localhost:52850/api/FrontEnd');
  }
}
