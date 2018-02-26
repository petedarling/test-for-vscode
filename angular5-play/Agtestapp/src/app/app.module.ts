import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';

import { ProductsComponent } from './products.component';
import { ProductComponent } from './product.component';
import { RatingComponent } from './rating.component';
import { MyTestComponent } from './mytest.component';
import { JumboTronComponent } from './jumbotron.component';
//import { UserFormComponent } from './user-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { LoginComponent } from './login.component';
import { TruncatePipe } from './truncate.pipe';
import { LoginService } from './login.service';

@NgModule({
  declarations: [
    AppComponent,
    ProductsComponent,
    RatingComponent,
    ProductComponent,
    TruncatePipe,
    JumboTronComponent,
    MyTestComponent,
    //UserFormComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    HttpModule,
  ],
  providers: [LoginService],
  bootstrap: [AppComponent]
})
export class AppModule { }