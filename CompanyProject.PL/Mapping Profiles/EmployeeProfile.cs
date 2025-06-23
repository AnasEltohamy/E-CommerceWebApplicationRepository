using AutoMapper;
using Company.DaL.Models;
using CompanyProject.PL.View_Models;

namespace CompanyProject.PL.Mapping_Profiles
{
    public class EmployeeProfile:Profile
    {
        public EmployeeProfile()
        {
            CreateMap<EmployeeViewModels, Employee>().ReverseMap();
        }
    }
}
