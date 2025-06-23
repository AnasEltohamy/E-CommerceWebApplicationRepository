using System.Collections.Generic;

namespace CompanyProject.PL.View_Models
{
	public class UserViewModel
	{
		public string Id { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public IEnumerable<string> Roles { get; set; }
	}
}
