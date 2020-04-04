using BuilderPattern.Entities;

namespace BuilderPattern.Builder
{
    /// <summary>
    /// What's required to build a house
    /// </summary>
    internal interface IHouseBuilder
    {
        IHouseBuilder AddFoundation();
        IHouseBuilder AddStructure();
        IHouseBuilder AddRoof();

        House BuiltHouse { get; }
    }
}