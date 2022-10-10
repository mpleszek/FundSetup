namespace FundSetup.Entities.Models
{
    public class GroupOwner : AuditableEntity
    {
        public GroupOwner()
        {
            AttributeGroups = new HashSet<AttributeGroup>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
       
        public string ADGroupName { get; set; } = string.Empty;

        public virtual ICollection<AttributeGroup> AttributeGroups { get; private set; }
    }


}
