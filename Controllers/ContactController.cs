using ContactInfo_WebAPI.Models;
using ContactInfo_WebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactInfo_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        List<Contact> contacts = new List<Contact>();
        

        [HttpGet]
        /// <summary>
        ///  Returns all the contacts.
        /// </summary>
        /// <param name="searchKey"></param>
        /// <returns>Contacts List</returns>
        public ActionResult<List<Contact>> GetAllContacts()
        {
            try
            {
                return contacts;

                //return Ok(GetContacts());
                //return Ok(contacts);
            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return NotFound("Contact not found");
            }
        }

        [HttpGet("{contactId}")]
        /// <summary>
        ///  Returns the contact.
        /// </summary>
        /// <param name="searchKey"></param>
        /// <returns>Contact</returns>
        public ActionResult<Contact> GetContactById(int contactId)
        {
            try
            {
                return contacts.First(contact => contact.ContactId == contactId);

                //return Ok(GetContactDetails(ContactId));
                //return Ok(contacts.First(contact => contact.ContactId == ContactId));
            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return NotFound("Contact was not found");
            }
        }

        [HttpPost]
        /// <summary>
        ///  Creates a new contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns>200</returns>
        public ActionResult<string> CreateContact(Contact contact)
        {
            try
            {
                if (contact != null)
                {
                    contacts.Add(contact);
                    return StatusCode(201, "Contact ADDED");
                }

                return BadRequest("Contact was not added");


                //AddContact(Contact);
                //return StatusCode(201, "Contact ADDED");
            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return BadRequest(ex.Message);
            }
        }


        [HttpPatch]
        /// <summary>
        ///  Update the name
        /// </summary>
        /// <param name="contactId"></param>
        /// <param name="name"></param>
        /// <returns>200</returns>
        public ActionResult<string> UpdateContactName(int contactId, string name)
        {
            try
            {
                Contact contactToUpdate = contacts.First(contact => contact.ContactId == contactId);

                if (contactToUpdate != null)
                {
                    contactToUpdate.FirstName = name;
                    return Ok("Contact name was updated");
                }

                return BadRequest("Contact name was updated");


                //UpdateContactName(contactId, name);
                //return Ok("Contact name was updated");
            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        /// <summary>
        /// Delete the contact
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns>200</returns>
        public ActionResult<string> DeleteContact(int contactId)
        {
            try
            {
                Contact contactToDelete = contacts.First(contact => contact.ContactId == contactId);
                if (contactToDelete != null)
                {
                    contacts.Remove(contactToDelete);
                    return Ok("contact was deleted");
                }

                return BadRequest("contact was not deleted");

                //DeleteContact2(contactId);

            }
            catch (Exception ex)
            {
                //Log the error i.e., ex.Message
                return BadRequest(ex.Message);
            }
        }

        #region What I did
        //private readonly AppDbContext _context;

        //public ContactController(AppDbContext context)
        //{
        //    _context = context;
        //}


        //// GET: api/contacts
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        //{
        //    return await _context.Contacts.ToListAsync();
        //}

        //// GET: api/contacts/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Contact>> Getcontact(int id)
        //{
        //    var contact = await _context.Contacts.FindAsync(id);

        //    if (contact == null)
        //    {
        //        return NotFound();
        //    }

        //    return contact;
        //}

        //// POST: api/contacts
        //[HttpPost]
        //public async Task<ActionResult<Contact>> Postcontact(Contact contact)
        //{
        //    _context.Contacts.Add(contact);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(Getcontact), new { id = contact.ContactId }, contact);
        //}

        //// PUT: api/contacts/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateContact(int id, Contact contact)
        //{
        //    if (id != contact.ContactId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(contact).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //// DELETE: api/contacts/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteContact(int id)
        //{
        //    var contact = await _context.Contacts.FindAsync(id);
        //    if (contact == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Contacts.Remove(contact);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}
        #endregion



        #region Functions

        // POST api/contact
        //[HttpPost]
        //public IActionResult SubmitContactForm([FromBody] ContactInfo contact)
        //{
        //    if (contact == null)
        //    {
        //        return BadRequest("Contact information is required.");
        //    }

        //    // Here you can save the data to a database or perform other logic
        //    // For now, we'll just return a success message
        //    return Ok(new { message = "Contact form submitted successfully!" });
        //}

        //[HttpGet]
        //public List<Contact> GetContacts()
        //{
        //    return contacts;
        //}

        public Contact GetContactDetails(int contactId)
        {
            return contacts.First(contact => contact.ContactId == contactId);
        }

        [HttpPost]
        public void AddContact(Contact contact)
        {
            //if (contact == null)
            //{
            //    return NoContent("Contact information is required.");
            //}

            //contacts.Add(contact);
            //return Ok(new { message = "Contact form submitted successfully!" });

            if (contact != null)
            {
                contacts.Add(contact);
            }
        }

        [HttpPatch]
        public void UpdateName(int contactId, string name)
        {
            Contact contactToUpdate = contacts.First(contact => contact.ContactId == contactId);

            if (contactToUpdate != null)
            {
                contactToUpdate.FirstName = name;
            }
        }

        [HttpPut]
        public void UpdateContact(Contact contact)
        {
            //ContactInfo contactToUpdate = Contact.First(contact => contact.contactId == contact.contactId);
            //if (contactToUpdate != null)
            //{
            //    contactToUpdate = Contact;
            //}
        }

        [HttpDelete]
        public void DeleteContact2(int contactId)
        {
            Contact contactToDelete = contacts.First(contact => contact.ContactId == contactId);
            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
            }
        }
        #endregion
    }
}