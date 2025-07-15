using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMSDotNetCoreMiniProject.Migrations
{
    /// <inheritdoc />
    public partial class createtable1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_managers_departments_deptsdeptid",
                table: "managers");

            migrationBuilder.DropIndex(
                name: "IX_managers_deptsdeptid",
                table: "managers");

            migrationBuilder.DropColumn(
                name: "deptsdeptid",
                table: "managers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "deptsdeptid",
                table: "managers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_managers_deptsdeptid",
                table: "managers",
                column: "deptsdeptid");

            migrationBuilder.AddForeignKey(
                name: "FK_managers_departments_deptsdeptid",
                table: "managers",
                column: "deptsdeptid",
                principalTable: "departments",
                principalColumn: "deptid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
