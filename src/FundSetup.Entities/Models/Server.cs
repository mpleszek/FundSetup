namespace FundSetup.Entities.Models
{
    public class Server : AuditableEntity
    {
        public Server()
        {
           
        }
        public int Id { get; set; }        

        public string ServerName { get; set; } = string.Empty;

        public string LinkedServerName { get; set; } = string.Empty;
        
    }
}
