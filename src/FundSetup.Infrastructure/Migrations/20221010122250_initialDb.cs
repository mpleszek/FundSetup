using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FundSetup.Infrastructure.Migrations
{
    public partial class initialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttributeValueAudit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValueAudit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FundGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FungGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FundGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupOwner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ADGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupOwner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcessInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CleanUpAfterDays = table.Column<int>(type: "int", nullable: true),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Server",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedServerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Server", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaticFieldInfo",
                columns: table => new
                {
                    Entity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Field = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SystemConfiguration",
                columns: table => new
                {
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsXmlContent = table.Column<bool>(type: "bit", nullable: false),
                    SectionContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidationExpression = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllowConfigInGenericUI = table.Column<bool>(type: "bit", nullable: true),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Fund",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotificationSentAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundGroupId = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fund", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fund_FundGroup_FundGroupId",
                        column: x => x.FundGroupId,
                        principalTable: "FundGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttributeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    GroupOwnerId = table.Column<int>(type: "int", nullable: false),
                    IsBase = table.Column<bool>(type: "bit", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeGroups_GroupOwner_GroupOwnerId",
                        column: x => x.GroupOwnerId,
                        principalTable: "GroupOwner",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcessReport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessId = table.Column<int>(type: "int", nullable: false),
                    ReportContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferenceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ProcessInfoId = table.Column<int>(type: "int", nullable: false),
                    LastChangedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastChangedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessReport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProcessReport_ProcessInfo_ProcessInfoId",
                        column: x => x.ProcessInfoId,
                        principalTable: "ProcessInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSeries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSeries_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSeries_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Internal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidationRule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeGroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attributes_AttributeGroups_AttributeGroupId",
                        column: x => x.AttributeGroupId,
                        principalTable: "AttributeGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PreviousValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FundId = table.Column<int>(type: "int", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductSeriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AttributeValues_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributeValues_Fund_FundId",
                        column: x => x.FundId,
                        principalTable: "Fund",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttributeValues_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AttributeValues_ProductSeries_ProductSeriesId",
                        column: x => x.ProductSeriesId,
                        principalTable: "ProductSeries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttributeGroups_GroupOwnerId",
                table: "AttributeGroups",
                column: "GroupOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Attributes_AttributeGroupId",
                table: "Attributes",
                column: "AttributeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_AttributeId",
                table: "AttributeValues",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_FundId",
                table: "AttributeValues",
                column: "FundId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_ProductId",
                table: "AttributeValues",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValues_ProductSeriesId",
                table: "AttributeValues",
                column: "ProductSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Fund_FundGroupId",
                table: "Fund",
                column: "FundGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcessReport_ProcessInfoId",
                table: "ProcessReport",
                column: "ProcessInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeries_ProductId",
                table: "ProductSeries",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSeries_SeriesId",
                table: "ProductSeries",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttributeValueAudit");

            migrationBuilder.DropTable(
                name: "AttributeValues");

            migrationBuilder.DropTable(
                name: "ProcessReport");

            migrationBuilder.DropTable(
                name: "Server");

            migrationBuilder.DropTable(
                name: "StaticFieldInfo");

            migrationBuilder.DropTable(
                name: "SystemConfiguration");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Fund");

            migrationBuilder.DropTable(
                name: "ProductSeries");

            migrationBuilder.DropTable(
                name: "ProcessInfo");

            migrationBuilder.DropTable(
                name: "AttributeGroups");

            migrationBuilder.DropTable(
                name: "FundGroup");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropTable(
                name: "GroupOwner");
        }
    }
}
