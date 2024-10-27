using System.ComponentModel.DataAnnotations;

namespace DrTFlower.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}