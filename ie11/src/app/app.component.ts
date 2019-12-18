import { Component, NgZone, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'ie11';
  constructor(
    private ngZone: NgZone,
  ) {

  }
  ngOnInit(): void {
    //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
    //Add 'implements OnInit' to the class.
    window['angularComponentReference'] = { component: this, zone: this.ngZone, loadAngularFunction: (arg1, arg2) => this.angularFunctionCalled(arg1, arg2), };
  }
  public angularFunctionCalled(arg1, arg2) {
    let alertMessage = "angular :arg1 is " + arg1 + " and arg2 is " + arg2 + "!";
    alert(alertMessage);
    //console.log("arg1 is " + arg1 + " and arg2 is " + arg2 + "!");
    //"arg1 is " + arg1 + " and arg2 is " + arg2 + "!"
  }
}

