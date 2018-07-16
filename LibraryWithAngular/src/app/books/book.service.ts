import { Injectable } from '@angular/core';
import { HttpClient,HttpHeaders } from '@angular/common/http';
import{BookModel}from '../models/bookModel';
//import{Http} from '@angular/http';
@Injectable({
  providedIn: 'root'
})
export class bookService {
 readonly url: string='http://localhost:62483/api/book/';
 
  readonly httpOptions={
    headers:new HttpHeaders({
      'Content-Type': 'application/json',
      'Auth': 'NoAuth'
    })
  }

  constructor(private http:HttpClient) { }

  getBook(){
    return this.http.get(this.url);
  }
  deleteBook(Id){
    return this.http.post(this.url+"delete/"+Id,null);
  }
  addBook(book:BookModel){
    return this.http.post<BookModel>(this.url+"add",book,this.httpOptions);
  }
  saveEdit(book:BookModel,Id){
    return this.http.put<BookModel>(this.url+Id,book);

  }
  // getBookById(Id){
  //   return this.http.get(this.url+Id);
    
  // }
  editForm(Id){
    return this.http.get(this.url+Id);
  }
  searchBooks(){
    return this.http.get(this.url+"search");
  }
}
