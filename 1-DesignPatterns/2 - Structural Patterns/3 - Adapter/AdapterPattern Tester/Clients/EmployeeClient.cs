using System;
using AdapterPattern;
using System.Collections.Generic;

namespace AdapterPatternTester.Clients
{
    /// <summary>
    /// Knows nothing about the 'third party' interface.
    /// Knows only about out 'internal' interface.
    /// </summary>
    internal sealed class EmployeeClient
    {
        private IEmployeeTarget EmployeeTarget { get; }

        public EmployeeClient(IEmployeeTarget employeeTarget)
        {
            EmployeeTarget = employeeTarget;
        }

        public IEnumerable<string> GetEmployees()
        {
            return EmployeeTarget.GetEmployees();
        }

        public void RenderEmployees(IEnumerable<string> employees)
        {
            Console.WriteLine("The employees are: ");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}