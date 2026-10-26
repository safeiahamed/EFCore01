using Microsoft.EntityFrameworkCore;

namespace EFAssignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDbContext db = new AppDbContext())
            {

                var book = new Book
                {
                    Title = "EFCore", 
                    ISBN = "123456",
                    Price = 300,
                    NumberOfPages = 200, 
                    PublicationYear = 2016, 
                    InStock = true
                };
                db.Books.Add(book);
                db.SaveChanges();
                Console.WriteLine("Book added successfully!");

                var books = db.Books.ToList(); 
                foreach (var b in books) {
                    Console.WriteLine($"Title: {b.Title}");
                    Console.WriteLine($"ISBN: {b.ISBN}");
                    Console.WriteLine($"Price: {b.Price}");
                }

            }
        }
    }
}
