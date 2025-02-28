using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet basligi giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet basligi en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet aciklamasi giriniz")]
        public string Description { get; set; }
    }
}
