using Microsoft.EntityFrameworkCore;

namespace Fisher.Bookstore.Models
{
    public class BookstoreContent : DbContext
    {
        public BookstoreContent(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set;}
    }
}