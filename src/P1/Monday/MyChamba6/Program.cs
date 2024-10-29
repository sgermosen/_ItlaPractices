
using MyChamba6;


//var contact = new Contact();

//contact.name = "Juan";
//contact.SetName("Juan");

//var name = contact.GetCurrentName();
//Console.WriteLine(contact.GetCurrentName());
//contact.Name = "Test";
//Console.WriteLine(contact.Name);
//int typedOption;
//typedOption = new int();
//typedOption = 0;
int typedOption = 0;
bool running = true;
List<Contact> contacts = new List<Contact>();
//List<Contact> contacts2;
// contacts2 = new List<Contact>();
var refContact = new Contact();
Console.WriteLine("Welcome to your Personal Agenda");

while (running == true)
{
    System.Console.WriteLine("Please choose an option");

    Console.WriteLine("1. List all Contacts, 2. See a Contact, 3. Add New Contact, 4. Update a Contact, 5. Remove a Contact, 6. Exit Application");

    typedOption = Convert.ToInt32(Console.ReadLine());

    switch (typedOption)
    {
        case 1:
            {
                //refContact.ListAllContacts(contacts);
                ContactHelper.ListAllContacts(contacts);
            }
            break;
        case 2:
            {

                ContactHelper.ShowDetailsOfOneContact(contacts);
            }
            break;
        case 3:
            {
                var contact = new Contact();// ("name","","","");
                
                Console.Write("Please type a Name: ");
                contact.Name = Console.ReadLine();
                Console.Write("Please type a LastName: ");
                contact.LastName = Console.ReadLine();
                Console.Write("Please type a age: ");
                contact.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type a Email: ");
                contact.Email = Console.ReadLine();
                Console.Write("Please type a Address: ");
                contact.Address = Console.ReadLine();

                bool isFavorite = false;
                Console.Write("This is a favorite contact? 1. Yes, 2 No: ");
                int typed = Convert.ToInt32(Console.ReadLine());

                if (typed == 1)
                    isFavorite = true;
                contact.IsFavorite =isFavorite;

                var id = ContactHelper.CreateNewId(contacts);
                contact.Id = id;
                
                contacts.Add(contact); 

            }
            break;
        case 4:
            {
                Console.WriteLine("Please type an id");

                int id = Convert.ToInt32(Console.ReadLine());
                Contact contact = contacts.FirstOrDefault(c => c.Id == id);

                Console.Write($"Please type a new Name for {contact.Name}: ");
                contact .Name = Console.ReadLine();
                Console.Write("Please type a LastName: ");
                contact.LastName = Console.ReadLine();
                Console.Write("Please type a age: ");
                contact.Age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type a Email: ");
                contact.Email = Console.ReadLine();
                Console.Write("Please type a Address: ");
                contact.Address = Console.ReadLine();

                bool isFavorite = false;
                Console.Write("This is a favorite contact? 1. Yes, 2 No: ");
                int typed = Convert.ToInt32(Console.ReadLine());

                if (typed == 1)
                    isFavorite = true;

                contact.IsFavorite = isFavorite;

                //contacts.Remove(contact);
                //contacts.Add(contact);


            }
            break;
        case 5:
            { 

            }
            break;
        case 6:
            {
                running = false;
            }
            break;
        default:
            break;
    }


}
 
