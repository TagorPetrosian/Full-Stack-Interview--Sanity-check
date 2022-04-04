import { Component } from '@angular/core';
import { RequestHandlerService } from '../request-handler.service';
import { MatButton } from '@angular/material/button';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  constructor(private requestService: RequestHandlerService) {}

  message = '';
  isSubmit = false;
  messageStyle = '';
  isLoading = false;

  sendRequest() {
    this.message = '';
    this.isLoading = true;
    this.requestService.sendRequest().subscribe(
      (res) => {
        this.isLoading = false;
        this.isSubmit = true;
        this.message = 'Success';
        this.messageStyle = 'success';
      },
      (error) => {
        this.isLoading = false;
        this.isSubmit = true;
        this.message = 'Failed';
        this.messageStyle = 'fail';
      }
    );
  }
}
