using EmployeePayRollSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace EmployeePayrollTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce1", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Bruce2", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Bruce3", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Bruce4", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Bruce5", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Bruce6", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Bruce7", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Bruce8", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Bruce9", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Bruce10", PhoneNumber: "9999999", Address: "xyz", Department: "Hr", Gender: 'M', BasicPay: 3433, Deduction: 544, TaxablePay: 5456, Tax: 4565, NetPay: 5665, City: "bANGLORE", Country: "India"));

            EmployeePayRollOperation employeePayRollOperation = new EmployeePayRollOperation();
            employeePayRollOperation.addEmployeeToPayRoll(employeeDetails);
        }
    }
}