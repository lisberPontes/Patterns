namespace Entities.Pizza
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void TurnOff();

        string Name { get; }
    }
}