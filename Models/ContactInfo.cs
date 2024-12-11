using System.ComponentModel.DataAnnotations;

namespace ContactInfo_WebAPI.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Street { get; set; }

        [Required]
        public int? City { get; set; }

        public string? Zipcode { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public int? Country { get; set; }

        [Required]
        [Phone]
        public string? Telephone { get; set; }

        public string? Message { get; set; }

        //public Contact(Contact contact)
        //{
        //    FirstName = contact.FirstName;
        //    LastName = contact.LastName;
        //    Street = contact.Street;
        //    City = contact.City;
        //    Zipcode = contact.Zipcode;
        //    Email = contact.Email;
        //    Country = contact.Country;
        //    Telephone = contact.Telephone;
        //    Message = contact.Message;
        //}
    }
}