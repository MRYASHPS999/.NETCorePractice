using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMSDotNetCoreMiniProject.Migrations
{
    /// <inheritdoc />
    public partial class filesection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "documents",
                columns: table => new
                {
                    fileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    filename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    filepath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadedby = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadedon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documents", x => x.fileId);
                    table.ForeignKey(
                        name: "FK_documents_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "employees",
                        principalColumn: "empid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_documents_EmployeeId",
                table: "documents",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "documents");
        }
    }
}
