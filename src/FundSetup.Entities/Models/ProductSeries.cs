namespace FundSetup.Entities.Models
{
    public class ProductSeries
    {
        public ProductSeries()
        {
            AttributeValues = new HashSet<AttributeValue>();            
        }
        public int Id { get; set; }

        public virtual Product Product { get; set; } = null!;

        public virtual Series Series { get; set; } = null!;

        public virtual ICollection<AttributeValue> AttributeValues { get; private set; }

    }
}
