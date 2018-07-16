import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BooksListComponent } from '../books-list/books-list.component';

import { AddBookComponent } from '../add-book/add-book.component';
import { EditBookComponent } from '../edit-book/edit-book.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  imports: [FormsModule,
    CommonModule
  ],
  declarations: [BooksListComponent, AddBookComponent, EditBookComponent],
  exports:[BooksListComponent,EditBookComponent]
})
export class BooksModule { }
