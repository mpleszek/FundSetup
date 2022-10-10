namespace FundSetup.Entities.Models
{
    public class AttributeValueAudit : AuditableEntity
    {
        public int Id { get; set; }

        public int AttributeId { get; set; }

        public string Value { get; set; } = string.Empty;

        public string PreviousValue { get; set; } = string.Empty;

    }
}
