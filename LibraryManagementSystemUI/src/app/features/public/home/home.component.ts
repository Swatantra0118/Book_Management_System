import { Component, OnInit } from '@angular/core';
import { BookService } from '../../Book/services/book.service';
import { Observable } from 'rxjs';
import { Book } from '../../Book/models/book.model';
import { CookieService } from 'ngx-cookie-service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent implements OnInit {

  isEmptyLocalStorageHome: boolean = true;
  books$?: Observable<Book[]>;
  books?: Book[];
  userId: string = '';
  queryString: string = '';

  constructor(private bookService: BookService,
    private cookieService: CookieService) {}
  ngOnInit(): void {

    this.books$ = this.bookService.getAllBooks();

    const itemName = 'name';
    const itemValue = localStorage.getItem(itemName);
    this.isEmptyLocalStorageHome = itemValue === null || itemValue === '';
    // console.log(this.isEmptyLocalStorage);
    if(!this.isEmptyLocalStorageHome){
      let token = this.cookieService.get('Authorization');
      token = token.slice(6,token.length);
      var payload = JSON.parse(window.atob(token.split('.')[1]));
      this.userId = payload.UserID;
      this.bookService.getAllBooks()
    .subscribe({
      next: (response) => {
        this.books = response;
        this.books = this.books.filter(book => book.lentByUserId != this.userId);
        this.books = this.books.filter(book => book.currentlyBorrowedByUserId == null);
      }
    });
    }
  }
  
  search(){
    if(this.queryString!=''){
      this.books$ = this.bookService.getAllBooks(this.queryString);
      this.bookService.getAllBooks(this.queryString).subscribe({
        next: (response)=>{
          this.books= response;
          this.books = this.books.filter(book => book.lentByUserId != this.userId)
          // location.reload();
          // console.log(this.books);
        },
        error:(err)=>{
          console.log(err);
        }
      })
    }
  }

  Cancel(){
    location.reload();
  }

}
