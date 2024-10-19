
List<int> ids = new List<int>();



//List<string> names = new List<string>();
//List<string> lastnames = new List<string>();
//List<string> emails = new List<string>();
//List<string> addresses = new List<string>();
//List<int> ages = new List<int>();
//List<bool> favorites = new List<bool>();

Dictionary<int, string> names = new Dictionary<int, string>();
Dictionary<int, string> lastnames = new Dictionary<int, string>();
Dictionary<int, string> emails = new Dictionary<int, string>();
Dictionary<int, string> addresses = new Dictionary<int, string>();
Dictionary<int, int> ages = new Dictionary<int, int>();
Dictionary<int, bool> favorites = new Dictionary<int, bool>();

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

                //string name = string.Empty;
                //for (int i = 0; i < names.Count; i++)
                //{
                //    if (i + 1 == id)
                //    {
                //        name = names[i];
                //    }
                //}
                // string name =  names[id -1];
                string name = names[id];
                Console.WriteLine($"Type the new name for {name}");
                name = Console.ReadLine();
                names.Remove(id);
                names.Add(id, name);

                //Console.WriteLine("Type a lastname");
                //var lastname = Console.ReadLine();
                //lastnames.Add(lastname);

                //Console.WriteLine("Type an address");
                //var address = Console.ReadLine();
                //addresses.Add(address);

                //Console.WriteLine("Type a email");
                //var email = Console.ReadLine();
                //emails.Add(email);

                //Console.WriteLine("Type an age");
                //var age = Convert.ToInt32(Console.ReadLine());
                //ages.Add(age);

                //Console.WriteLine("Is favorite Contact? 1. Yes, 2. No");

                //bool isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
                //favorites.Add(isFavorite);

            }
            break;
        case 3:
            {

                Console.WriteLine("---Name------------Lastname------------Email------------Address------------Age------------Is Favorite----");
                foreach (var id in ids)
                {
                    //var isFavoriteStr = string.Empty;
                    ////if (favorites[id] == true)
                    //if (favorites[id])
                    //{ isFavoriteStr = "Yes"; }
                    //else
                    //{ isFavoriteStr = "No"; }

                    var isFavoriteStr = favorites[id]? "Yes": "No";

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
    //var typedOption = Convert.ToInt32(Console.ReadLine());
    //bool isFavorite;
    //if (typedOption == 1)
    //    isFavorite = true;
    ////else if(typedOption == 2)
    ////    isFavorite = false;
    //else
    //    isFavorite = false;
    //bool isFavorite = typedOption == 1 ? true : false;
    bool isFavorite = Convert.ToInt32(Console.ReadLine()) == 1 ? true : false;
    favorites.Add(id, isFavorite);
}