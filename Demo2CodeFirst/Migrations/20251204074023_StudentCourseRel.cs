using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo2CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class StudentCourseRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentCourseRel",
                columns: table => new
                {
                    stdId = table.Column<int>(type: "int", nullable: false),
                    crsId = table.Column<int>(type: "int", nullable: false),
                    degree = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourseRel", x => new { x.stdId, x.crsId });
                    table.ForeignKey(
                        name: "FK_StudentCourseRel_Courses_crsId",
                        column: x => x.crsId,
                        principalTable: "Courses",
                        principalColumn: "crsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourseRel_Students_stdId",
                        column: x => x.stdId,
                        principalTable: "Students",
                        principalColumn: "stdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourseRel_crsId",
                table: "StudentCourseRel",
                column: "crsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentCourseRel");
        }
    }
}
