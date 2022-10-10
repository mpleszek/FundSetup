namespace FundSetup.Entities.Models
{
    public class Product
    {
        public Product()
        {
            AttributeValues = new HashSet<AttributeValue>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ProductType { get; set; } = string.Empty;

        public string ProductGroup { get; set; } = string.Empty;

        public DateTimeOffset Date { get; set; } = DateTimeOffset.Now;

        public virtual ICollection<AttributeValue> AttributeValues { get; private set; }    

    }
}
