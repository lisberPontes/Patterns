using System;
using System.Linq;
using BuilderPattern.Entities;
using System.Collections.Generic;

namespace BuilderPattern.Builder
{
    internal sealed class OneStoryHouseBuilder: IHouseBuilder
    {
        private House House { get; set; }
        private IEnumerable<Story> Stories { get; }

        public OneStoryHouseBuilder(IEnumerable<Story> stories)
        {
            Reset();
            Stories = stories;
        }

        /// <summary>
        /// Resets this instance. Ie, always work with  a new Instance
        /// This is used as a 'defensive' strategy to always have a new Instance.
        /// </summary>
        public void Reset()
        {
            House = new House();
        }

        #region IVehicleSalesReport

        public IHouseBuilder AddFoundation()
        {
            House.Foundation = "This is the strong foundation of the 1 story house";
            return this;
        }

        public IHouseBuilder AddStructure()
        {
            House.Structure = $"The house has 1 story and has the following description: {Stories.First().Color:G}";

            return this;
        }

        public IHouseBuilder AddRoof()
        {
            House.Roof = $"The Roof has been added on {DateTime.UtcNow.ToString("G")}";

            return this;
        }

        public House BuiltHouse
        {
            get
            {
                House finishedHouse = House;
                Reset();

                return finishedHouse;
            }
        }

        #endregion
    }
}