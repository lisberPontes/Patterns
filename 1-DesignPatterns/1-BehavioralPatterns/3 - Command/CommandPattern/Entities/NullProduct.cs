namespace CommandPattern.Entities
{
    /// <summary>
    /// Null Object Pattern implementation
    /// </summary>
    internal sealed class NullProduct : IProduct
    {
        public int Id
        {
            get => default;
            set { }
        }

        public string Name
        {
            get => string.Empty;
            set { }
        }

        public decimal Price
        {
            get => decimal.Zero;
            set { }
        }
    }
}