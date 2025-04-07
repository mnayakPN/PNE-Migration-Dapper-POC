using Dapper;
using PNE_Migration_Dapper_POC.Models;
using System.Data;

namespace PNE_Migration_Dapper_POC.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDbConnection _context;

        public CustomerRepository(IDbConnection context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {            
            return await _context.QueryAsync<Customer>("SELECT * FROM dbo.Customers");
        }

        public async Task<Customer?> GetCustomerByIdAsync(int id)
        {
            return await _context.QueryFirstOrDefaultAsync<Customer>("SELECT * FROM dbo.Customers WHERE Id = @Id", new { Id = id });
        }

        public async Task AddCustomerAsync(Customer customer)
        {            
            await _context.ExecuteAsync(DBQueryContantsHelpers.insertCustomerSql, customer);
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            await _context.ExecuteAsync(DBQueryContantsHelpers.updateCustomerSql, customer );

        }

        public async Task DeleteCustomerAsync(int id)
        {
            await _context.ExecuteAsync(DBQueryContantsHelpers.deleteCustomerSql, new { Id = id });
            
        }
    }
}
