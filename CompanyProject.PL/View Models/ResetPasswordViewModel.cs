using System.ComponentModel.DataAnnotations;

namespace CompanyProject.PL.View_Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage ="New Password Is Required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm New Password Is Required")]
        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage ="Password Does not Match")]
        public string ConfirmPassword { get; set;}
    }
}
