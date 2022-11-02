using System.ComponentModel.DataAnnotations;
using TaskOne.Data;

namespace TaskOne.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="This field is required!")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        [StringLength(30)]
        public string LastName { get; set; }

        [Required]
        public string Option { get; set; }
    }
}
