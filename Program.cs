namespace Lab08___Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string libraryName = "Phil's Lending Library";
            foreach (char character in libraryName)
            {
                Console.Write(character);
                Thread.Sleep(100); // adjust delay here
            }
            Console.WriteLine();
            Console.WriteLine("Hello, welcome to the Library!");
            Library myLibrary = new Library();
            Backpack backpack = new Backpack();

            while (true)
            {
                Console.WriteLine("===========================");
                Console.WriteLine("Press the corresponding key to continue.");
                Console.WriteLine("Add a Book [1]");
                Console.WriteLine("Borrow a Book [2]");
                Console.WriteLine("Return a Book [3]");
                Console.WriteLine("Search for a book [4]");
                Console.WriteLine("View all Books [5]");
                Console.WriteLine();
                string userInput = Console.ReadLine();


                if (userInput == "5")
                {
                    myLibrary.ViewAllBooks();
                }

                else if (userInput == "1")

                {
                    Console.WriteLine("Enter a Book Title");
                    string bookTitle = Console.ReadLine();
                    Console.WriteLine("Enter the Author of the Book you Want to Add");
                    string bookAuthor = Console.ReadLine();
                    Book addAbook = new Book(bookTitle, bookAuthor);
                    myLibrary.Add(bookTitle, bookAuthor);
                }

                else if (userInput == "2")
                {
                    Console.WriteLine("Enter the Title of the Book you Would Like to Borrow");
                    string borrowAbook = Console.ReadLine();
                    Book borrowed = myLibrary.Borrow(borrowAbook);
                    backpack.Pack(borrowed);
                }
                else if (userInput == "3")
                {
                    backpack.ViewAll();
                    Console.WriteLine("Please select a book you want to return");
                    string userChoice = Console.ReadLine();
                }


            }

        }
    }
}