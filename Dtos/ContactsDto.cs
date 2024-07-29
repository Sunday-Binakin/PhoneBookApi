using PhoneBookApi.Models;

namespace PhoneBookApi.Dtos;

public class ContactsDto
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? PhoneNumber { get; set; }
    public string? EmailAddress { get; set; }
    public ContactCategories Categories { get; set; }
     
}