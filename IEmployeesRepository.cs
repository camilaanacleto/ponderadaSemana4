using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaTi.Dashboard.Repository
{
    public interface IEmployeesRepository
    {
        Task<IEnumerable<EmployeeModel>> GetEmployees();
        Task<EmployeeModel> GetEmployeeById(int id); 
    }
}
