using System.ComponentModel.DataAnnotations;

namespace Hub.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

    }
}
