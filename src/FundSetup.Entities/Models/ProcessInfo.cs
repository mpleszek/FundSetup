namespace FundSetup.Entities.Models
{
    public class ProcessInfo : AuditableEntity
    {
        public ProcessInfo()
        {
            ProcessReport = new HashSet<ProcessReport>();
        }

        public int Id { get; set; }

        public string ProcessDescription { get; set; } = string.Empty;

        public string ProcessComment { get; set; } = string.Empty;

        public int? CleanUpAfterDays { get; set; }

        public virtual ICollection<ProcessReport> ProcessReport { get; set; }


    }
}
