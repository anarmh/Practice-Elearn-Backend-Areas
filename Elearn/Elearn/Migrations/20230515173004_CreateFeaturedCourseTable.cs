using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elearn.Migrations
{
    public partial class CreateFeaturedCourseTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeaturedCoursesAuthor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedCoursesAuthor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FeaturedCourses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FeaturedCourseAuthorId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedCourses", x => x.id);
                    table.ForeignKey(
                        name: "FK_FeaturedCourses_FeaturedCoursesAuthor_FeaturedCourseAuthorId",
                        column: x => x.FeaturedCourseAuthorId,
                        principalTable: "FeaturedCoursesAuthor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeaturedCoursesImage",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    FeaturedCourseId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeaturedCoursesImage", x => x.id);
                    table.ForeignKey(
                        name: "FK_FeaturedCoursesImage_FeaturedCourses_FeaturedCourseId",
                        column: x => x.FeaturedCourseId,
                        principalTable: "FeaturedCourses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedCourses_FeaturedCourseAuthorId",
                table: "FeaturedCourses",
                column: "FeaturedCourseAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FeaturedCoursesImage_FeaturedCourseId",
                table: "FeaturedCoursesImage",
                column: "FeaturedCourseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeaturedCoursesImage");

            migrationBuilder.DropTable(
                name: "FeaturedCourses");

            migrationBuilder.DropTable(
                name: "FeaturedCoursesAuthor");
        }
    }
}
