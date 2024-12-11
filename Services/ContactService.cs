using ContactInfo_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactInfo_WebAPI.Services
{
    public interface IContactService
    {
        void SaveContact(Contact contactInfo);
    }

    public class ContactService : IContactService
    {
        public void SaveContact(Contact contactInfo)
        {
            // Logic to save contact info to the database (e.g., using Entity Framework)
        }
    }


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 1,
                FirstName = "שירן",
                LastName = "גרוסו",
                Email = "shirangr@test.com",
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                ContactId = 2,
                FirstName = "טסט",
                LastName = "טסט",
                Email = "test@test.com",
            });

        }
    }


}

