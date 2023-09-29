using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Survey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 953, DateTimeKind.Local).AddTicks(96),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(8647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(7400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(7596));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(5843),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.CreateTable(
                name: "ChoiceQuestion",
                columns: table => new
                {
                    ChoicesId = table.Column<int>(type: "int", nullable: false),
                    QuestionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChoiceQuestion", x => new { x.ChoicesId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_ChoiceQuestion_Choices_ChoicesId",
                        column: x => x.ChoicesId,
                        principalTable: "Choices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChoiceQuestion_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChoiceQuestion_QuestionsId",
                table: "ChoiceQuestion",
                column: "QuestionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChoiceQuestion");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 953, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(8804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(7596),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 29, 10, 27, 34, 312, DateTimeKind.Local).AddTicks(5937),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 29, 10, 39, 52, 952, DateTimeKind.Local).AddTicks(5843));
        }
    }
}
