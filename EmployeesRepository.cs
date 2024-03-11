using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaTi.Dashboard.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
        private readonly string _dbConfig; 

        public EmployeesRepository(string dbConfig)
        {
            _dbConfig = dbConfig;
        }

        public Task<EmployeeModel> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeModel>> GetEmployees()
        {
            using (var conn = new NpgsqlConnection(_dbConfig))
            {
                await conn.OpenAsync();
                return await conn.QueryAsync<EmployeeModel>(@"
                    SELECT
                    id,
                    n_pessoal as Npessoal
")
            }
        }
    }
}
