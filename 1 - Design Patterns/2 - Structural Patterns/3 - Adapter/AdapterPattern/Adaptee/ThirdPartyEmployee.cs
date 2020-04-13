using System.Collections.Generic;

namespace AdapterPattern.Adaptee
{
    /// <summary>
    /// Class that we want to adapt/wrap, so our code doesn't depend on its behaviour.
    /// </summary>
    internal sealed class ThirdPartyEmployee
    {
        public List<string> RetrieveEmployees =>
            new List<string>
            {
                "Lisber",
                "Jose",
                "Jhon",
                "Steve"
            };
    }
}