using BuilderPattern.Enums;
using BuilderPattern.Entities;
using System.Collections.Generic;

namespace BuilderPatternTester.DummyData
{
    internal static class StoryProvider
    {
        internal static IEnumerable<Story> Stories
        {
            get
            {
                yield return new Story(1, Color.Beige);
                yield return new Story(2, Color.Red);
                yield return new Story(23, Color.Yellow);
            }
        }
    }
}