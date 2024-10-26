

using MyChamba6;

//var contact = new Contact(1, "Juan", "Alberto", "email@email.com", "Calle", 52, true);
//var contact3 = new Contact();
//var contact4 = new Contact().CreateContactInstance(2, "Juan2", "Alberto2", "email@email.com", "Calle", 52, true);

//Contact contact2;
//contact2 = new Contact();

//contact2.Id = 1;
//Console.WriteLine(contact2.Id);
////contact2.email = "Test@test.com";
//contact2.Email = "Test@test.com";

//contact.IsFavorite = true;
//contact.SetAsFavorite();

//Console.WriteLine(contact.IsFavorite);

//var fullname = contact2.FullName();

List<Contact> contacts = new List<Contact>();

bool wantToContinue = true;
int choosenOption = 0;
Console.WriteLine("This is your personal Agenda");

while (wantToContinue)
{
    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Search Contact, 5. Delete Contact, 6. Exit");

    choosenOption = Convert.ToInt32(Console.ReadLine());

    switch (choosenOption)
    {
        case 1:
            {
                //var contact = ContactHelper.AddNewContact(contacts.Count);
                //contacts.Add(contact);

                ContactHelper.AddNewContact(contacts); 
            }
            break;
        case 2:
            {
                Console.WriteLine("Type the id of the contact than you want to edit");
                var id = Convert.ToInt32(Console.ReadLine());
                ContactHelper.EditContact(contacts, id);

            }
            break;
        case 3:
            {

                Console.WriteLine("---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");
                foreach (var item in contacts)
                {

                    var isFavoriteStr = item.IsFavorite ? "Yes" : "No";

                    Console.WriteLine($"---{item.Name}      {item.LastName}     {item.Email}        {item.Address}     {item.Age}      {isFavoriteStr}----");

                }

            }
            break;
        case 4:
            { }
            break;
        case 5: { } break;
        case 6:
            {
                wantToContinue = false;
            }
            break;
        default:
            break;
    }

}

Console.WriteLine("Closing the app");
Console.ReadKey();

