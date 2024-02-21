using System.ComponentModel.DataAnnotations;

namespace AgricultureUIPresentation.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Başlık boş geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel boş geçilemez")]
        public string Image { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama satırı boş geçilemez")]
        public string Description { get; set; }

        [Display(Name = "Renk")]
        [Required(ErrorMessage = "Renk boş geçilemez")]
        public string Color { get; set; }

        [Display(Name = "Sınıf")]
        [Required(ErrorMessage = "Sınıf boş geçilemez")]
        public string Class { get; set; }
    }
}
