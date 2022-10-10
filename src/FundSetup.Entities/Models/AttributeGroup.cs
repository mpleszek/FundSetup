namespace FundSetup.Entities.Models
{
    public class AttributeGroup : AuditableEntity
    {
        public AttributeGroup()
        {
            Attributes = new HashSet<Attribute>();
        }
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        
        public int DisplayOrder { get; set; }

        public int GroupOwnerId { get; set; }

        public bool IsBase { get; set; }

        public virtual ICollection<Attribute> Attributes { get; private set; }



    }
}
