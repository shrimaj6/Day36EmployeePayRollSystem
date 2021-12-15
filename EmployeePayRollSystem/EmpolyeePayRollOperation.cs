using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollSystem
{
    public class EmployeePayRollOperation
    {
        List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

        public void addEmployeeToPayRoll(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);

            }
                );
            Console.WriteLine(this.employeeDetails.ToString());
        }

        private void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeeDetails.Add(emp);
        }

        public void addEmployeeToPayRollWithThread(List<EmployeeDetails> listemployeeDetails)
        {
            listemployeeDetails.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added: " + employeeData.EmployeeName);
                });
                thread.Start();

            }
                );
            Console.WriteLine(this.employeeDetails.ToString());
        }
    }
}