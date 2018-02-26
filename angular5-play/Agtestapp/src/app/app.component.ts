import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  template: `
      <bs-jumbotron>
        <div class="heading"> Hello New User! </div>
        <div class="body"> This is a test message especially for you. </div>
        <div class="button"> Learn more </div>
      </bs-jumbotron>
      <mytest></mytest>
      <login></login>
      <products></products>
    `
})
export class AppComponent {
    title = "hello";

    onClick($event){
      console.log("Clicked",$event)
    }
  }