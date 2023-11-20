using System;
using System.Linq;
using BuilderPattern.Entities;
using System.Collections.Generic;

namespace BuilderPattern.Builder
{
    internal sealed class MultiStoryHouseBuilder : IHouseBuilder
    {
        private House House { get; set; }
        private IEnumerable<Story> Stories { get; }

        public MultiStoryHouseBuilder(IEnumerable<Story> stories)
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
            House.Foundation = House.Foundation = $"This is the strong foundation of the {Stories.Count()} stories house"; ;
            return this;
        }

        public IHouseBuilder AddStructure()
        {
            var storiesDescription = string.Join(" - ",
                Stories.Select(story =>
                    $"Story: {story.Number} - Color: {story.Color:G}"));

            House.Structure = $"The house has {Stories.Count()} stories and they've the following description: {storiesDescription}";

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