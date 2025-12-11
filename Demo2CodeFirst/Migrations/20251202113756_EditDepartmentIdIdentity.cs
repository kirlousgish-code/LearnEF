using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo2CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class EditDepartmentIdIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1) Drop Foreign Key
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DeptNo",
                table: "Students");

            // 2) Drop Primary Key (لان العمود جزء منه)
            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            // 3) Drop column DepartmentId بالكامل
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Departments");

            // 4) Create column again WITHOUT identity
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Departments",
                type: "int",
                nullable: false);

            // 5) Add PK again
            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "DepartmentId");

            // 6) Add Foreign Key again
            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DeptNo",
                table: "Students",
                column: "DeptNo",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");
        }
    }
}
