import { Component, OnInit,Input } from '@angular/core';
import{BookModel} from "../models/bookModel";
import{bookService} from "../books/book.service"
import { NgModel } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import {Router} from '@angular/router';
@Component({
  selector: 'app-books-list',
  templateUrl: './books-list.component.html',
  styleUrls: ['./books-list.component.css']
})
export class BooksListComponent implements OnInit {

@Input()model:BookModel;
  booksList:BookModel[];
  router:Router;
  constructor(router:Router,public bookService:bookService) {//chwilowa zmiana na public
 this.router=router;
   }

  ngOnInit() {
    this.bookService.getBook().subscribe(
      (data:any)=>{
        this.booksList=data;
      }
    )
  }
deleteBook(bookid){
    this.bookService.deleteBook(bookid).subscribe(
      ()=>{
      }
    )
    this.bookService.getBook().subscribe(
      (data:any)=>{
        this.booksList=data;
      }
    )
  };
  
  editForm(id){
    console.log(id);
  this.router.navigate(['books/edit/'+id])
  };

  
  searchevery(){
console.log("searchTest") ;
    
    // this.bookService.searchBooks(NgModel).subscribe(
    //   (data:any)=>{
    //     this.booksList=data;
    //   }
    // )
  };
}

