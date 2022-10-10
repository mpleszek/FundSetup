namespace FundSetup.Entities.Models
{
    public class AttributeValue
    {
        public int Id { get; set; }

        public virtual Attribute Attribute { get; set; } = null!;

        public string Value { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public DateTimeOffset LastUpdated { get; set; } = DateTimeOffset.Now;

        public string PreviousValue { get; set; } = string.Empty;
    }
}
