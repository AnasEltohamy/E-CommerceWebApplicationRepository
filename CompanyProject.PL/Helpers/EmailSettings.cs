using Company.DaL.Models;
using System.Net;
using System.Net.Mail;

namespace CompanyProject.PL.Helpers
{
	public static class EmailSettings
	{
		public static void SendEmail(Email email)
		{
			var Client = new SmtpClient("smtp.gmail.com", 587);
			Client.EnableSsl = true;
			Client.Credentials = new NetworkCredential("mohamedahmedgjfd@gmail.com", "injmxpqxbmdbemuz");
			Client.Send("mohamedahmedjgfd@gmail.com", email.To, email.Subject, email.Body);
		}
	}
}
