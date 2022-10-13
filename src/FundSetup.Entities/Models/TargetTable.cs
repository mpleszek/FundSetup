using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundSetup.Entities.Models
{
    public class TargetTable : AuditableEntity
    {
        public TargetTable()
        {
            AttributeTargetTables = new HashSet<AttributeTargetTable>();
        }
        public int TargetTableId { get; set; }

        public int  ServerId { get; set; } 

        public string PrimaryKeyColumns { get; set; } = string.Empty;

        public string UpdatableColumns { get; set; } = string.Empty;

        public string TableName { get; set; } = string.Empty;

        public int? ApplyOrder { get; set; } 

        public virtual ICollection<AttributeTargetTable> AttributeTargetTables { get; private set; }

        public virtual Server Server { get; set; } = null!;

    }   
}
