import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';

import { AngularFireModule } from 'angularfire2';
import { AngularFirestoreModule } from 'angularfire2/firestore';
import { UsersComponent } from './users.component';
import { ReactiveFormsModule } from '@angular/forms';
import { UserFormComponent } from './user-form.component';

import { routing } from './app.routing';

var config = {
  apiKey: "AIzaSyA7DmHAYk-bK9SdTGmM_aok8TKYxbU9EN4",
  authDomain: "crud-project-b5e4a.firebaseapp.com",
  databaseURL: "https://crud-project-b5e4a.firebaseio.com",
  projectId: "crud-project-b5e4a",
  storageBucket: "crud-project-b5e4a.appspot.com",
  messagingSenderId: "502131648858"
};

@NgModule({
  declarations: [
    AppComponent,
    UsersComponent,
    UserFormComponent
  ],
  imports: [
    BrowserModule,
    AngularFireModule.initializeApp(config),
    AngularFirestoreModule,
    ReactiveFormsModule,
    routing//always last after any other module routes
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule {

}
