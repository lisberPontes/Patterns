using System.Collections.Generic;

namespace AdapterPattern
{
    /// <summary>
    /// 'Internal' interface throught our application
    /// </summary>
    internal interface IEmployeeTarget
    {
        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> GetEmployees();
    }
}