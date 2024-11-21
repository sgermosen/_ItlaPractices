namespace ExpressTaste.API.Dtos
{
    public class CreateCustomerRequest
    {  
        public string Name { get; set; }

        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public bool IsActive { get; set; }

        public char Gender { get; set; }
    }
}
