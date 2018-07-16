import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/bookModel';
import {NgForm} from '@angular/forms';
import { bookService } from '../books/book.service';
import{Router}from '@angular/router';
import { componentRefresh } from '@angular/core/src/render3/instructions';
@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {
  model:BookModel=new BookModel(1,"",1,1,"",1,1);

  constructor(private bookService: bookService) { }
ngOnInit() {
  }

onSubmit(){
	this.bookService.addBook(this.model).subscribe(
		(result:any)=>{
      alert("książka została dodana");
    }
    )
}
}
