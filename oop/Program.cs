namespace oop
{


    class Book
    {
        public string Title;
        public string Author;
        public string Isbn;
        public bool IsAvailable;

        public Book(string title, string author, string isbn, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Isbn = isbn;
            IsAvailable = isAvailable;
        }


    }
    class library
    {
        List<Book> Books = new List<Book>();


        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book Searchbook(string title = default, string author = default)
        {


            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == title || Books[i].Author == author)

                {
                    Console.WriteLine($"Book Found: {Books[i].Title} by {Books[i].Author}");
                    return Books[i];

                }

            }
            Console.WriteLine("Book not found.");
            return null;
        }


        public Book BorrowBook(string title = default, string author = default)
        {
            bool exist = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == title || Books[i].Author == author)
                {
                    exist = true;
                    if (Books[i].IsAvailable)
                    {
                        Console.WriteLine($"Borrowed Book: {Books[i].Title} by {Books[i].Author}");
                        Books[i].IsAvailable = false;
                        return Books[i];
                    }
                   
                }
            }
            if (exist)
            {
                Console.WriteLine("Book is not available.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
           
            return null;
        }

        public Book ReturnBook(string title = default, string author = default)
        {
            bool exist = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == title || Books[i].Author == author)
                {
                    exist = true;
                    if (!Books[i].IsAvailable)
                    {
                        Console.WriteLine($"Returned Book: {Books[i].Title} by {Books[i].Author}");
                        Books[i].IsAvailable = true;
                        return Books[i];
                    }
                 
                }
            }
            if (exist)
            {
                Console.WriteLine("Book is already available.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
           
            return null;
        }
    }









        internal class Program
        {
            static void Main(string[] args)
            {
                library library = new library();
                library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565"));
                library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", "9780061120084"));
                library.AddBook(new Book("1984", "George Orwell", "9780451524935"));


            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("1984");

            library.BorrowBook("The Great Gatsby");
            library.BorrowBook("Harry Potter");

            library.ReturnBook("The Great Gatsby");
            library.ReturnBook("The Great Gatsby");
            library.ReturnBook("Harry Potter");
        }
        }
    }

