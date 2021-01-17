using System.ComponentModel.DataAnnotations;

namespace Entities.Enums
{
    public enum BloodGroup
    {
        [Display(Name = "0 Rh +")]
        zeronegative = 1,
        [Display(Name = "0 Rh -")]
        zeropozotive = 2,
        [Display(Name = "A Rh +")]
        anegative = 3,
        [Display(Name = "A Rh -")]
        apozotive = 4,
        [Display(Name = "B Rh +")]
        bnegative = 5,
        [Display(Name = "B Rh -")]
        bpozotive = 6,
        [Display(Name = "AB Rh +")]
        abnegative = 7,
        [Display(Name = "AB Rh -")]
        abpozotive = 8,
    }
}
