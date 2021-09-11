using Contact.Infrastructure;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ContactController : ControllerBase
  {
    private readonly IContactService _contactService;

    public ContactController(IContactService contactService)
    {
      _contactService = contactService;
    }

    [HttpGet("{id}")]
    public IActionResult GetContact(int id)
    {
        var result = _contactService.GetContactById(id);
        return Ok(result);
    }
  }
}
