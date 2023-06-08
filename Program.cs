﻿class Program
{

    static void Main(string[] args)
    {
      //create contact 
        Contact nance = new Contact()
        {
            FirstName = "Kis",
            LastName = "Bill",
            Email = "bkis.ios@email.com",
            Address = "200 Brado  Ave, Mister, WV 31111"
        };
        Contact jane = new Contact()
        {
            FirstName = "Jane",
            LastName = "Johnson",
            Email = "Jane.jonhson@email.com",
            Address = "313 Fogle Way, Mister, WV 31111"
        };
        Contact kis = new Contact()
        {
            FirstName = "Nance",
            LastName = "Way",
            Email = "nance.wayz@email.com",
            Address = "987 9th St, Mister, WV 31111"
        };


        //creating the address book and contacts 
        AddressBook addressBook = new AddressBook();
        addressBook.AddContact(kis);
        addressBook.AddContact(jane);
        addressBook.AddContact(nance);

       //TRY to add a contact for the second time 
        addressBook.AddContact(jane);

        //Create a list of emails matching the contacts in database

        List<string> emails = new List<string>() {
            "bkis.ios@email.com",
            "Jane.jonhson@email.com",
            "nance.wayz@email.com",
        };

             // Add an email that does not match a contact
        emails.Insert(1, "notmine@yahoo.com");


        //By email, you can search the AddressBook and print contact details
        foreach (string email in emails)
        {
            try
            {
            Contact contact = addressBook.GetByEmail(email);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Name: {contact.FullName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Address: {contact.Address}");
            }
            catch(KeyNotFoundException
            ex)
            {
                Console.WriteLine($"No contact found for that email: {email}, ya donuthole");
            }
        }
    }
}