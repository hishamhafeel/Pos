using System.ComponentModel.DataAnnotations;

namespace Pos.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}