using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndUts.Models;
using FrontEndUts.Services;
using Microsoft.AspNetCore.Components;

namespace FrontEndUts.Pages
{
    public partial class DepartmentPage
    {
        public List<Department> Departments  { get; set; } = new List<Department>();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Departments = (await DepartmentService.GetAll()).ToList();
        }
    }
}