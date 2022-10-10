using Microsoft.EntityFrameworkCore;

namespace FundSetup.Entities.Models
{
    [Keyless]
    public class SystemConfiguration : AuditableEntity
    {
        public string SectionName { get; set; } = string.Empty;

        public bool IsXmlContent { get; set; }

        public string SectionContent { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string GroupName { get; set; } = string.Empty;

        public string ValidationExpression { get; set; } = string.Empty;

        public bool? AllowConfigInGenericUI { get; set; }
        
    }
}
