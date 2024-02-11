import { Component, OnDestroy, OnInit } from '@angular/core';
import { AddBook } from '../models/add-book.model';
import { BookService } from '../services/book.service';
import { Router } from '@angular/router';
import { GenreService } from '../../Genres/services/genre.service';
import { Observable, Subscription } from 'rxjs';
import { Genre } from '../../Genres/models/genre.model';
import { ImageService } from 'src/app/shared/components/image-selector/image.service';
import { FormBuilder } from '@angular/forms';
import { __values } from 'tslib';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css'],
})
export class AddBookComponent implements OnInit, OnDestroy {
  formModel: any;
  isImageSelectorVisible: boolean = false;
  genres$?: Observable<Genre[]>;

  imageSelectorSubscription?: Subscription;

  constructor(
    private bookService: BookService,
    private router: Router,
    private genreService: GenreService,
    private imageService: ImageService,
    private fb: FormBuilder
  ) {
    // this.formModel = {
    //   name: '',
    //   description: '',
    //   urlHandle: '',
    //   featuredImageUrl: '',
    //   author: '',
    //   isAvailable: true,
    //   genres: [],
    //   rating: 0,
    // };
    this.formModel= this.fb.group({
      name:[''],
      author:[''],
      description:[''],
      urlHandle: [''],
      featuredImageUrl: [''],
      isAvailable: [true],
      genres: [[]],
      rating:[0],
    });
  }

  //Getters
  get name(){
    return this.formModel.controls.name;
  }
  get author(){
    return this.formModel.controls.author;
  }
  get genres(){
    return this.formModel.controls.genres;
  }
  get featuredImageUrl(){
    return this.formModel.controls.featuredImageUrl;
  }
  get isAvailable(){
    return this.formModel.controls.isAvailable;
  }
  get description(){
    return this.formModel.controls.description;
  }
  get rating(){
    return this.formModel.controls.rating
  }

  set featuredImageUrl(url: string){
    this.formModel.controls.featuredImageUrl.patchValue(url);
  }

  ngOnInit(): void {

    this.genres$ = this.genreService.getAllGenres();

    this.imageSelectorSubscription = this.imageService
      .onSelectImage()
      .subscribe({
        next: (response) => {
          // console.log(this.featuredImageUrl)
          this.featuredImageUrl = response.url;
          // console.log(this.featuredImageUrl);
          this.closeImageSelector();
        },
      });
  }

  onFormSubmit(): void {
    console.log(this.formModel.value);
    this.bookService.createBook(this.formModel.value).subscribe({
      next: (response) => {
        this.router.navigateByUrl('/admin/books');
      },
    });
  }

  openImageSelector(): void {
    this.isImageSelectorVisible = true;
  }

  closeImageSelector(): void {
    this.isImageSelectorVisible = false;
  }
  ngOnDestroy(): void {
    this.imageSelectorSubscription?.unsubscribe();
  }
}
