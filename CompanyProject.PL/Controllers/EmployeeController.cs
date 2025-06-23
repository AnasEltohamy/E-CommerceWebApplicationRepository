using AutoMapper;
using Company.BLL.Interfaces;
using Company.BLL.Repositories;
using Company.DaL.Models;
using CompanyProject.PL.Helpers;
using CompanyProject.PL.View_Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CompanyProject.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
       
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeController(IMapper mapper,IUnitOfWork unitOfWork)
        {
           
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index(string SearchValue)
        {
            IEnumerable<Employee> employees;
            if(string.IsNullOrEmpty(SearchValue))
            {
                employees= await _unitOfWork.EmployeeRepository.GetAll();
            }
            else
            {
                employees=_unitOfWork.EmployeeRepository.SearchEmployeeByName(SearchValue);
            }
            
          var MappedEmployees = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModels>>(employees);
            return View(MappedEmployees);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            //ViewBag.Departments= _departmentRepository.GetAll();
        return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModels EmployeeVM)
        {
            if (ModelState.IsValid) 
            {
                EmployeeVM.ImageName = DocumentSettings.UploadFile(EmployeeVM.Image, "Images");
                var MappedEmployee = _mapper.Map<EmployeeViewModels, Employee>(EmployeeVM);
            await _unitOfWork.EmployeeRepository.Add(MappedEmployee);
             await _unitOfWork.complete();
                return RedirectToAction(nameof(Index));
            }
            
            return View(EmployeeVM);
        }
        public async Task<IActionResult> Details(int?id,string ViewName="Details")
        {
            if (id is null)
                return BadRequest();
            var employee = await _unitOfWork.EmployeeRepository.GetById(id.Value);
            if(employee is null)
                return NotFound();
            var MappedEmployee=_mapper.Map<Employee,EmployeeViewModels>(employee);
            return View(ViewName,MappedEmployee);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int?id) 
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeViewModels EmployeeVM, [FromRoute] int id)
        {
            if(id!=EmployeeVM.Id)
                return BadRequest();
            if(ModelState.IsValid)
            {
                try
                {
                    var MappedEmployee = _mapper.Map<EmployeeViewModels,Employee>(EmployeeVM);
                    _unitOfWork.EmployeeRepository.Update(MappedEmployee);
                   await _unitOfWork.complete(); 
                    return RedirectToAction(nameof(Index));
                }
                catch (System.Exception ex)
                { 
                ModelState.AddModelError(string.Empty, ex.Message);
                }
                
            }
            return View(EmployeeVM);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id) 
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(EmployeeViewModels EmployeeVM, [FromRoute] int id)
        {
            if (id != EmployeeVM.Id)
                return BadRequest();
            if(ModelState.IsValid) 
            { 
                try
                {
                    var MappedEmployee = _mapper.Map<EmployeeViewModels, Employee>(EmployeeVM);
                    _unitOfWork.EmployeeRepository.Delete(MappedEmployee);
                   await _unitOfWork.complete();
                    return RedirectToAction(nameof(Index));
                }
                catch(System.Exception ex) 
                {
                ModelState.AddModelError(string.Empty,ex.Message);
                }
                
            }
            return View(EmployeeVM);
        }
       
    }
}
