using System;
using BuilderPattern.Builder;
using BuilderPatternTester.DummyData;

namespace BuilderPatternTester.FluentApproach
{
    /// <summary>
    /// The Fluent Builder approach has no 'Director' so it could be considered not a FULL Builder Design Pattern implementation
    /// </summary>
    internal sealed class FluentBuilderUsage
    {
        public void BuildOneStoryHouse()
        {
            //Step #1 - Create a concrete builder
            var houseBuilder = new OneStoryHouseBuilder(StoryProvider.Stories);

            //Step #2 - Act as a 'Director'
            var builtHouse = houseBuilder
                .AddFoundation()
                .AddStructure()
                .AddRoof()
                .BuiltHouse;

            Console.WriteLine(builtHouse.DisplayHouse());
        }

        public void BuildMultiStoryHouse()
        {
            //Step #1 - Create a concrete builder
            var houseBuilder = new MultiStoryHouseBuilder(StoryProvider.Stories);

            //Step #2 - Act as a 'Director'
            var builtHouse = houseBuilder
                .AddFoundation()
                .AddStructure()
                .AddRoof()
                .BuiltHouse;

            Console.WriteLine(builtHouse.DisplayHouse());
        }
    }
}