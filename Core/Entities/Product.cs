namespace Core.Entities
{
    public class Product: BaseEntity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Rate { get; private set; }


        public Product(string name, string description, int rate)
        {
            Id = new System.Guid();
            Name = name;
            Description = description;
            Rate = rate;
        }
    }
}