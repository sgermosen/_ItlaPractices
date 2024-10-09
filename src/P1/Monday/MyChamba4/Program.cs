//name, lastname, address, tc

using System.Xml.Linq;

List<int> ids = new List<int>();

 

//List<string> names = new List<string>();
//List<string> lastnames = new List<string>();

Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> isFavorites = new Dictionary<int, bool>();

int typedOption = 0;
bool running = true;
//ids.Add(0);
////names.Add("Juan");
////lastnames.Add("Almonte");
//names.Add(0, "Juan");
//lastnames.Add(0, "Almonte");

//ids.Add(1);
////names.Add("Pedro"); 
////lastnames.Add("Castro");
//names.Add(1, "Pedro");
//lastnames.Add(1, "Castro");

//Console.WriteLine($"The contact: {ids[0]} has the name: {names[0]} and lastname {lastnames[0]}");

//foreach (int id in ids)
//{
//    Console.WriteLine($"The contact: {ids[id]} has the name: {names[id]} and lastname {lastnames[id]}");

//}

//try to search by other elements 

Console.WriteLine("Welcome to your Personal Agenda");

while (running == true)
{
    Console.WriteLine("Please choose an option");

    Console.WriteLine("1. List all Contacts, 2. See a Contact, 3. Add New Contact, 4. Update a Contact, 5. Remove a Contact, 6. Exit Application");

    typedOption = Convert.ToInt32(Console.ReadLine());

    switch (typedOption)
    {
        case 1:
            {
                //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                //Console.WriteLine("++Name \t\t Lastname \t\t Address \t\t Email \t\t Age \t\t++");
                //Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                //foreach (int id in ids)
                //{
                //    Console.WriteLine($"++{names[id]} \t\t {lastnames[id]} \t\t {addresses[id]} \t\t {emails[id]} \t\t {ages[id]} \t\t++");
                //}
                ListAllContacts(ids, names, lastnames, addresses, emails, ages);
            }
            break;
        case 2:
            {
                //Console.WriteLine("Please type an id");
                //int id = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"++{names[id]} \t\t {lastnames[id]} \t\t {addresses[id]} \t\t {emails[id]} \t\t {ages[id]} \t\t++");

                ShowDetailsOfOneContact(names, lastnames, addresses, emails, ages);
            }
            break;
        case 3:
            {
                Console.Write("Please type a Name: ");
                string name = Console.ReadLine();
                Console.Write("Please type a LastName: ");
                string lastname = Console.ReadLine();
                Console.Write("Please type a age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type a Email: ");
                string email = Console.ReadLine();
                Console.Write("Please type a Address: ");
                string address = Console.ReadLine();

                bool isFavorite = false;
                Console.Write("This is a favorite contact? 1. Yes, 2 No: ");
                int typed =Convert.ToInt32( Console.ReadLine());

                if (typed == 1)
                    isFavorite = true;

                var id = CreateNewId(ids);
                ids.Add(id);

                // CreateNewIdByRef(ref ids);

                AddItems(names, lastnames, addresses, emails, ages, isFavorites, name, lastname, age, email, id, isFavorite);

            }
            break;
        case 4:
            {
                Console.WriteLine("Please type an id");

                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write($"Please type a new Name for {names[id]}: ");
                string name = Console.ReadLine();
                Console.Write("Please type a LastName: ");
                string lastname = Console.ReadLine();
                Console.Write("Please type a age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please type a Email: ");
                string email = Console.ReadLine();
                Console.Write("Please type a Address: ");
                string address = Console.ReadLine();

                bool isFavorite = false;
                Console.Write("This is a favorite contact? 1. Yes, 2 No: ");
                int typed = Convert.ToInt32(Console.ReadLine());

                if (typed == 1)
                    isFavorite = true;
                //  names.Remove(id);
                // // names.Add(id, name);
                //  addresses.Remove(id);
                ////  addresses.Add(id, lastname);
                //  emails.Remove(id);
                // // emails.Add(id, email);
                //  ages.Remove(id);
                // // ages.Add(id, age);
                //  lastnames.Remove(id);
                //  //lastnames.Add(id, lastname);
                RemoveItems(names, lastnames, addresses, emails, ages, ids, id);

               
                AddItems(names, lastnames, addresses, emails, ages, isFavorites, name, lastname, age, email, id, isFavorite);


            }
            break;
        case 5:
            {
                Console.WriteLine("Please type an id");

                int id = Convert.ToInt32(Console.ReadLine());
                RemoveItems(names, lastnames, addresses, emails, ages, ids, id);

                //names.Remove(id);
                //addresses.Remove(id);
                //emails.Remove(id);
                //ages.Remove(id);
                //lastnames.Remove(id);
                //ids.Remove(id);
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

static void AddItems(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages, Dictionary<int, bool> favorites, string name, string lastname, int age, string email, int id, bool favorite)
{
    names.Add(id, name);
    addresses.Add(id, lastname);
    emails.Add(id, email);
    ages.Add(id, age);
    lastnames.Add(id, lastname);
    favorites.Add(id, favorite);
}
//static void AddItems(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages, string name, string lastname, int age, string email, int id)
//{
//    names.Add(id, name);
//    addresses.Add(id, lastname);
//    emails.Add(id, email);
//    ages.Add(id, age);
//    lastnames.Add(id, lastname);
//}

static void RemoveItems(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages,  List<int> ids, int id)
{
    names.Remove(id);
    addresses.Remove(id);
    emails.Remove(id);
    ages.Remove(id);
    lastnames.Remove(id);
    ids.Remove(id);
}

static void ListAllContacts(List<int> ids, Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages)
{
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("++Name \t\t Lastname \t\t Address \t\t Email \t\t Age \t\t++");
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    foreach (int id in ids)
    {
        Console.WriteLine($"++{names[id]} \t\t {lastnames[id]} \t\t {addresses[id]} \t\t {emails[id]} \t\t {ages[id]} \t\t++");
    }
}

static void ShowDetailsOfOneContact(Dictionary<int, string> names, Dictionary<int, string> lastnames, Dictionary<int, string> addresses, Dictionary<int, string> emails, Dictionary<int, int> ages)
{
    Console.WriteLine("Please type an id");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"++{names[id]} \t\t {lastnames[id]} \t\t {addresses[id]} \t\t {emails[id]} \t\t {ages[id]} \t\t++");
}

static int CreateNewId(List<int> ids)
{
    int id;
    if (ids.Any())
    {
        int maxId = ids.Max(p => p);
        if (maxId == null)
        { id = 1; }
        else
        { id = maxId + 1; }
    }
    else
    {
        id = 1;
    }

    return id;
}

static void CreateNewIdByRef(ref List<int> ids)
{
    int id;
    if (ids.Any())
    {
        int maxId = ids.Max(p => p);
        if (maxId == null)
        { id = 1; }
        else
        { id = maxId + 1; }
    }
    else
    {
        id = 1;
    }
    ids.Add(id);
}
