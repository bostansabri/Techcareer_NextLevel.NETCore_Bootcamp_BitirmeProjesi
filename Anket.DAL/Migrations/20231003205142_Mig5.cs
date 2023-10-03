using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSurvey.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(5453),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(3281),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(1647),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 991, DateTimeKind.Local).AddTicks(9931),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 991, DateTimeKind.Local).AddTicks(7804),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 85, DateTimeKind.Local).AddTicks(8017));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Surveys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(4600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurveyDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 87, DateTimeKind.Local).AddTicks(100),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "SendSurvey",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(6232),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 992, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 86, DateTimeKind.Local).AddTicks(2180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 991, DateTimeKind.Local).AddTicks(9931));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Choices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 3, 14, 5, 39, 85, DateTimeKind.Local).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 10, 3, 23, 51, 41, 991, DateTimeKind.Local).AddTicks(7804));

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
    }
}
