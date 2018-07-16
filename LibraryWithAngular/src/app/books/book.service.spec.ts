import { TestBed, inject } from '@angular/core/testing';

import { bookService } from './book.service';

describe('BookService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [bookService]
    });
  });

  it('should be created', inject([bookService], (service: bookService) => {
    expect(service).toBeTruthy();
  }));
});
