using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class MenuForm : Form
    {

        public MenuForm(string token, string name)
        {
            InitializeComponent();
            MaximizeBox = false;
            AdminNameLabel.Text = name;
            enableViewEmployees();

        }

        private void enableViewEmployees()
        {
            AddEmployeePanel.Visible = false;
            SearchEmployeePanel.Visible = false;
            RemoveEmployeePanel.Visible = false;
            ViewEmployeesDataGrid.Visible = true;
            using (ManagementSystemContext ctx = new ManagementSystemContext())
            {
                List<Employee> employees = ctx.Employees.ToList();

                ViewEmployeesDataGrid.Columns.Clear();
                ViewEmployeesDataGrid.Columns.Add("Id", "Id");
                ViewEmployeesDataGrid.Columns.Add("Name", "Name");
                ViewEmployeesDataGrid.Columns.Add("Role", "Role");
                ViewEmployeesDataGrid.Columns.Add("Email", "Email");
                ViewEmployeesDataGrid.Columns.Add("Salary", "Salary");

                foreach (Employee employee in employees)
                {
                    ViewEmployeesDataGrid.Rows.Add(employee.Id, employee.Name, employee.Role, employee.Email, employee.Salary);
                }
            }
        }

        private void ViewEmployeesBtn_Click(object sender, EventArgs e)
        {
            enableViewEmployees();
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            ViewEmployeesDataGrid.Visible = false;
            SearchEmployeePanel.Visible = false;
            RemoveEmployeePanel.Visible = false;
            AddEmployeePanel.Visible = true;
        }

        private void RemoveEmployeeBtn_Click(object sender, EventArgs e)
        {
            ViewEmployeesDataGrid.Visible = false;
            AddEmployeePanel.Visible = false;
            SearchEmployeePanel.Visible = false;
            RemoveEmployeePanel.Visible = true;
        }

        private void SearchEmployeeBtn_Click(object sender, EventArgs e)
        {
            ViewEmployeesDataGrid.Visible = false;
            AddEmployeePanel.Visible = false;
            RemoveEmployeePanel.Visible = false;
            SearchEmployeePanel.Visible = true;
        }

        private void AddEmployeeSubmitBtn_Click(object sender, EventArgs e)
        {
            string name = EmployeeNameTB.Text;
            string role = EmployeeRoleTB.Text;
            string email = EmployeeEmailTB.Text;
            string salaryText = EmployeeSalaryTB.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please enter a valid role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(salaryText, out int salary))
            {
                MessageBox.Show("Please enter a valid salary (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ManagementSystemContext ctx = new ManagementSystemContext())
            {
                Employee newEmployee = new Employee
                {
                    Name = name,
                    Role = role,
                    Email = email,
                    Salary = salary
                };
                ctx.Employees.Add(newEmployee);
                ctx.SaveChanges();

                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void RemoveEmployeeSubmitBtn_Click(object sender, EventArgs e)
        {
            string idText = RemoveEmployeeIdTB.Text;

            if (!int.TryParse(idText, out int employeeId))
            {
                MessageBox.Show("Please enter a valid employee ID (numeric value).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ManagementSystemContext ctx = new ManagementSystemContext())
            {
                Employee employeeToRemove = ctx.Employees.Find(employeeId);

                if (employeeToRemove == null)
                {
                    MessageBox.Show($"Employee with ID {employeeId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ctx.Employees.Remove(employeeToRemove);
                ctx.SaveChanges();

                MessageBox.Show($"Employee with ID {employeeId} removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchName = EnterEmployeeNameTB.Text;

            if (string.IsNullOrWhiteSpace(searchName))
            {
                MessageBox.Show("Please enter a valid name for the search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (ManagementSystemContext ctx = new ManagementSystemContext())
            {
                List<Employee> matchingEmployees = ctx.Employees.Where(emp => emp.Name.Contains(searchName)).ToList();

                if (matchingEmployees.Count > 0)
                {
                    Employee firstMatchingEmployee = matchingEmployees.First();

                    EmployeeIdSearchTB.Text = firstMatchingEmployee.Id.ToString();
                    EmployeeRoleSearchTB.Text = firstMatchingEmployee.Role;
                    EmployeeEmailSearchTB.Text = firstMatchingEmployee.Email;
                    EmployeeSalarySearchTB.Text = firstMatchingEmployee.Salary.ToString();
                }
                else
                {
                    MessageBox.Show($"No employees found with the name '{searchName}'.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EmployeeIdSearchTB.Clear();
                    EmployeeRoleSearchTB.Clear();
                    EmployeeEmailSearchTB.Clear();
                    EmployeeSalarySearchTB.Clear();
                }
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.Show();
        }

    }
}
