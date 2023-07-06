using System.ComponentModel.DataAnnotations;

namespace Task02.Models
{
    public class CookieDataModel
    {
        [Required]
        public string Value { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }
    }
}
