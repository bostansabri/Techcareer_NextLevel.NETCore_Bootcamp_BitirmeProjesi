using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSurvey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(3487),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(8044),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(3868),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(1280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "AspNetRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_AppUserId",
                table: "AspNetRoles",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_AppUserId",
                table: "AspNetRoles",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoles_AspNetUsers_AppUserId",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoles_AppUserId",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(3678),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(2083),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 813, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 462, DateTimeKind.Local).AddTicks(928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(9765),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 1, 15, 6, 42, 461, DateTimeKind.Local).AddTicks(8239),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 2, 14, 50, 30, 812, DateTimeKind.Local).AddTicks(1280));
        }
    }
}
