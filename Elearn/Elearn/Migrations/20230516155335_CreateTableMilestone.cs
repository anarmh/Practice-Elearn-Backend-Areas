using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elearn.Migrations
{
    public partial class CreateTableMilestone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAuthorImage_CourseAuthors_CourseAuthorId",
                table: "CourseAuthorImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAuthorImage",
                table: "CourseAuthorImage");

            migrationBuilder.RenameTable(
                name: "CourseAuthorImage",
                newName: "CourseAuthorImages");

            migrationBuilder.RenameIndex(
                name: "IX_CourseAuthorImage_CourseAuthorId",
                table: "CourseAuthorImages",
                newName: "IX_CourseAuthorImages_CourseAuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAuthorImages",
                table: "CourseAuthorImages",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Milestones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestones", x => x.id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAuthorImages_CourseAuthors_CourseAuthorId",
                table: "CourseAuthorImages",
                column: "CourseAuthorId",
                principalTable: "CourseAuthors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseAuthorImages_CourseAuthors_CourseAuthorId",
                table: "CourseAuthorImages");

            migrationBuilder.DropTable(
                name: "Milestones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseAuthorImages",
                table: "CourseAuthorImages");

            migrationBuilder.RenameTable(
                name: "CourseAuthorImages",
                newName: "CourseAuthorImage");

            migrationBuilder.RenameIndex(
                name: "IX_CourseAuthorImages_CourseAuthorId",
                table: "CourseAuthorImage",
                newName: "IX_CourseAuthorImage_CourseAuthorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseAuthorImage",
                table: "CourseAuthorImage",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseAuthorImage_CourseAuthors_CourseAuthorId",
                table: "CourseAuthorImage",
                column: "CourseAuthorId",
                principalTable: "CourseAuthors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
