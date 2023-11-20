using BuilderPattern.Enums;

namespace BuilderPattern.Entities
{
    internal sealed class Story
    {
        public int Number;
        public Color Color;

        public Story(int number, Color color)
        {
            Number = number;
            Color = color;
        }
    }
}