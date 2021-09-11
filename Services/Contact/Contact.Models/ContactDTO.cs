namespace Contact.Models
{
  public class ContactDTO
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string FullName => $"{Name} {Surname}";
  }
}