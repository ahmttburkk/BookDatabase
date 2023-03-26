using BookDatabase.Models;

//              (insert book) Insert işlemi için kullanılır:
//Book book = new Book()
//{
//    //BookId = 1,
//    BookName = "The Lord Of The Rings",
//    NumberOfPage = 563
//};

//DataContext dbb = new DataContext();
//dbb.Books.Add(book);
//dbb.SaveChanges();

//Publisher publisher = new Publisher()
//{
//    //PublisherId = 10,
//    PublisherName = "Detoks Yayınları"
//};

//DataContext dbp = new DataContext();
//dbp.Publishers.Add(publisher);
//dbp.SaveChanges();
//--------------------------------------------------------------------------------------------------------
DataContext bookDb = new DataContext();

//              (Example of usage of the 'Where')Sayfa sayısı 300'den fazla olan kitapları getirir:
//var books = bookDb.Books.Where(b => b.NumberOfPage > 300);
//foreach(Book book in books)
//{
//    Console.WriteLine($"ID: {book.BookId} Name: {book.BookName} Number Of Page: {book.NumberOfPage}"  );
//}
//--------------------------------------------------------------------------------------------------------


//             (get all books ) Tüm kitapları listeler:
//List<Book> books = bookDb.Books.ToList();
//foreach (Book book in books)
//{
//    Console.WriteLine($"ID: {book.BookId} Name: {book.BookName} Number Of Page: {book.NumberOfPage}");
//}
//--------------------------------------------------------------------------------------------------------


//             (get book with Id) ID'ye göre data(kitap) çağırma:
//var books = bookDb.Books.Where(x => x.BookId == 2).FirstOrDefault();
//if (books != null)
//{
//    Console.WriteLine($"ID: {books.BookId} Name: {books.BookName} Number Of Page: {books.NumberOfPage}");
//}
//else
//{
//    Console.WriteLine("The book cannot find!");
//}
//--------------------------------------------------------------------------------------------------------


//             (update book) Var olan bir kitabın ismini değiştirerek güncelleme:
//var books = bookDb.Books.Where(n => n.BookName == "Puslu Kıtalar Atlası").FirstOrDefault();
//books.BookName = "Sisli Kıtalar Atlası";
//bookDb.SaveChanges();



