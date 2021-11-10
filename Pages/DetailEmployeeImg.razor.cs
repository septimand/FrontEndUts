using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndUts.Models;
using FrontEndUts.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace FrontEndUts.Pages
{
    public partial class DetailEmployeeImg
    {
        [Parameter]
        public string id { get; set; }
        [Inject]
        public IdEmployeeService EmployeeService { get; set; }

        public Employee Employee { get; set; } = new Employee();

        public string Coordinates { get; set;}

        public string ButtonText { get; set; } = "Hide Footer";

        public string CssClass { get; set; } = null;

        protected void Button_Click(){
            if(ButtonText == "Hide Footer"){
                CssClass = "HideFooter";
                ButtonText = "Show Footer";
                
            }else{
                CssClass =null;
                ButtonText = "Hide Footer";
            }
        }

        protected void Mouse_Move(MouseEventArgs e){
            Coordinates = $"X = {e.ClientX}, Y= {e.ClientY}";
        }
        protected override async Task OnInitializedAsync()
        {
            id = id ?? "1";
            Employee = await EmployeeService.GetById(int.Parse(id));
        }
    }
}