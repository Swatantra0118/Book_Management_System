export interface UpdateBook{
    name: string;
    description: string;
    featuredImageUrl: string;
    urlHandle: string;
    author: string;
    isAvailable: boolean;
    genres: string[];
    lentByUserId: string;
    currentlyBorrowedByUserId: string;
    rating: number;
}