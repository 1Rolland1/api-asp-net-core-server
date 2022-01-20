using System.ComponentModel.DataAnnotations;

namespace ApiAspNetCoreServer.DataModel.Enums
{
    public enum Sex
    {
        [Display(Name = "Женский")]
        Female = 1,

        [Display(Name = "Мужской")]
        Male = 2,
    }
}