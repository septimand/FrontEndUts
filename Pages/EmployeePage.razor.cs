using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndUts.Models;
using FrontEndUts.Services;
using Microsoft.AspNetCore.Components;

namespace FrontEndUts.Pages
{
    public partial class EmployeePage
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        
        [Inject]
        public IdEmployeeService EmployeeService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAll()).ToList();
        }
    }
}