using System.ComponentModel.DataAnnotations;
using TaskOne.Data;

namespace TaskOne.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        public string Option { get; set; }
    }
}
