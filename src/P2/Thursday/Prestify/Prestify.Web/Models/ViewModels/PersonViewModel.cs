namespace Prestify.Web.Models.ViewModels
{
    public class PersonViewModel
    {
        public string? Dni { get; set; }
        public string? Name { get; set; }
        public string LastNames { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool Deleted { get; set; }
    }
}
