namespace FundSetup.Entities.Models
{
    public class AttributeTargetTable : AuditableEntity
    {
        public int AttributeId { get; set; }

        public int TargetTableId { get; set; }

        public string PrimaryKeyValues { get; set; } = string.Empty;

        public string TransformationSQLIn { get; set; } = string.Empty;

        public string TransformationSQLOut { get; set; } = string.Empty;

        public string ColumnNameOut { get; set; } = string.Empty;     

        public virtual Attribute Attribute { get; set; } = null!;

        public virtual TargetTable TargetTable { get; set; } = null!;

    }
}
