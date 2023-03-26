// See https://aka.ms/new-console-template for more information
using UbeydYılmaz_HW1.Models;


//Book book = new Book();
//{
//    book.BookName = "Şeytan Aletleri";
//    book.Author = "Altay Öktem";

//};

BookDataContext db = new BookDataContext();
//db.Books.Add(book);
//db.SaveChanges();

//List<Book> books = db.Books.ToList();

//foreach (Book book in books)
//{
//    Console.WriteLine($"BookName : {book.BookName} Author : {book.Author}");
//}

//var book = db.Books.Where(a => a.Id == 3).FirstOrDefault();
//if (book != null)
//{
//    Console.WriteLine($"BookName : {book.BookName} Author : {book.Author}");
//}
//else
//{
//    Console.WriteLine("Not found!");
//}
//var book = db.Books.Where(n => n.BookName == "Beyaz Kurt").FirstOrDefault();
//book.Author = "İrem Yaldır";
//db.SaveChanges();