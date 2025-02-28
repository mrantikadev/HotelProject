using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage = "Ad alani gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad alani gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Kullanici adi alani gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mail alani gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Sifre alani gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sifre tekrar alani gereklidir")]
        [Compare("Password", ErrorMessage = "Sifreler uyusmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
