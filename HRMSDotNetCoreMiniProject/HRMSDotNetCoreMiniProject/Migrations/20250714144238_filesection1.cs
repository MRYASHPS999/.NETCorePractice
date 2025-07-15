using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMSDotNetCoreMiniProject.Migrations
{
    /// <inheritdoc />
    public partial class filesection1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documents_employees_EmployeeId",
                table: "documents");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "documents",
                newName: "empid");

            migrationBuilder.RenameIndex(
                name: "IX_documents_EmployeeId",
                table: "documents",
                newName: "IX_documents_empid");

            migrationBuilder.AddForeignKey(
                name: "FK_documents_employees_empid",
                table: "documents",
                column: "empid",
                principalTable: "employees",
                principalColumn: "empid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_documents_employees_empid",
                table: "documents");

            migrationBuilder.RenameColumn(
                name: "empid",
                table: "documents",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_documents_empid",
                table: "documents",
                newName: "IX_documents_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_documents_employees_EmployeeId",
                table: "documents",
                column: "EmployeeId",
                principalTable: "employees",
                principalColumn: "empid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
