using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMSDotNetCoreMiniProject.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    deptid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deptname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptstatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.deptid);
                });

            migrationBuilder.CreateTable(
                name: "userdetails",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userrole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userdetails", x => x.userid);
                });

            migrationBuilder.CreateTable(
                name: "managers",
                columns: table => new
                {
                    mgrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mgrname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mgrstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    deptid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managers", x => x.mgrid);
                    table.ForeignKey(
                        name: "FK_managers_departments_deptid",
                        column: x => x.deptid,
                        principalTable: "departments",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    empid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empemail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empsalary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empstatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mgrid = table.Column<int>(type: "int", nullable: false),
                    deptid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.empid);
                    table.ForeignKey(
                        name: "FK_employees_departments_deptid",
                        column: x => x.deptid,
                        principalTable: "departments",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_managers_mgrid",
                        column: x => x.mgrid,
                        principalTable: "managers",
                        principalColumn: "mgrid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_deptid",
                table: "employees",
                column: "deptid");

            migrationBuilder.CreateIndex(
                name: "IX_employees_mgrid",
                table: "employees",
                column: "mgrid");

            migrationBuilder.CreateIndex(
                name: "IX_managers_deptid",
                table: "managers",
                column: "deptid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "userdetails");

            migrationBuilder.DropTable(
                name: "managers");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
