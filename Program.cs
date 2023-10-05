namespace BookÖvning
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Book myBook = new Book("Title", "Author", "Summary of the book");
            myBook.PrintBookData();


            Console.Write("Input Title: ");
            myBook._title = Console.ReadLine();
            Console.Write("Input Author: ");
            myBook._author = Console.ReadLine();
            Console.Write("Input Summary: ");
            myBook._summary = Console.ReadLine();
            myBook.PrintBookUserData();


        }
    }

    public class Book
    {
        public string _title;
        public string _author;
        public string _summary;

        public Book(string Title, string Author, string Summary) //konstruktor 
        {
            _title = Title;
            _author = Author;
            _summary = Summary;
        }


        public void PrintBookData()
        {
            Console.WriteLine("Book data: {0} {1} {2}",_title, _author, _summary);
        }

        public void PrintBookUserData()
        {
            Console.WriteLine("Book User data: {0} {1} {2}", _title, _author, _summary);
        }
    }


}