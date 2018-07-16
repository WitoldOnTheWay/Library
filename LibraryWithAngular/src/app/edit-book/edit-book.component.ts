import { Component, OnInit } from '@angular/core';
import { BookModel } from '../models/bookModel';

import { bookService } from '../books/book.service';

import{Router} from '@angular/router';
import { ActivatedRoute } from '@angular/router';
@Component({
  selector: 'app-edit-book',
  templateUrl: './edit-book.component.html',
  styleUrls: ['./edit-book.component.css']
})

export class EditBookComponent implements OnInit {
  book:BookModel=new BookModel();
 booksList:BookModel;
  //Id:number;

 
 // constructor(public bookService:bookService)
  
constructor(private bookService:bookService,private router:Router,private route:ActivatedRoute){}
  ngOnInit() {
    console.log(this.route);
   //const holdId=34;
   const holdId=+this.route.snapshot.params['id'];
   console.log(holdId);
    return this.bookService.editForm(holdId).subscribe(
      (data:any)=>{
        this.book=data;
      }
    )
  }
save(book:BookModel){
  const holdId=+this.route.snapshot.params['id'];
  this.bookService.saveEdit(this.book,holdId).subscribe(
		(result:any)=>{
    }
  )
  this.router.navigate(['books/list']);
}
}
