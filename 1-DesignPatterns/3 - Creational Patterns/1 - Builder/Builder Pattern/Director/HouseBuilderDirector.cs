using BuilderPattern.Builder;
using BuilderPattern.Entities;

namespace BuilderPattern.Director
{
    internal sealed class HouseBuilderDirector
    {
        private IHouseBuilder HouseBuilder { get; }

        public HouseBuilderDirector(IHouseBuilder houseBuilder)
        {
            HouseBuilder = houseBuilder;
        }

        public void Make()
        {
            HouseBuilder.AddFoundation();
            HouseBuilder.AddStructure();
            HouseBuilder.AddRoof();
        }

        public House BuiltHouse => HouseBuilder.BuiltHouse;
    }
}