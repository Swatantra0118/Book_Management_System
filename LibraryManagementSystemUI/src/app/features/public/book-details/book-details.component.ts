import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from '../../Book/services/book.service';
import { Observable } from 'rxjs';
import { Book } from '../../Book/models/book.model';
import { AuthService } from '../../auth/services/auth.service';
import { CookieService } from 'ngx-cookie-service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-book-details',
  templateUrl: './book-details.component.html',
  styleUrls: ['./book-details.component.css'],
})
export class BookDetailsComponent implements OnInit {
  url: string | null = null;
  book$?: Observable<Book>;
  condition: boolean = false;
  isEmptyLocalStorage: boolean = true;
  userId: string = '';
  bookBorrowerName?: string;
  bookBorrowerUserId?: string;

  constructor(private route: ActivatedRoute, private bookService: BookService,
     private authService: AuthService,
     private cookieService: CookieService,
     private router: Router) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        this.url = params.get('url');
      },
    });

    //Fetch book details by url
    if(this.url){
      this.book$ = this.bookService.getBookByUrlHandle(this.url);  

    }


    const itemName = 'name';
    const itemValue = localStorage.getItem(itemName);
    this.isEmptyLocalStorage = itemValue === null || itemValue === '';
    // console.log(this.isEmptyLocalStorage);
    if(this.isEmptyLocalStorage){
      Swal.fire('Login as a Registered User to Borrow This Book');
    }

    if(!this.isEmptyLocalStorage){
      let token = this.cookieService.get('Authorization');
    token = token.slice(6,token.length);
    var payload = JSON.parse(window.atob(token.split('.')[1]));
    this.userId = payload.UserID;
    // console.log(this.userId)
    }
    
  }

  onClick(id: string) {
    this.bookService.borrowBook(id)
    .subscribe({
      next: (response) => {
        localStorage.setItem('tokensAvailable', response.toString());
        Swal.fire('Book Borrowed Successfully').then(()=>{location.reload()});
      }
    }
    );
    this.router.navigateByUrl('admin/borrowedBooks')
  }

  
}
