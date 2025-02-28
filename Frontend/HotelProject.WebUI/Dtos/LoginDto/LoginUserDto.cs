using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Kullanici adi giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Sifre giriniz")]
        public string Password { get; set; }
    }
}
