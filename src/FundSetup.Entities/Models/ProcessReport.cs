namespace FundSetup.Entities.Models
{
    public class ProcessReport : AuditableEntity
    {
        public int Id { get; set; }

        public int ProcessId { get; set; }

        public string ReportContent { get; set; } = string.Empty;   

        public DateTime ReferenceDate { get; set; } = DateTime.Now;

        public bool? IsActive { get; set; }

        public virtual ProcessInfo ProcessInfo { get; set; } = null!;  
    }
}
