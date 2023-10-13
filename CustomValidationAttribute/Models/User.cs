using CustomValidationAttribute.Utility;
using System.ComponentModel.DataAnnotations;

namespace CustomValidationAttribute.Models
{
    public class User
    {
        public string Name { get; set; }
       [AllowedExtensions(new string[] { ".jpg", ".png", ".jpeg" })]
        public IFormFile? Image { get; set; }
    }
}
