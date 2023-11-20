using AdapterPattern.Adaptee;
using System.Collections.Generic;

namespace AdapterPattern
{
    /// <summary>
    /// Concrete implementation of our 'Internal' interface.
    /// </summary>
    /// <seealso cref="AdapterPattern.IEmployeeTarget" />
    internal sealed class EmployeeAdapter : IEmployeeTarget
    {
        private ThirdPartyEmployee ThirdPartyEmployee { get; }

        public EmployeeAdapter(ThirdPartyEmployee thirdPartyEmployee)
        {
            ThirdPartyEmployee = thirdPartyEmployee;
        }

        public IEnumerable<string> GetEmployees()
        {
            return ThirdPartyEmployee.RetrieveEmployees;
        }
    }
}