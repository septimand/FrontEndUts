using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEndUts.Models;

namespace FrontEndUts.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetAll();
        Task<Department> GetById(int id);
    }
}