using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using FrontEndUts.Models;

namespace FrontEndUts.Services
{
    public class EmployeeService : IdEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient){
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            var hasil1 = await _httpClient.GetFromJsonAsync<IEnumerable<Employee>>("/api/Employees");
            return hasil1;
        }

        public async Task<Employee> GetById(int id)
        {
            var hasil = await _httpClient.GetFromJsonAsync<Employee>($"/api/Employees/{id}");
            return hasil;
        }
    }
}