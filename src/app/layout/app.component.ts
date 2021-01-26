import { AfterViewInit } from "@angular/core";
import { Subscription } from "rxjs";
import {startWith, delay} from 'rxjs/operators'
import { Helpers } from "../helpers/helpers";

export class AppComponent implements AfterViewInit {
  subscription: Subscription;
  authentication: boolean;
  constructor(private helpers: Helpers){

  }
  ngAfterViewInit() {
    this.subscription = this.helpers.isAuthenticationChanged().pipe(
      startWith( this.helpers.isAuthenticated()),
      delay(0)).subscribe((value) => this.authentication = value)
    
  }
  title= 'Angular x Seed';
  ngOnDistroy() {
    this.subscription.unsubscribe()
  }
}