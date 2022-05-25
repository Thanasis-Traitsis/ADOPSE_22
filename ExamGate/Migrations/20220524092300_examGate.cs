using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamGate.Migrations
{
    public partial class examGate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Exam");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SubjectId",
                table: "Exam",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
