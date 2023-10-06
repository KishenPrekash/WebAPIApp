using System.ComponentModel.DataAnnotations;

namespace CRUDWebAPI.Models
{
    public class PersonDetails
    {
        [Key]
        public int id { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
        public string? skillSet { get; set; }
        public string? hobby { get; set; }


    
    }
}
