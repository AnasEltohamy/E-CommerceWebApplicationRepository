using AutoMapper;
using Company.DaL.Models;
using CompanyProject.PL.View_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyProject.PL.Controllers
{
	[Authorize]
	public class UserController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(UserManager<ApplicationUser> userManager,IMapper mapper)
        {
			_userManager = userManager;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchValue )
		{
            if (string.IsNullOrEmpty(SearchValue))
            {
                var User = await _userManager.Users.Select(u => new UserViewModel()
                {
                    Id = u.Id,
                    Fname = u.FName,
                    Lname = u.LName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Roles = _userManager.GetRolesAsync(u).Result
                }).ToListAsync();
                return View(User);

            }
            else
            {
                var user = await _userManager.FindByEmailAsync(SearchValue);
                if (user != null)
                {
                    var mappedUser = new UserViewModel()
                    {
                        Id = user.Id,
                        Fname = user.FName,
                        Lname = user.LName,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        Roles = _userManager.GetRolesAsync(user).Result
                    };
                    return View(new List<UserViewModel> { mappedUser });
                }
                else
                {
                    // Handle case when user is not found
                    ModelState.AddModelError(string.Empty, "User not found.");
                    return View(new List<UserViewModel>());
                }

            }
        }
			
		
		public async Task<IActionResult> Details(string Id, string ViewName="Details")
		{
			if (Id is null)
				return BadRequest();
			var User= await _userManager.FindByIdAsync(Id);
			if (User is null)
				return NotFound();
			var MappedUser= _mapper.Map<ApplicationUser,UserViewModel>(User);
			return View(ViewName, MappedUser);
		}
		public async Task<IActionResult> Edit(string Id)
		{
			return await Details(Id, "Edit");
		}
		[HttpPost]
		public async Task<IActionResult> Edit(UserViewModel model, [FromRoute] string id)
		{
			if(id!=model.Id)
				return BadRequest();
			if(ModelState.IsValid) 
			{
				try 
				{
					var User = await _userManager.FindByIdAsync(id);
					User.PhoneNumber = model.PhoneNumber;
					User.FName = model.Fname;
					User.LName = model.Lname;
					await _userManager.UpdateAsync(User);
					return RedirectToAction(nameof(Index));
				}
				catch(Exception ex) 
				{
				ModelState.AddModelError(string.Empty, ex.Message);
				}
			}
			return View(model);
		}
		public async Task<IActionResult> Delete(string id)
		{
			return await Details(id, "Delete");
		}
		[HttpPost]
		public async Task<IActionResult> ConfirmDelete(string id)
		{
			try
			{
				var User= await _userManager.FindByIdAsync(id);
				await _userManager.DeleteAsync(User);
				return RedirectToAction(nameof(Index));
			}
			catch(Exception ex) 
			{
				ModelState.AddModelError(string.Empty,ex.Message);
				return RedirectToAction("Error", "Home");
			
			}
		}

	}
}
