using AutoMapper;
using CompanyProject.PL.View_Models;
using Microsoft.AspNetCore.Identity;

namespace CompanyProject.PL.Mapping_Profiles
{
    public class RoleProfile:Profile
    {
        public RoleProfile()
        {
            CreateMap<IdentityRole, RoleViewModel>().ForMember(d=>d.RoleName,o=>o.MapFrom(s=>s.Name)).ReverseMap();
        }
    }
}
