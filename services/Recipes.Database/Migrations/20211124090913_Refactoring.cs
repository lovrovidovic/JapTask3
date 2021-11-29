using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes.Database.Migrations
{
    public partial class Refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Recipes",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_UserId",
                table: "Recipes",
                newName: "IX_Recipes_CreatedBy");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Users",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Recipes",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ingredients",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Ingredients",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Ingredients",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "UnitPrice",
                table: "Ingredients",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.000736f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.0006866667f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.022f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.01f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.02f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.0348f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 0.0012f });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModifiedAt",
                value: new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModifiedAt",
                value: new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModifiedAt",
                value: new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedBy", "ModifiedAt" },
                values: new object[] { 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                column: "ModifiedAt",
                value: new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                column: "ModifiedAt",
                value: new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_CreatedBy",
                table: "Recipes",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Users_CreatedBy",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Recipes",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Recipes_CreatedBy",
                table: "Recipes",
                newName: "IX_Recipes_UserId");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: 2);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Users_UserId",
                table: "Recipes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
