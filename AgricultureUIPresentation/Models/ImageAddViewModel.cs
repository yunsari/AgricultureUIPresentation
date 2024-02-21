using System.ComponentModel.DataAnnotations;

namespace AgricultureUIPresentation.Models
{
    public class ImageAddViewModel
    {
        [Display(Name = "Başlık")]
        [Required(ErrorMessage = "Başlık boş geçilemez")]
        public string Title { get; set; }

        [Display(Name = "Görsel")]
        [Required(ErrorMessage = "Görsel boş geçilemez")]
        public string ImageUrl { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama satırı boş geçilemez")]
        public string Description { get; set; }
    }
}
