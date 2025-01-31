using SQLViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLViewer.Services
{
    public interface INorthwindService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<List<Order>> GetOrdersAsync();
        Task<List<Order>> GetOrdersByLastNameAsync(string lastName);
        Task<List<EmployeeFreightSummary>> GetEmployeeFreightSummaryAsync();
    }
}
