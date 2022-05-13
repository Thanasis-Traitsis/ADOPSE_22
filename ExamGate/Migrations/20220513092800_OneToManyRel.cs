using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamGate.Migrations
{
    public partial class OneToManyRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_AspNetUsers_Id",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Option_Question_QId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Exam_Id",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "OptionCount",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exam");

            migrationBuilder.RenameColumn(
                name: "QId",
                table: "Option",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Option_QId",
                table: "Option",
                newName: "IX_Option_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Question_QuestionId",
                table: "Option",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Question_QuestionId",
                table: "Option");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "Option",
                newName: "QId");

            migrationBuilder.RenameIndex(
                name: "IX_Option_QuestionId",
                table: "Option",
                newName: "IX_Option_QId");

            migrationBuilder.AddColumn<int>(
                name: "OptionCount",
                table: "Option",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Question_QId",
                table: "Option",
                column: "QId",
                principalTable: "Question",
                principalColumn: "QuestionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
