namespace FundSetup.Entities.Models
{
    public abstract class AuditableEntity
    {

        public DateTimeOffset LastChangedAt { get; set; }

        public string LastChangedBy { get; set; } = string.Empty;
    }
}