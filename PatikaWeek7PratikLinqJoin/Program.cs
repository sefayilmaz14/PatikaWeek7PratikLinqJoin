using PatikaWeek7PratikLinqJoin;
//Yazar ve kitap liste tanımlamaları
List<Autor> autors = new List<Autor>();
List<Book> books = new List<Book>();

//Yazar sınıfından üretilen nesneler
Autor autor1 = new Autor(1,"Orhan Pamuk");
Autor autor2 = new Autor(2,"Elif Şafak");
Autor autor3 = new Autor(3,"Ahmet Ümit");
//Üretilen nesnelerin listeye eklenmesi
autors.Add(autor1);
autors.Add(autor2);
autors.Add(autor3);
//Kitap sınıfından üretilen nesneler
Book book1 = new Book(1, "Kar", 1);
Book book2 = new Book(2, "İstanbul", 1);
Book book3 = new Book(3, "10 Minutes 38 Second İn This Strange World", 2);
Book book4 = new Book(4, "Beyoğlu Rapsodisi", 3);
//Üretilen nesnelerin listeye eklenmesi
books.Add(book1);
books.Add(book2);
books.Add(book3);
books.Add(book4);
//Sınıfların içerisinde bulunan Autorİd parametresi ile join işleminin gerçekleşmesi ve listelerden istenilen parametlerin seçilmesi
var query = from autor in autors
            join book in books
            on autor.AutorId equals book.AutorId
            select new
            {
                AutorName = autor.Name,
                BookName = book.Title,
            };
//Konsol ekranına gösterimi
foreach (var item in query)
{
    Console.WriteLine($"Yazar İsmi:{item.AutorName} Kitap İsmi:{item.BookName}");
}
