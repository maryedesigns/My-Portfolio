using System.ComponentModel.DataAnnotations;

namespace maryedesigns.ViewModel
{
    public class ForgotPasswordViewModel
    {

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
