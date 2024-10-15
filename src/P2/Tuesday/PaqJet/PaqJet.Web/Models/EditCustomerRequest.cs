namespace PaqJet.Web.Models
{
    public class EditCustomerRequest : CustomerViewModel
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public char Sex { get; set; }
        //public bool IsActive { get; set; }

        public List<string> InactiveAccounts()
        {

            return new List<string>();
        }
    }
}
