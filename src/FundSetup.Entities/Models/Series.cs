namespace FundSetup.Entities.Models
{
    public class Series
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Column { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string Version { get; set; } = string.Empty;
    }
}
