using System.ComponentModel.DataAnnotations;

namespace AgricultureUIPresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını giriniz!")]
        public string userName{ get; set; }

        [Required(ErrorMessage = "Lütfen mail adresi giriniz!")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifre giriniz!")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz!")]
        [Compare("password",ErrorMessage = "Şifreler aynı değil!")]
        public string passwordConfirm { get; set; }
    }
}
