using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonitorApplication.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MetaDatas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checksum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExtractTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileSizeInBytes = table.Column<long>(type: "bigint", nullable: false),
                    Script = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientVersion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetaDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonitorApps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonitorApps", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetaDatas");

            migrationBuilder.DropTable(
                name: "MonitorApps");
        }
    }
}
