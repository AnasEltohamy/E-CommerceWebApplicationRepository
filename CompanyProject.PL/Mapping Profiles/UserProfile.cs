using AutoMapper;
using Company.DaL.Models;
using CompanyProject.PL.View_Models;
using Microsoft.AspNetCore.Identity;

namespace CompanyProject.PL.Mapping_Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>();
        }
    }
}
