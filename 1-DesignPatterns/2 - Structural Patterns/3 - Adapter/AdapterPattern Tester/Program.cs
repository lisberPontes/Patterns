using System;
using AdapterPattern;
using AdapterPattern.Adaptee;
using AdapterPatternTester.Clients;

namespace AdapterPatternTester
{
    internal sealed class Program
    {
        static void Main()
        {
            var thirdPartyEmployee = new ThirdPartyEmployee();
            var employeeTarget = new EmployeeAdapter(thirdPartyEmployee);

            var client = new EmployeeClient(employeeTarget);
            var employees = client.GetEmployees();
            client.RenderEmployees(employees);

            Console.ReadLine();
        }
    }
}