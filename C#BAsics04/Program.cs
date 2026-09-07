using System.Text;

namespace C_BAsics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment03
            #region Question14
            ////Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
            ////"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //string message = title switch
            //{
            //    "Clean Code" => "Great choice!",
            //    "Refactoring" => "Nice pick!",
            //    _ => "Never heard of it"
            //};
            //Console.WriteLine(message);
            #endregion

            #region Question15
            ////Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel
            ////(same rule as question 8: long if pages > 300).
            //int pages = 464;
            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(sizeLabel);
            #endregion

            #region Question16
            ////Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            ////use a for loop to print each book with its position number, like 1. Clean Code.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for(int i = 0; i< books.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {books[i]}");
            //}
            #endregion

            #region Question17
            ////Using the same books array, use a while loop to print every book title.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //int index = 0;
            //while (index < books.Length)
            //{
            //    Console.WriteLine($"{index + 1}. {books[index]}");
            //    index++;
            //}
            #endregion

            #region Question18
            ////Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Checking book..");
            //    count++;
            //}
            //while (count < 3);
            #endregion

            #region Question19
            ////Using the same books array, use a foreach loop to print every book title. 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question20
            ////Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if (book == "Refactoring")
            //        break;

            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question21
            ////Using the same books array, print every title except "The Pragmatic Programmer" (skip it with continue, don't stop the loop).
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Question22
            ////Write a method PrintFirstBook() that prints the first book in the books array.
            ////If the array is empty, use return to exit the method early instead of printing anything.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //PrintFirstBook(books);
            #endregion

            #endregion

            #region String Questions
            #region Question01
            ////Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
            ////Print both title and upperTitle to show that title did not change.

            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"title: {title} \nupperTitle: {upperTitle}");
            #endregion

            #region Question02
            ////Declare two separate string variables, both set to the literal "Clean Code".
            ////Use ReferenceEquals() to check if they point to the same object in memory.

            //string title1 = "Clean Code";
            //string title2 = "Clean Code";

            //Console.WriteLine($"ReferenceEquals(title1, title2): {object.ReferenceEquals(title1, title2)}");

            #endregion

            #region Question03
            ////Create a StringBuilder, Append() the text "Book List",
            ////then Append() " - Updated" onto the same object. Print the final result.

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Question04
            ////Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());

            #endregion
            #endregion
        }

        public static void PrintFirstBook(string[] books) 
        {
            if (books.Length == 0)
                return;

            Console.WriteLine($"the first book is: {books[0]}");
        }

    }
}
