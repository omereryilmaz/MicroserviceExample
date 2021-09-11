using Contact.Models;

namespace Contact.Infrastructure
{
  public interface IContactService
  {
    public ContactDTO GetContactById(int id);
  }
}
