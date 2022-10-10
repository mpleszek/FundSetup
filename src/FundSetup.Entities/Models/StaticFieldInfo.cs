using Microsoft.EntityFrameworkCore;

namespace FundSetup.Entities.Models
{
    [Keyless]
    public class StaticFieldInfo
    {
        public string Entity { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

    }
}
