using SQLViewer.Data;
using SQLViewer.Services;

namespace SQLViewer
{
    public partial class MainForm : Form
    {
        private readonly INorthwindService _northwindService;

        public MainForm()
        {
            InitializeComponent();

            var context = new NorthwindContext();
            _northwindService = new NorthwindService(context);

            btnEmployees.Click += async (s, e) => await LoadEmployees();
            btnOrders.Click += async (s, e) => await LoadOrders();
            btnShowOrdersByLastName.Click += async (s, e) => await LoadOrdersByLastName();
            btnFreightSummary.Click += async (s, e) => await LoadFreightSummary();
        }

        private async Task LoadEmployees()
        {
            try
            {
                UseWaitCursor = true;
                var employees = await _northwindService.GetEmployeesAsync();
                dataGridView.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private async Task LoadOrders()
        {
            try
            {
                UseWaitCursor = true;
                var orders = await _northwindService.GetOrdersAsync();
                dataGridView.DataSource = orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private async Task LoadOrdersByLastName()
        {
            try
            {
                UseWaitCursor = true;
                var ordersByLastName = await _northwindService.GetOrdersByLastNameAsync(textBoxOrdersByLastName.Text);
                dataGridView.DataSource = ordersByLastName;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private async Task LoadFreightSummary()
        {
            try
            {
                UseWaitCursor = true;
                var summary = await _northwindService.GetEmployeeFreightSummaryAsync();
                dataGridView.DataSource = summary;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading freight summary: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }
    }
}
