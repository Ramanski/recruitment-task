using System.ComponentModel.DataAnnotations;

namespace MVC.App.Models
{

    public class UserViewModel
    {
        [Required(ErrorMessage = "nicknameRequired", AllowEmptyStrings = false)]
        [RegularExpression(@"^[a-zA-Z]{1,30}$", ErrorMessage = "nicknameInvalid")]
        public string NickName { get; set; }

        [Required(ErrorMessage = "emailRequired")]
        [DataType(DataType.EmailAddress, ErrorMessage = "emailInvalid")]
        public string Email { get; set; }
    }
}