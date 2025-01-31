using Microsoft.EntityFrameworkCore;
using SQLViewer.Data;
using SQLViewer.Models;

namespace SQLViewer.Services
{
    public class NorthwindService : INorthwindService
    {
        private readonly NorthwindContext _context;

        public NorthwindService(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees
                .OrderBy(e => e.LastName)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _context.Orders
                .Include(o => o.Employee)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task<List<Order>> GetOrdersByLastNameAsync(string lastName)
        {
            return await _context.Orders
                .Include(o => o.Employee)
                .Where(o => o.Employee.LastName.Equals(lastName))
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();
        }

        public async Task<List<EmployeeFreightSummary>> GetEmployeeFreightSummaryAsync()
        {
            return await _context.Orders
                .GroupBy(o => new {
                    o.Employee.EmployeeId,
                    o.Employee.FirstName,
                    o.Employee.LastName
                })
                .Select(g => new EmployeeFreightSummary
                {
                    FirstName = g.Key.FirstName,
                    LastName = g.Key.LastName,
                    TotalFreight = g.Sum(o => o.Freight ?? 0)
                })
                .OrderByDescending(s => s.TotalFreight)
                .ToListAsync();
        }
    }
}
