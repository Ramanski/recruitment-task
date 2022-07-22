using System.ComponentModel.DataAnnotations;

namespace MVC.App.Models
{

    public class UserViewModel
    {
        [Required(ErrorMessage = "NicknameRequired", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]{1,30}$", ErrorMessage = "NicknameInvalid")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "Email is not valid")]
        [DataType(DataType.EmailAddress, ErrorMessage = "NicknameInvalid")]
        public string Email { get; set; }
    }
}