namespace PhoneBookApi.Models;

public class Contacts
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string EmailAddress { get; set; }
    public ContactCategories Categories { get; set; }
    public DateTime DateOfBrith { get; set; }
}