using System;
using System.Linq;
using BuilderPattern.Builder;
using BuilderPattern.Director;
using BuilderPattern.Entities;
using System.Collections.Generic;
using BuilderPatternTester.DummyData;

namespace BuilderPatternTester.ClassicApproach
{
    internal sealed class ClassicBuilderUsage
    {
        public void BuildOneStoryHouse()
        {
            var houseBuilder = new OneStoryHouseBuilder(new List<Story> { StoryProvider.Stories.First() });
            //Step #2 - Pass the concreteBuilder to the 'Director'
            var director = new HouseBuilderDirector(houseBuilder);
            //Step #3 - The Director is going to build the complex object
            director.Make();
            //Step #4 - Ask the director for the complex object that has been built
            var builtHouse = director.BuiltHouse;

            Console.WriteLine(builtHouse.DisplayHouse());
        }

        public void BuildMultiStoryHouse()
        {
            //Step #1 - Create a concreteBuilder
            var houseBuilder = new MultiStoryHouseBuilder(StoryProvider.Stories);
            //Step #2 - Pass the concreteBuilder to the 'Director'
            var director = new HouseBuilderDirector(houseBuilder);
            //Step #3 - The Director is going to build the complex object
            director.Make();
            //Step #4 - Ask the director for the complex object that has been built
            var builtHouse = director.BuiltHouse;

            Console.WriteLine(builtHouse.DisplayHouse());
        }
    }
}