using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSurvey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(6232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 85, DateTimeKind.Local).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.AddColumn<string>(
                name: "Choice5",
                table: "Choices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Choice5",
                table: "Choices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(3487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(8044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(1280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 85, DateTimeKind.Local).AddTicks(8017));
        }
    }
}
