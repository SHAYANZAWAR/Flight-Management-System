using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aviate.Migrations
{
    /// <inheritdoc />
    public partial class NotificationContextMig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        ,
                    TableName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Action = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    processed = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    Row_Id = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    AlteringRows = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");
        }
    }
}
