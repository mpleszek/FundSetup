namespace FundSetup.Entities.Models
{
    public class Attribute
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string AttributeType { get; set; } = string.Empty;

        public string Internal { get; set; } = string.Empty;

        public string ValidationRule { get; set; } = string.Empty;

    }
}
