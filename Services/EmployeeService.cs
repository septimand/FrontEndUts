using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using FrontEndUts.Models;

namespace FrontEndUts.Services
{
    public class EmployeeService : IdEmployeeService
    {
        private HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
           _httpClient = httpClient;
        }
        public Task<Employee> Add(Employee Employee)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
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

        public async Task<Employee> Update(int id, Employee Employee)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Employees/{id}", Employee);
            if(response.IsSuccessStatusCode){
                return await JsonSerializer.DeserializeAsync<Employee>(await response.Content.ReadAsStreamAsync());
            }
            else {
                throw new Exception("Gagal update Employee");
            }
        }
    }
}

        