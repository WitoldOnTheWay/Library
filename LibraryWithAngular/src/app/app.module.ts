import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpModule} from '@angular/http';
import { AppComponent } from './app.component';
import { BooksListComponent } from './books-list/books-list.component';
import { NavbarComponent } from './navbar/navbar.component';
import { RouterModule, Routes} from '@angular/router';
import { AddBookComponent } from './add-book/add-book.component';
import { EditBookComponent } from './edit-book/edit-book.component';
import { BooksModule } from './books/books.module';
import { FormsModule  } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { bookService } from './books/book.service';
const appRoutes:Routes=[
  {path:'books',children:[
    {path:'list',component:BooksListComponent},
  {path:'add',component:AddBookComponent},
{path:'edit/:id',component:EditBookComponent}//po : wartosc zmienna
  ]}
];

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent
  ],
  imports: [
    HttpClientModule,
    HttpModule,
    FormsModule,
    BooksModule,
    BrowserModule,
    RouterModule.forRoot(appRoutes),
  ],
  providers: [bookService],
  bootstrap: [AppComponent]
})
export class AppModule { }
