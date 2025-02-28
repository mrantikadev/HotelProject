using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceId { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet basligi giriniz")]
        [StringLength(100, ErrorMessage = "Hizmet basligi en fazla 100 karakter olabilir")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet aciklamasi giriniz")]
        [StringLength(500, ErrorMessage = "Hizmet aciklamasi en fazla 500 karakter olabilir")]
        public string Description { get; set; }
    }
}
