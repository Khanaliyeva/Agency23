using System.ComponentModel.DataAnnotations;

namespace Agency23.ViewModels.Account
{
    public class LoginVM
    {
        [Required]
        [MinLength(7)]
        [MaxLength(30)]
        [DataType(DataType.EmailAddress)]
        public string UserNameOrEmail { get; set; }


        [Required]
        [MinLength(6)]
        [MaxLength(12)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
