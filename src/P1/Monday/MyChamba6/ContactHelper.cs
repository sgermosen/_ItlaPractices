namespace MyChamba6
{
    public static class ContactHelper
    {
        public static void ListAllContacts(List<Contact> contacts)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++Name \t\t Lastname \t\t Address \t\t Email \t\t Age \t\t++");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            foreach (var item in contacts)
            {
                Console.WriteLine($"++{item.Name} \t\t {item.LastName} \t\t {item.Address} \t\t {item.Email} \t\t {item.Age} \t\t++");
            }
        }

        public static void ShowDetailsOfOneContact(List<Contact> contacts)
        {
            Console.WriteLine("Please type an id");
            int id = Convert.ToInt32(Console.ReadLine());
            var contact = new Contact();
            //foreach (var item in contacts)
            //{
            //    if (item.Id == id)
            //    {
            //        contact = item;
            //        break;
            //    } 
            //}
            //contact = contacts.Where(c => c.Id == id).FirstOrDefault();
            contact = contacts.FirstOrDefault(c => c.Id == id);

            Console.WriteLine($"++{contact.Name} \t\t {contact.LastName} \t\t {contact.Address} \t\t {contact.Email} \t\t {contact.Age} \t\t++");
        }

        public static int CreateNewId(List<Contact> ids)
        {
            int id;
            if (ids.Any())
            {
                //int count = ids.Count;

                int maxId = ids.Max(p => p.Id);
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

        public static void CreateNewIdByRef(ref List<int> ids)
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

    }
}
