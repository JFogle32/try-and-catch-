public class AddressBook
{
    private Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>();
    public void AddContact (Contact? contact)
    {
      
        if(_contactList.ContainsKey(contact.Email))
        {
            Console.WriteLine($"Email already used");
        }
        else 
        {
        _contactList.Add(contact.Email, contact);            
        }
    }

    public Contact GetByEmail(string email)
    {
        return _contactList[email];
    }
}