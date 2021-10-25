using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndUts.Models;

namespace FrontEndUts.Services
{
    public interface IdEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> GetById(int id);
    }
}