namespace FundSetup.Entities.Models
{
    public class Fund : AuditableEntity
    {
        public Fund()
        {
            AttributeValues = new HashSet<AttributeValue>();
        }
        public int Id { get; set; }

        public DateTime? ChangeDueDate { get; set; }

        public DateTime? NotificationSentAt { get; set; }

        public string Status { get; set; } = string.Empty;

        public int FundGroupId { get; set; }

        public string Comments { get; set; } = string.Empty;

        public virtual ICollection<AttributeValue> AttributeValues { get; private set; }

    }
}
