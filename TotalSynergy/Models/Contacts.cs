using System.ComponentModel.DataAnnotations;


namespace TotalSynergy.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}