import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './core/components/navbar/navbar.component';
import { GenresListComponent } from './features/Genres/genres-list/genres-list.component';
import { AddGenreComponent } from './features/Genres/add-genre/add-genre.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {HTTP_INTERCEPTORS, HttpClientModule} from '@angular/common/http';
import { EditGenreComponent } from './features/Genres/edit-genre/edit-genre.component';
import { BookListComponent } from './features/Book/book-list/book-list.component';
import { AddBookComponent } from './features/Book/add-book/add-book.component';
import { EditBookComponent } from './features/Book/edit-book/edit-book.component';
import { ImageSelectorComponent } from './shared/components/image-selector/image-selector.component';
import { HomeComponent } from './features/public/home/home.component';
import { BookDetailsComponent } from './features/public/book-details/book-details.component';
import { LoginComponent } from './features/auth/login/login.component';
import { AuthInterceptor } from './core/interceptors/auth.interceptor';
import { StarRatingModule } from 'angular-star-rating';
import { BorrowedBookListComponent } from './features/Book/borrowed-book-list/borrowed-book-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    GenresListComponent,
    AddGenreComponent,
    EditGenreComponent,
    BookListComponent,
    AddBookComponent,
    EditBookComponent,
    ImageSelectorComponent,
    HomeComponent,
    BookDetailsComponent,
    LoginComponent,
    BorrowedBookListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    StarRatingModule.forRoot(),
    ReactiveFormsModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true 
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
