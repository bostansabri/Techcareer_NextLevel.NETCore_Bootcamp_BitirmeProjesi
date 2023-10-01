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
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(3678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(5718));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(2083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(9765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(5718),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(4314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(3252),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(2117),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 30, 23, 46, 5, 761, DateTimeKind.Local).AddTicks(511),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(8239));
        }
    }
}
