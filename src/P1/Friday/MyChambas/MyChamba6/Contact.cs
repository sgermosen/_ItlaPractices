namespace MyChamba6
{
    public class Contact
    {
        //    int id;
        //    string name;
        //    string lastname;
        //    public string email;
        //    string addresse;
        //    int age;
        //    bool idFavorite;
         
        public Contact()
        {
            
        }
        public Contact(int id, string name, string lastname, string email, string address, int age, bool isFavorite)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Address = address;
            Age = age;
            IsFavorite = isFavorite; 
        }

        //    public int Id
        //    {
        //        get { return id; }
        //        set { id = value; }
        //    }
        //    public string Name
        //    {
        //        get { return name; }
        //        set { name = value; }
        //    }

        public int Id { get;  set; }
        public string Name { get;  set; }
        public string LastName { get;  set; }
        public string Email { get;  set; }
        public string Address { get;  set; }
        public int Age { get;  set; }
        public bool IsFavorite { get;  set; }
        
        public void SetAsFavorite()
        {
            AddAsFavorite();
        }
        // public string FullName2() => $"{Name} {LastName}";
        public string FullName() => GetFullName();

        public Contact CreateContactInstance(int id, string name, string lastname, string email, string address, int age, bool isFavorite)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Email = email;
            Address = address;
            Age = age;
            IsFavorite = isFavorite;
            return this;
        }
        private string GetFullName()
        {
            //var fullname = $"{Name} {LastName}";
            //return fullname;
            return $"{Name} {LastName}";
        }

        private void AddAsFavorite()
        {
            IsFavorite = true;
        }
    }
}
