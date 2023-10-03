using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSurvey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(8574),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(7050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(5755),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(4391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(2886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Choices",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Choices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(9701),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(8300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(7256),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(6122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 4, 0, 41, 23, 39, DateTimeKind.Local).AddTicks(4669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 4, 1, 51, 16, 480, DateTimeKind.Local).AddTicks(2886));
        }
    }
}
