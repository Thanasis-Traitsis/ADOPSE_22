using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamGate.Migrations
{
    public partial class QuickFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Exam",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_Id",
                table: "Exam",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_AspNetUsers_Id",
                table: "Exam",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_AspNetUsers_Id",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_Id",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exam");
        }
    }
}
