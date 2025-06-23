using Company.DaL.Models;
using CompanyProject.PL.Helpers;
using CompanyProject.PL.View_Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CompanyProject.PL.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;

		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
			_userManager = userManager;
			_signInManager = signInManager;
		}
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model) 
        {
            if(ModelState.IsValid) 
            {
                var User = new ApplicationUser() 
                {
                Email= model.Email,
                UserName = model.Email.Split('@')[0],
                FName=model.FName,
                LName=model.LName,
                IsAgree=model.IsAgree
                
                };
                var Result=await _userManager.CreateAsync(User,model.Password);
                if(Result.Succeeded) 
                return RedirectToAction(nameof(Login));
                foreach(var error  in Result.Errors) 
                {
                ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        return View (model);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var User=await _userManager.FindByEmailAsync(model.Email);
                if (User is not null)
                {
                    var flag = await _userManager.CheckPasswordAsync(User, model.Password);
                    if (flag) 
                    {
                        var Result = await _signInManager.PasswordSignInAsync(User, model.Password, model.RememberMe, false);
                        if(Result.Succeeded)
                            return RedirectToAction("Index","Home");
                    }
                    ModelState.AddModelError(string.Empty, "Password Is Invalid");
                }
                ModelState.AddModelError(string.Empty, "Email Is Invalid");
                

            }
            return View(model);
        }
        public new async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult ForgetPassword() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(ForgetPasswordViewModel model)
        {
            if(ModelState.IsValid) 
            {
                var User = await _userManager.FindByEmailAsync(model.Email);
                if(User is not null) 
                {
                    var token=await _userManager.GeneratePasswordResetTokenAsync(User);
                    var ResetPasswordLink = Url.Action("ResetPassword", "Account", new {email= User.Email, Token=token},Request.Scheme);
                    var email = new Email() 
                    {
                    Subject="ResetPassword",
                    To=model.Email,
                    Body=ResetPasswordLink
                    
                    };
                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckyourInbox));
                }
                else 
                {
                    ModelState.AddModelError(string.Empty, "Email is not Exists");
                
                }
            }
             
            
                return View("ForgetPassword", model);
            
        }
        public IActionResult CheckyourInbox() 
        {
            return View();
        }
        public IActionResult ResetPassword(string email,string token)
        {
            TempData["email"]=email;
            TempData["token"]=token;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (ModelState.IsValid) 
            {
            string email = TempData["email"]as string;
            string token = TempData["token"] as string;
            var User= await _userManager.FindByEmailAsync(email);
            var Result = await _userManager.ResetPasswordAsync(User, token, model.NewPassword);
                if (Result.Succeeded)
                    return RedirectToAction(nameof(Login));
                else
                    foreach(var error  in Result.Errors)
                        ModelState.AddModelError(string.Empty,error.Description);
            }
            return View(model);
        }
        

       

    }
}
