using System.ComponentModel.DataAnnotations;
using TaskOne.Data;

namespace TaskOne.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage =$"{nameof(FirstName)} is required!")]
        [StringLength(30, ErrorMessage = $"{nameof(FirstName)} length must be between 2 and 30", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = $"{nameof(LastName)} is required!")]
        [StringLength(30, ErrorMessage = $"{nameof(LastName)} length must be between 2 and 30", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please select a option!")]
        public string Option { get; set; }
    }
}
