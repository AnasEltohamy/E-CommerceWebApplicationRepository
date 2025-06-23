using System.ComponentModel.DataAnnotations;

namespace CompanyProject.PL.View_Models
{
	public class RegisterViewModel
	{
		[Required(ErrorMessage ="FirstName is Required")]
		public string FName { get; set; }
		[Required(ErrorMessage = "LastName is Required")]
		public string LName { get; set; }
		[Required(ErrorMessage = "Email is Required")]
		[EmailAddress(ErrorMessage ="Invalid Email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Password is Required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[Required(ErrorMessage = "ConfirmPassword is Required")]
		[Compare("Password",ErrorMessage ="ConfirmPassword does not match Password")]
		[DataType(DataType.Password)]
		public string ConfirmPassword { get; set; }
		public bool IsAgree { get; set; }

	}
}
