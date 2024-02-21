using System.ComponentModel.DataAnnotations;

namespace AgricultureUIPresentation.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adını giriniz!")]
        public string? username { get; set; }

        [Required(ErrorMessage = "Şifreyi giriniz!")]
        public string? password { get; set; }
    }
}
