

using MyChamba6;

var contact = new Contact(1, "Juan", "Alberto", "email@email.com", "Calle", 52, true);
var contact3 = new Contact();
Contact contact2;
contact2 = new Contact();

contact2.Id = 1;
Console.WriteLine(contact2.Id);
//contact2.email = "Test@test.com";
contact2.Email = "Test@test.com";

//contact.IsFavorite = true;
contact.SetAsFavorite();

Console.WriteLine(contact.IsFavorite);

var fullname = contact2.FullName();

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
                var count = ids.Count();
                AddNewContact(ids, names, lastnames, emails, addresses, ages, favorites);
                var count2 = ids.Count();
            }
            break;
        case 2:
            {
                Console.WriteLine("Type the id of the contact than you want to edit");
                var id = Convert.ToInt32(Console.ReadLine());

                string name = names[id];
                Console.WriteLine($"Type the new name for {name}");
                name = Console.ReadLine();
                names.Remove(id);
                names.Add(id, name);

            }
            break;
        case 3:
            {

                Console.WriteLine("---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");
                foreach (var id in ids)
                {

                    var isFavoriteStr = favorites[id] ? "Yes" : "No";

                    Console.WriteLine($"---{names[id]}      {lastnames[id]}     {emails[id]}        {addresses[id]}     {ages[id]}      {isFavoriteStr}----");

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

static void AddNewContact(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> emails, Dictionary<int, string> addresses, Dictionary<int, int> ages, Dictionary<int, bool> favorites)
{
    var id = ids.Count + 1;
    ids.Add(id);

    Console.WriteLine("Type a name");
    var name = Console.ReadLine();
    names.Add(id, name);

    Console.WriteLine("Type a lastname");
    var lastname = Console.ReadLine();
    lastnames.Add(id, lastname);

    Console.WriteLine("Type an address");
    var address = Console.ReadLine();
    addresses.Add(id, address);

    Console.WriteLine("Type a email");
    var email = Console.ReadLine();
    emails.Add(id, email);

    Console.WriteLine("Type an age");
    var age = Convert.ToInt32(Console.ReadLine());
    ages.Add(id, age);

    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

    bool isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
    favorites.Add(id, isFavorite);
}