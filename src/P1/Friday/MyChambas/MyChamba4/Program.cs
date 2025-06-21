
Console.WriteLine("\n\n=== Welcome to our Contactes App");

int id1 = 0;
string name1 = "";
string lastname1 = "";
string email1 = "";
string address1 = "";
int age1 = 0;
bool favorite1 = false;

int id2 = 0;
string name2 = "";
string lastname2 = "";
string email2 = "";
string address2 = "";
int age2 = 0;
bool favorite2 = false;

int id3 = 0;
string name3 = "";
string lastname3 = "";
string email3 = "";
string address3 = "";
int age3 = 0;
bool favorite3 = false;

int contactCount = 0;
bool wantToContinue = true;
int choosenOption = 0;


while (wantToContinue)
{
    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Exit");
    choosenOption = Convert.ToInt32(Console.ReadLine());

    switch (choosenOption)
    {
        case 1:
            {
                if (contactCount >= 3)
                {
                    Console.WriteLine("Contact List is Full.");
                    break;
                }

                contactCount++;

                if (contactCount == 1)
                {
                    id1 = 1;
                    Console.WriteLine("Type a name");
                    name1 = Console.ReadLine();
                    Console.WriteLine("Type a lastname");
                    lastname1 = Console.ReadLine();
                    Console.WriteLine("Type an email");
                    email1 = Console.ReadLine();
                    Console.WriteLine("Type an address");
                    address1 = Console.ReadLine();
                    Console.WriteLine("Type an age");
                    age1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
                    favorite1 = Console.ReadLine() == "1" ? true : false;
                }
                else if (contactCount == 2)
                {
                    id2 = 2;
                    Console.WriteLine("Type a name");
                    name2 = Console.ReadLine();
                    Console.WriteLine("Type a lastname");
                    lastname2 = Console.ReadLine();
                    Console.WriteLine("Type an email");
                    email2 = Console.ReadLine();
                    Console.WriteLine("Type an address");
                    address2 = Console.ReadLine();
                    Console.WriteLine("Type an age");
                    age2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
                    favorite2 = Console.ReadLine() == "1" ? true : false;
                }
                else if (contactCount == 3)
                {
                    id3 = 3;
                    Console.WriteLine("Type a name");
                    name3 = Console.ReadLine();
                    Console.WriteLine("Type a lastname");
                    lastname3 = Console.ReadLine();
                    Console.WriteLine("Type an email");
                    email3 = Console.ReadLine();
                    Console.WriteLine("Type an address");
                    address3 = Console.ReadLine();
                    Console.WriteLine("Type an age");
                    age3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
                    favorite3 = Console.ReadLine() == "1" ? true : false;
                }
            }
            break;
        case 2:
            {
                Console.WriteLine("Type the id of the contact than you want to edit (1-3)");
                var id = Convert.ToInt32(Console.ReadLine());

                if (id == 1 && id1 > 0)
                {
                    Console.WriteLine($"Type the new name for {name1}");
                    name1 = Console.ReadLine();
                }
                else if (id == 2 && id2 > 0)
                {
                    Console.WriteLine($"Type the new name for {name2}");
                    name2 = Console.ReadLine();
                }
                else if (id == 3 && id3 > 0)
                {
                    Console.WriteLine($"Type the new name for {name3}");
                    name3 = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Contact not found!");
                }
            }
            break;
        case 3:
            {
                Console.WriteLine("---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");

                if (id1 > 0)
                {
                    var isFavoriteStr = favorite1 ? "Yes" : "No";
                    Console.WriteLine($"---{name1}      {lastname1}     {email1}        {address1}     {age1}      {isFavoriteStr}----");
                }
                if (id2 > 0)
                {
                    var isFavoriteStr = favorite2 ? "Yes" : "No";
                    Console.WriteLine($"---{name2}      {lastname2}     {email2}        {address2}     {age2}      {isFavoriteStr}----");
                }
                if (id3 > 0)
                {
                    var isFavoriteStr = favorite3 ? "Yes" : "No";
                    Console.WriteLine($"---{name3}      {lastname3}     {email3}        {address3}     {age3}      {isFavoriteStr}----");
                }
            }
            break;
        case 4:
            {
                wantToContinue = false;
            }
            break;
    }
}
Console.WriteLine("Closing the app");


Console.ReadKey();


// ArrayVersion()
{
    //const int MAX_CONTACTS = 10;  

    //int[] ids = new int[MAX_CONTACTS];
    //string[] names = new string[MAX_CONTACTS];
    //string[] lastnames = new string[MAX_CONTACTS];
    //string[] emails = new string[MAX_CONTACTS];
    //string[] addresses = new string[MAX_CONTACTS];
    //int[] ages = new int[MAX_CONTACTS];
    //bool[] favorites = new bool[MAX_CONTACTS];

    //int contactCount = 0;  
    //bool wantToContinue = true;
    //int choosenOption = 0;


    //while (wantToContinue)
    //{
    //    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Search Contact, 5. Delete Contact, 6. Exit");
    //    choosenOption = Convert.ToInt32(Console.ReadLine());

    //    switch (choosenOption)
    //    {
    //        case 1:
    //            {
    //                if (contactCount >= MAX_CONTACTS)
    //                {
    //                    Console.WriteLine($"Contect List is Full");
    //                    break;
    //                }

    //                ids[contactCount] = contactCount + 1;

    //                Console.WriteLine("Type a name");
    //                names[contactCount] = Console.ReadLine();

    //                Console.WriteLine("Type a lastname");
    //                lastnames[contactCount] = Console.ReadLine();

    //                Console.WriteLine("Type an address");
    //                addresses[contactCount] = Console.ReadLine();

    //                Console.WriteLine("Type a email");
    //                emails[contactCount] = Console.ReadLine();

    //                Console.WriteLine("Type an age");
    //                ages[contactCount] = Convert.ToInt32(Console.ReadLine());

    //                Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

    //                //var typedOption = Convert.ToInt32(Console.ReadLine());
    //                //bool isFavorite;
    //                //if (typedOption == 1)
    //                //    isFavorite = true;
    //                //else if(typedOption == 2)
    //                //    isFavorite = false;
    //                //else
    //                //    isFavorite = false;

    //                //bool isFavorite = typedOption == 1 ? true : false;
    //                //bool isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

    //                favorites[contactCount] = Console.ReadLine() == "1" ? true : false;

    //                contactCount++;
    //            }
    //            break;
    //        case 2:
    //            {
    //                Console.WriteLine("Type the id of the contact than you want to edit");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                int index = -1;
    //                for (int i = 0; i < contactCount; i++)
    //                {
    //                    if (ids[i] == id)
    //                    {
    //                        index = i;
    //                        break;
    //                    }
    //                }

    //                if (index != -1)
    //                {
    //                    Console.WriteLine($"Type the new name for {names[index]}");
    //                    names[index] = Console.ReadLine(); 

    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 3:
    //            {
    //                Console.WriteLine("---ID---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");

    //                for (int i = 0; i < contactCount; i++)
    //                { 
    //                    //var isFavoriteStr = string.Empty;
    //                    //if (favorites[i] == true)
    //                    //// if (favorites[i])
    //                    //{ isFavoriteStr = "Yes"; }
    //                    //else
    //                    //{ isFavoriteStr = "No"; }

    //                    var isFavoriteStr = favorites[i] == true ? "Yes" : "No";
    //                    // var isFavoriteStr = favorites[i] ? "Yes" : "No";

    //                    Console.WriteLine($"---{ids[i]}---{names[i]}      {lastnames[i]}     {emails[i]}        {addresses[i]}     {ages[i]}      {isFavoriteStr}----");
    //                }
    //            }
    //            break;
    //        case 4:
    //            {
    //                Console.WriteLine("Search by: 1. Name, 2. Lastname");
    //                var searchOption = Convert.ToInt32(Console.ReadLine());

    //                if (searchOption == 1)
    //                {
    //                    Console.WriteLine("Type the name to search:");
    //                    var searchName = Console.ReadLine();

    //                    for (int i = 0; i < contactCount; i++)
    //                    {
    //                        if (names[i].Contains(searchName, StringComparison.OrdinalIgnoreCase))
    //                        {
    //                            var isFavoriteStr = favorites[i] ? "Yes" : "No";
    //                            Console.WriteLine($"Found: {names[i]} {lastnames[i]} - {emails[i]}");
    //                        }
    //                    }
    //                }
    //            }
    //            break;
    //        case 5:
    //            {
    //                Console.WriteLine("Type the id of the contact to delete");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                int indexToDelete = -1;
    //                for (int i = 0; i < contactCount; i++)
    //                {
    //                    if (ids[i] == id)
    //                    {
    //                        indexToDelete = i;
    //                        break;
    //                    }
    //                }

    //                if (indexToDelete != -1)
    //                { 
    //                    for (int i = indexToDelete; i < contactCount - 1; i++)
    //                    {
    //                        ids[i] = ids[i + 1];
    //                        names[i] = names[i + 1];
    //                        lastnames[i] = lastnames[i + 1];
    //                        emails[i] = emails[i + 1];
    //                        addresses[i] = addresses[i + 1];
    //                        ages[i] = ages[i + 1];
    //                        favorites[i] = favorites[i + 1];
    //                    }
    //                    contactCount--;
    //                    Console.WriteLine("Contact deleted!");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 6:
    //            {
    //                wantToContinue = false;
    //            }
    //            break;
    //    }
    //}
    Console.WriteLine("Closing the app");
}

// ListVersion()
{
    //List<int> ids = new List<int>();
    //List<string> names = new List<string>();
    //List<string> lastnames = new List<string>();
    //List<string> emails = new List<string>();
    //List<string> addresses = new List<string>();
    //List<int> ages = new List<int>();
    //List<bool> favorites = new List<bool>();

    //bool wantToContinue = true;
    //int choosenOption = 0; 

    //while (wantToContinue)
    //{
    //    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Search Contact, 5. Delete Contact, 6. Exit");
    //    choosenOption = Convert.ToInt32(Console.ReadLine());

    //    switch (choosenOption)
    //    {
    //        case 1:
    //            {
    //                var id = ids.Count + 1;
    //                ids.Add(id);

    //                Console.WriteLine("Type a name");
    //                var name = Console.ReadLine();
    //                names.Add(name);

    //                Console.WriteLine("Type a lastname");
    //                var lastname = Console.ReadLine();
    //                lastnames.Add(lastname);

    //                Console.WriteLine("Type an address");
    //                var address = Console.ReadLine();
    //                addresses.Add(address);

    //                Console.WriteLine("Type a email");
    //                var email = Console.ReadLine();
    //                emails.Add(email);

    //                Console.WriteLine("Type an age");
    //                var age = Convert.ToInt32(Console.ReadLine());
    //                ages.Add(age);

    //                Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

    //                bool isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
    //                favorites.Add(isFavorite);
    //            }
    //            break;
    //        case 2:
    //            {
    //                Console.WriteLine("Type the id of the contact than you want to edit");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                if (id > 0 && id <= ids.Count)
    //                {
    //                    int index = id - 1;

    //                    Console.WriteLine($"Type the new name for {names[index]}");
    //                    names[index] = Console.ReadLine();

    //                    Console.WriteLine("Type a lastname");
    //                    lastnames[index] = Console.ReadLine();

    //                    Console.WriteLine("Type an address");
    //                    addresses[index] = Console.ReadLine();

    //                    Console.WriteLine("Type a email");
    //                    emails[index] = Console.ReadLine();

    //                    Console.WriteLine("Type an age");
    //                    ages[index] = Convert.ToInt32(Console.ReadLine());

    //                    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
    //                    favorites[index] = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 3:
    //            {
    //                Console.WriteLine("---ID---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");

    //                for (int i = 0; i < ids.Count; i++)
    //                { 

    //                    var isFavoriteStr = favorites[i] == true ? "Yes" : "No"; 

    //                    Console.WriteLine($"---{ids[i]}---{names[i]}      {lastnames[i]}     {emails[i]}        {addresses[i]}     {ages[i]}      {isFavoriteStr}----");
    //                }
    //            }
    //            break;
    //        case 4:
    //            {
    //                Console.WriteLine("Search by name:");
    //                var searchName = Console.ReadLine();

    //                for (int i = 0; i < names.Count; i++)
    //                {
    //                    if (names[i].Contains(searchName, StringComparison.OrdinalIgnoreCase))
    //                    {
    //                        var isFavoriteStr = favorites[i] ? "Yes" : "No";
    //                        Console.WriteLine($"Found: ID={ids[i]} - {names[i]} {lastnames[i]} - {emails[i]}");
    //                    }
    //                }
    //            }
    //            break;
    //        case 5:
    //            {
    //                Console.WriteLine("Type the id of the contact to delete");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                if (id > 0 && id <= ids.Count)
    //                {
    //                    int index = id - 1;

    //                    ids.RemoveAt(index);
    //                    names.RemoveAt(index);
    //                    lastnames.RemoveAt(index);
    //                    emails.RemoveAt(index);
    //                    addresses.RemoveAt(index);
    //                    ages.RemoveAt(index);
    //                    favorites.RemoveAt(index);

    //                    for (int i = index; i < ids.Count; i++)
    //                    {
    //                        ids[i] = i + 1;
    //                    }

    //                    Console.WriteLine("Contact deleted!");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 6:
    //            {
    //                wantToContinue = false;
    //            }
    //            break;
    //    }
    //}
    Console.WriteLine("Closing the app");
}

// DictionaryVersion()
{
    //List<int> ids = new List<int>();
    //Dictionary<int, string> names = new Dictionary<int, string>();
    //Dictionary<int, string> lastnames = new Dictionary<int, string>();
    //Dictionary<int, string> emails = new Dictionary<int, string>();
    //Dictionary<int, string> addresses = new Dictionary<int, string>();
    //Dictionary<int, int> ages = new Dictionary<int, int>();
    //Dictionary<int, bool> favorites = new Dictionary<int, bool>();

    //bool wantToContinue = true;
    //int choosenOption = 0; 

    //while (wantToContinue)
    //{
    //    Console.WriteLine("Please Choose an Option: 1. Add New Contact, 2. Edit Contact, 3. List All Contacts, 4. Search Contact, 5. Delete Contact, 6. Exit");

    //    choosenOption = Convert.ToInt32(Console.ReadLine());

    //    switch (choosenOption)
    //    {
    //        case 1:
    //            {
    //                AddNewContact(ids, names, lastnames, emails, addresses, ages, favorites);
    //            }
    //            break;
    //        case 2:
    //            {
    //                Console.WriteLine("Type the id of the contact than you want to edit");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                if (names.ContainsKey(id))
    //                {
    //                    string name = names[id];
    //                    Console.WriteLine($"Type the new name for {name}");
    //                    name = Console.ReadLine();
    //                    names[id] = name;  

    //                    Console.WriteLine("Type a lastname");
    //                    lastnames[id] = Console.ReadLine();

    //                    Console.WriteLine("Type an address");
    //                    addresses[id] = Console.ReadLine();

    //                    Console.WriteLine("Type a email");
    //                    emails[id] = Console.ReadLine();

    //                    Console.WriteLine("Type an age");
    //                    ages[id] = Convert.ToInt32(Console.ReadLine());

    //                    Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");
    //                    favorites[id] = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;

    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 3:
    //            {
    //                Console.WriteLine("---ID---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");

    //                foreach (var id in ids) //.OrderByDescending(p=> p))
    //                {


    //                    var isFavoriteStr = favorites[id] == true ? "Yes" : "No"; 

    //                    Console.WriteLine($"---{id}---{names[id]}      {lastnames[id]}     {emails[id]}        {addresses[id]}     {ages[id]}      {isFavoriteStr}----");
    //                }
    //            }
    //            break;
    //        case 4:
    //            {
    //                Console.WriteLine("Search by name:");
    //                var searchName = Console.ReadLine();

    //                foreach (var id in ids)
    //                {
    //                    if (names[id].Contains(searchName, StringComparison.OrdinalIgnoreCase))
    //                    {
    //                        var isFavoriteStr = favorites[id] ? "Yes" : "No";
    //                        Console.WriteLine($"Found: ID={id} - {names[id]} {lastnames[id]} - {emails[id]}");
    //                    }
    //                }
    //            }
    //            break;
    //        case 5:
    //            {
    //                Console.WriteLine("Type the id of the contact to delete");
    //                var id = Convert.ToInt32(Console.ReadLine());

    //                if (ids.Contains(id))
    //                { 
    //                    ids.Remove(id);
    //                    names.Remove(id);
    //                    lastnames.Remove(id);
    //                    emails.Remove(id);
    //                    addresses.Remove(id);
    //                    ages.Remove(id);
    //                    favorites.Remove(id);

    //                    Console.WriteLine("Contact deleted!");
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Contact not found!");
    //                }
    //            }
    //            break;
    //        case 6:
    //            {
    //                wantToContinue = false;
    //            }
    //            break;
    //        default:
    //            break;
    //    }
    //}

    Console.WriteLine("Closing the app");

}
Console.ReadKey();

