using Contact.Infrastructure;
using Contact.Models;

namespace Contact.Services
{
  public class ContactService : IContactService
  {
    public ContactDTO GetContactById(int id)
    {
      return new ContactDTO()
      {
          Id = id,
          Name = "Omer",
          Surname = "Eryilmaz"
      };
    }
  }
}