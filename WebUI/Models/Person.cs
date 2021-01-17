using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Display(Name="İsim")]
        [Required(ErrorMessage = "İsim giriniz.")]
        [StringLength(255, ErrorMessage = "{0} alanı en az {2} en fazla {1} olmalıdır.", MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name="Soyisim")]
        [Required(ErrorMessage = "Soyisim giriniz.")]
        [StringLength(255, ErrorMessage = "{0} alanı en az {2} en fazla {1} olmalıdır.", MinimumLength = 2)]
        public string Surname { get; set; }

        [Display(Name="Kan Grubu")]
        [Required(ErrorMessage = "Kan gurubunuzu seçiniz.")]
        public BloodGroup Blood { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Telefon Numarası")]
        [Required(ErrorMessage = "Telefon giriniz.")]
        [StringLength(11, ErrorMessage = "{0} alanı {1} haneli olmalıdır.", MinimumLength = 11)]
        public string PhoneNumber { get; set; }

        [Display(Name="Adres")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Adres giriniz.")]
        [StringLength(2000, ErrorMessage = "{0} alanı en fazla {1} olmalıdır.")]
        public string Address { get; set; }
    }
}
