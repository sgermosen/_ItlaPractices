namespace MyChamba6
{
    public class Contact
    {
        //int id;
        //string name;
        //string lastname;
        //string addresse;
        //string email;
        //int age;
        //bool isFavorite;
        public Contact()
        {
            
        }
        public Contact(string name, string lastname, string addresse, string email, bool isFavorite)
        {
            Name = name;
            LastName = lastname;
        }
        public Contact(string name, string lastname, string addresse, string email)
        {
            Name = name;
            LastName = lastname;
        }
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }

        //    set
        //    {
        //        name = value;
        //    } 
        //}
        public int Id { get; private set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public bool IsFavorite { get; set; }

        //public void SetNames(Contact value)
        //{
        //    Name = value.Name;
        //}
        //public void SetNames(string value)
        //{
        //    Name = value;
        //}
        //public void SetNames(string value, string lastnmete)
        //{
        //    Name = value;
        //    LastName = lastnmete;
        //}
        //public string GetCurrentName()
        //{
        //   return name;
        //}



    }
}
