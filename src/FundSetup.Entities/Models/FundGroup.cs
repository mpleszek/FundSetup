namespace FundSetup.Entities.Models
{
    public class FundGroup : AuditableEntity
    {
        public FundGroup()
        {
            Funds = new HashSet<Fund>();
        }
        public int Id { get; set; }

        public string FungGroupName { get; set; } = string.Empty;

        public int DisplayOrder { get; set; }

        public virtual ICollection<Fund> Funds { get; set; }

    }
}
