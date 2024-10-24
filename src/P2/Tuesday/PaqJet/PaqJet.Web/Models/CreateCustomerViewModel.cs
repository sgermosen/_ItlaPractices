namespace PaqJet.Web.Models
{
    public class CreateCustomerViewModel : CustomerViewModel
    {
        public string Header { get; set; }

        //public string Name { get; set; }
        //public string LastName { get; set; }
        //public int Age { get; set; }
        //public char Sex { get; set; }
        //public bool IsActive { get; set; }
        // public List<Custumer> Customers { get; set; }

        public bool ValidateDni()
        {
            //request to the junta central electoral api
            return true;
        }
    }
}
