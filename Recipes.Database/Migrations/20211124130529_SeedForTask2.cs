using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipes.Database.Migrations
{
    public partial class SeedForTask2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2017, 8, 20, 13, 57, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 1, 26, 16, 20, 0, 0, DateTimeKind.Unspecified), "Palacinke1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2015, 1, 9, 9, 27, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 10, 26, 1, 59, 0, 0, DateTimeKind.Unspecified), "Waffle2" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2010, 6, 17, 3, 25, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2010, 4, 8, 5, 11, 0, 0, DateTimeKind.Unspecified), "Hamburger3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2021, 3, 26, 23, 27, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2010, 8, 23, 0, 39, 0, 0, DateTimeKind.Unspecified), "Sendvic4" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2017, 3, 25, 7, 58, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 4, 5, 21, 19, 0, 0, DateTimeKind.Unspecified), "Torta5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2015, 5, 22, 19, 21, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 6, 27, 4, 10, 0, 0, DateTimeKind.Unspecified), "Kolac6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2013, 6, 26, 7, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2010, 9, 12, 13, 0, 0, 0, DateTimeKind.Unspecified), "Pita7" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2014, 7, 17, 2, 29, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 4, 27, 19, 23, 0, 0, DateTimeKind.Unspecified), "Pizza8" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2011, 10, 13, 19, 20, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 4, 20, 21, 14, 0, 0, DateTimeKind.Unspecified), "Sladoled9" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2019, 4, 28, 18, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 30, 6, 39, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja10" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2014, 10, 7, 13, 29, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 7, 22, 4, 56, 0, 0, DateTimeKind.Unspecified), "Peciva11" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2013, 5, 5, 3, 2, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 4, 15, 4, 1, 0, 0, DateTimeKind.Unspecified), "Salata12" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 75, new DateTime(2019, 9, 9, 20, 17, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 5, 12, 11, 37, 0, 0, DateTimeKind.Unspecified), "Hamburger75" },
                    { 76, new DateTime(2019, 5, 1, 14, 27, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 4, 19, 16, 21, 0, 0, DateTimeKind.Unspecified), "Sendvic76" },
                    { 77, new DateTime(2016, 8, 14, 3, 7, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 11, 18, 5, 52, 0, 0, DateTimeKind.Unspecified), "Torta77" },
                    { 13, new DateTime(2021, 5, 3, 11, 16, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 8, 8, 15, 53, 0, 0, DateTimeKind.Unspecified), "Palacinke13" },
                    { 79, new DateTime(2020, 8, 22, 9, 13, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 2, 29, 18, 44, 0, 0, DateTimeKind.Unspecified), "Pita79" },
                    { 74, new DateTime(2014, 12, 14, 1, 3, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 7, 28, 8, 10, 0, 0, DateTimeKind.Unspecified), "Waffle74" },
                    { 78, new DateTime(2019, 12, 29, 6, 23, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 1, 15, 20, 53, 0, 0, DateTimeKind.Unspecified), "Kolac78" },
                    { 73, new DateTime(2019, 6, 21, 2, 51, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 3, 30, 13, 50, 0, 0, DateTimeKind.Unspecified), "Palacinke73" },
                    { 66, new DateTime(2017, 1, 29, 5, 52, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2012, 8, 9, 13, 7, 0, 0, DateTimeKind.Unspecified), "Kolac66" },
                    { 71, new DateTime(2018, 5, 30, 0, 33, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 2, 14, 13, 46, 0, 0, DateTimeKind.Unspecified), "Peciva71" },
                    { 70, new DateTime(2014, 12, 20, 7, 31, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 12, 25, 23, 10, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja70" },
                    { 69, new DateTime(2021, 12, 18, 3, 8, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 8, 30, 22, 19, 0, 0, DateTimeKind.Unspecified), "Sladoled69" },
                    { 68, new DateTime(2018, 11, 3, 2, 56, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 9, 8, 21, 18, 0, 0, DateTimeKind.Unspecified), "Pizza68" },
                    { 67, new DateTime(2019, 1, 20, 18, 59, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 4, 3, 20, 33, 0, 0, DateTimeKind.Unspecified), "Pita67" },
                    { 80, new DateTime(2016, 11, 18, 14, 34, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 4, 5, 23, 38, 0, 0, DateTimeKind.Unspecified), "Pizza80" },
                    { 65, new DateTime(2011, 6, 4, 12, 24, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 4, 20, 17, 13, 0, 0, DateTimeKind.Unspecified), "Torta65" },
                    { 72, new DateTime(2016, 11, 24, 9, 21, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 1, 8, 21, 3, 0, 0, DateTimeKind.Unspecified), "Salata72" },
                    { 81, new DateTime(2015, 12, 3, 6, 14, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 10, 13, 15, 29, 0, 0, DateTimeKind.Unspecified), "Sladoled81" },
                    { 89, new DateTime(2021, 9, 11, 8, 6, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 12, 2, 0, 32, 0, 0, DateTimeKind.Unspecified), "Torta89" },
                    { 83, new DateTime(2018, 9, 4, 4, 23, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2012, 1, 16, 16, 3, 0, 0, DateTimeKind.Unspecified), "Peciva83" },
                    { 100, new DateTime(2020, 5, 5, 16, 40, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 6, 5, 10, 47, 0, 0, DateTimeKind.Unspecified), "Sendvic100" },
                    { 99, new DateTime(2012, 2, 13, 11, 28, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 6, 30, 1, 47, 0, 0, DateTimeKind.Unspecified), "Hamburger99" },
                    { 98, new DateTime(2021, 1, 21, 16, 56, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 8, 15, 9, 4, 0, 0, DateTimeKind.Unspecified), "Waffle98" },
                    { 97, new DateTime(2012, 10, 12, 7, 44, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 9, 14, 7, 52, 0, 0, DateTimeKind.Unspecified), "Palacinke97" },
                    { 96, new DateTime(2015, 1, 16, 12, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 10, 20, 8, 23, 0, 0, DateTimeKind.Unspecified), "Salata96" },
                    { 95, new DateTime(2012, 4, 4, 14, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 10, 19, 6, 2, 0, 0, DateTimeKind.Unspecified), "Peciva95" },
                    { 94, new DateTime(2017, 12, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 3, 5, 13, 6, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja94" },
                    { 82, new DateTime(2019, 1, 3, 2, 17, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 5, 26, 7, 34, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja82" },
                    { 93, new DateTime(2021, 12, 19, 2, 46, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2011, 10, 13, 13, 30, 0, 0, DateTimeKind.Unspecified), "Sladoled93" },
                    { 91, new DateTime(2017, 5, 31, 7, 16, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 8, 11, 9, 15, 0, 0, DateTimeKind.Unspecified), "Pita91" },
                    { 90, new DateTime(2016, 11, 24, 9, 3, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 10, 4, 12, 2, 0, 0, DateTimeKind.Unspecified), "Kolac90" },
                    { 64, new DateTime(2016, 3, 6, 17, 25, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 12, 2, 2, 21, 0, 0, DateTimeKind.Unspecified), "Sendvic64" },
                    { 88, new DateTime(2018, 9, 20, 8, 3, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 9, 12, 22, 58, 0, 0, DateTimeKind.Unspecified), "Sendvic88" },
                    { 87, new DateTime(2015, 11, 10, 2, 55, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 3, 21, 12, 23, 0, 0, DateTimeKind.Unspecified), "Hamburger87" },
                    { 86, new DateTime(2020, 4, 2, 3, 49, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 8, 28, 7, 35, 0, 0, DateTimeKind.Unspecified), "Waffle86" },
                    { 85, new DateTime(2020, 2, 22, 18, 29, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 11, 17, 10, 4, 0, 0, DateTimeKind.Unspecified), "Palacinke85" },
                    { 92, new DateTime(2021, 3, 23, 6, 4, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 1, 22, 0, 46, 0, 0, DateTimeKind.Unspecified), "Pizza92" },
                    { 63, new DateTime(2020, 1, 2, 1, 52, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2010, 5, 15, 8, 20, 0, 0, DateTimeKind.Unspecified), "Hamburger63" },
                    { 84, new DateTime(2019, 8, 6, 8, 49, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 5, 27, 17, 11, 0, 0, DateTimeKind.Unspecified), "Salata84" },
                    { 61, new DateTime(2014, 10, 29, 12, 44, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 8, 6, 17, 27, 0, 0, DateTimeKind.Unspecified), "Palacinke61" },
                    { 35, new DateTime(2016, 6, 28, 19, 57, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 11, 26, 19, 31, 0, 0, DateTimeKind.Unspecified), "Peciva35" },
                    { 34, new DateTime(2019, 3, 17, 3, 37, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2011, 9, 25, 4, 55, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja34" },
                    { 33, new DateTime(2018, 4, 2, 3, 2, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2012, 5, 21, 17, 12, 0, 0, DateTimeKind.Unspecified), "Sladoled33" },
                    { 32, new DateTime(2011, 6, 7, 1, 58, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 4, 17, 10, 25, 0, 0, DateTimeKind.Unspecified), "Pizza32" },
                    { 31, new DateTime(2018, 9, 22, 16, 46, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 11, 17, 20, 41, 0, 0, DateTimeKind.Unspecified), "Pita31" },
                    { 30, new DateTime(2016, 6, 22, 14, 43, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 11, 7, 11, 31, 0, 0, DateTimeKind.Unspecified), "Kolac30" },
                    { 29, new DateTime(2012, 9, 23, 13, 18, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 9, 25, 5, 26, 0, 0, DateTimeKind.Unspecified), "Torta29" },
                    { 28, new DateTime(2012, 12, 19, 18, 57, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2014, 1, 30, 9, 0, 0, 0, DateTimeKind.Unspecified), "Sendvic28" },
                    { 27, new DateTime(2015, 6, 10, 21, 41, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 9, 1, 14, 23, 0, 0, DateTimeKind.Unspecified), "Hamburger27" },
                    { 26, new DateTime(2016, 11, 4, 22, 41, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 20, 23, 52, 0, 0, DateTimeKind.Unspecified), "Waffle26" },
                    { 36, new DateTime(2020, 12, 21, 23, 9, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 9, 27, 23, 1, 0, 0, DateTimeKind.Unspecified), "Salata36" },
                    { 25, new DateTime(2014, 10, 19, 11, 58, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 8, 10, 7, 9, 0, 0, DateTimeKind.Unspecified), "Palacinke25" },
                    { 23, new DateTime(2015, 3, 18, 12, 20, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 11, 6, 17, 58, 0, 0, DateTimeKind.Unspecified), "Peciva23" },
                    { 22, new DateTime(2014, 2, 14, 1, 7, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 4, 7, 17, 32, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja22" },
                    { 21, new DateTime(2012, 7, 15, 17, 3, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 7, 23, 4, 48, 0, 0, DateTimeKind.Unspecified), "Sladoled21" },
                    { 20, new DateTime(2010, 2, 12, 15, 12, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2012, 4, 25, 11, 22, 0, 0, DateTimeKind.Unspecified), "Pizza20" },
                    { 19, new DateTime(2017, 5, 5, 20, 14, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 1, 13, 20, 19, 0, 0, DateTimeKind.Unspecified), "Pita19" },
                    { 18, new DateTime(2016, 3, 14, 17, 3, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 8, 19, 6, 57, 0, 0, DateTimeKind.Unspecified), "Kolac18" },
                    { 17, new DateTime(2016, 4, 11, 0, 33, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2011, 10, 3, 2, 16, 0, 0, DateTimeKind.Unspecified), "Torta17" },
                    { 16, new DateTime(2013, 1, 4, 18, 17, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 1, 1, 2, 9, 0, 0, DateTimeKind.Unspecified), "Sendvic16" },
                    { 15, new DateTime(2021, 3, 16, 22, 40, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 12, 6, 21, 32, 0, 0, DateTimeKind.Unspecified), "Hamburger15" },
                    { 14, new DateTime(2013, 7, 15, 12, 25, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2017, 5, 10, 2, 45, 0, 0, DateTimeKind.Unspecified), "Waffle14" },
                    { 62, new DateTime(2012, 12, 11, 21, 36, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 5, 16, 11, 54, 0, 0, DateTimeKind.Unspecified), "Waffle62" },
                    { 37, new DateTime(2015, 3, 9, 6, 1, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 1, 3, 6, 59, 0, 0, DateTimeKind.Unspecified), "Palacinke37" },
                    { 24, new DateTime(2013, 4, 28, 11, 45, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 1, 12, 2, 36, 0, 0, DateTimeKind.Unspecified), "Salata24" },
                    { 39, new DateTime(2021, 6, 6, 3, 49, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 1, 26, 9, 29, 0, 0, DateTimeKind.Unspecified), "Hamburger39" },
                    { 38, new DateTime(2017, 12, 16, 13, 35, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 3, 16, 8, 41, 0, 0, DateTimeKind.Unspecified), "Waffle38" },
                    { 60, new DateTime(2012, 3, 16, 11, 34, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 2, 18, 8, 37, 0, 0, DateTimeKind.Unspecified), "Salata60" },
                    { 59, new DateTime(2011, 4, 29, 5, 54, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 10, 28, 10, 27, 0, 0, DateTimeKind.Unspecified), "Peciva59" },
                    { 58, new DateTime(2020, 7, 26, 7, 23, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 3, 21, 6, 58, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja58" },
                    { 57, new DateTime(2015, 8, 28, 13, 44, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 12, 26, 21, 25, 0, 0, DateTimeKind.Unspecified), "Sladoled57" },
                    { 56, new DateTime(2014, 8, 25, 5, 11, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2016, 8, 27, 3, 48, 0, 0, DateTimeKind.Unspecified), "Pizza56" },
                    { 55, new DateTime(2017, 9, 15, 0, 47, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 10, 4, 10, 15, 0, 0, DateTimeKind.Unspecified), "Pita55" },
                    { 54, new DateTime(2016, 9, 14, 17, 50, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 6, 5, 14, 41, 0, 0, DateTimeKind.Unspecified), "Kolac54" },
                    { 52, new DateTime(2020, 7, 14, 6, 39, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2014, 11, 21, 16, 27, 0, 0, DateTimeKind.Unspecified), "Sendvic52" },
                    { 51, new DateTime(2012, 8, 23, 14, 21, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2011, 8, 5, 6, 49, 0, 0, DateTimeKind.Unspecified), "Hamburger51" },
                    { 50, new DateTime(2021, 1, 4, 14, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 10, 27, 19, 7, 0, 0, DateTimeKind.Unspecified), "Waffle50" },
                    { 49, new DateTime(2014, 2, 16, 2, 49, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 10, 28, 14, 41, 0, 0, DateTimeKind.Unspecified), "Palacinke49" },
                    { 53, new DateTime(2019, 8, 18, 7, 59, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 2, 7, 23, 40, 0, 0, DateTimeKind.Unspecified), "Torta53" },
                    { 41, new DateTime(2015, 4, 13, 4, 8, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 7, 2, 9, 48, 0, 0, DateTimeKind.Unspecified), "Torta41" },
                    { 40, new DateTime(2013, 1, 28, 15, 41, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 6, 25, 17, 17, 0, 0, DateTimeKind.Unspecified), "Sendvic40" },
                    { 42, new DateTime(2012, 7, 22, 14, 46, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 8, 7, 15, 31, 0, 0, DateTimeKind.Unspecified), "Kolac42" },
                    { 48, new DateTime(2015, 8, 2, 18, 35, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 8, 26, 20, 22, 0, 0, DateTimeKind.Unspecified), "Salata48" },
                    { 47, new DateTime(2010, 7, 25, 5, 36, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2018, 4, 6, 3, 40, 0, 0, DateTimeKind.Unspecified), "Peciva47" },
                    { 43, new DateTime(2015, 2, 1, 22, 51, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 2, 12, 18, 24, 0, 0, DateTimeKind.Unspecified), "Pita43" },
                    { 46, new DateTime(2011, 11, 26, 17, 38, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 8, 9, 14, 48, 0, 0, DateTimeKind.Unspecified), "Jela s rostilja46" },
                    { 45, new DateTime(2020, 10, 12, 7, 19, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 2, 14, 8, 2, 0, 0, DateTimeKind.Unspecified), "Sladoled45" },
                    { 44, new DateTime(2019, 7, 23, 4, 28, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2012, 8, 10, 10, 9, 0, 0, DateTimeKind.Unspecified), "Pizza44" }
                });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "UnitPrice" },
                values: new object[] { new DateTime(2019, 8, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 7, 18, 7, 52, 0, 0, DateTimeKind.Unspecified), "Mlijeko1", 21.94f, 9f, 0.0024377778f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2017, 6, 3, 13, 41, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2012, 10, 23, 10, 12, 0, 0, DateTimeKind.Unspecified), "Secer2", 37f, 7f, 0, 0.0052857143f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "UnitPrice" },
                values: new object[] { new DateTime(2019, 2, 8, 7, 48, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 9, 4, 6, 52, 0, 0, DateTimeKind.Unspecified), "Maslac3", 30.14f, 24f, 1.2558333f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2021, 6, 8, 13, 25, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 5, 25, 14, 43, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada4", 39.41f, 30f, 1, 1.3136667f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2019, 2, 26, 21, 49, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 4, 18, 7, 25, 0, 0, DateTimeKind.Unspecified), "Crna cokolada5", 31.75f, 45f, 0, 0.00070555555f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2018, 5, 5, 12, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 9, 21, 8, 40, 0, 0, DateTimeKind.Unspecified), "Jaje6", 5.14f, 29f, 4, 0.17724137f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2021, 4, 5, 9, 41, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 2, 15, 2, 32, 0, 0, DateTimeKind.Unspecified), "Voda7", 36.41f, 40f, 0, 0.00091025f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2011, 11, 6, 16, 22, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 4, 24, 20, 59, 0, 0, DateTimeKind.Unspecified), "Brasno8", 44.55f, 19f, 4, 2.3447368f });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[,]
                {
                    { 81, new DateTime(2013, 3, 25, 4, 11, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 6, 18, 21, 29, 0, 0, DateTimeKind.Unspecified), "Mlijeko81", 2.17f, 31f, 3, 7E-05f },
                    { 80, new DateTime(2015, 5, 11, 0, 5, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 8, 8, 11, 24, 0, 0, DateTimeKind.Unspecified), "Brasno80", 19.12f, 24f, 1, 0.7966667f },
                    { 79, new DateTime(2015, 1, 18, 17, 22, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 7, 7, 11, 56, 0, 0, DateTimeKind.Unspecified), "Voda79", 33.21f, 47f, 2, 0.7065957f },
                    { 78, new DateTime(2021, 4, 21, 13, 38, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 2, 21, 7, 56, 0, 0, DateTimeKind.Unspecified), "Jaje78", 33.6f, 48f, 2, 0.7f },
                    { 77, new DateTime(2015, 12, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2010, 12, 12, 16, 24, 0, 0, DateTimeKind.Unspecified), "Crna cokolada77", 17.35f, 18f, 4, 0.9638889f },
                    { 76, new DateTime(2014, 1, 23, 14, 52, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2014, 7, 7, 4, 13, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada76", 47.84f, 10f, 2, 4.784f },
                    { 75, new DateTime(2019, 7, 21, 12, 57, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 11, 29, 0, 29, 0, 0, DateTimeKind.Unspecified), "Maslac75", 9.32f, 19f, 1, 0.4905263f },
                    { 73, new DateTime(2021, 1, 23, 16, 52, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 3, 28, 9, 54, 0, 0, DateTimeKind.Unspecified), "Mlijeko73", 1.93f, 15f, 0, 0.00012866667f },
                    { 82, new DateTime(2013, 4, 11, 16, 5, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 5, 25, 1, 50, 0, 0, DateTimeKind.Unspecified), "Secer82", 1.32f, 24f, 4, 0.055000003f },
                    { 72, new DateTime(2017, 3, 22, 19, 8, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 3, 12, 23, 35, 0, 0, DateTimeKind.Unspecified), "Brasno72", 31.96f, 47f, 2, 0.68f },
                    { 71, new DateTime(2021, 3, 29, 0, 5, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 3, 18, 21, 12, 0, 0, DateTimeKind.Unspecified), "Voda71", 16.7f, 46f, 4, 0.3630435f },
                    { 70, new DateTime(2020, 10, 14, 4, 59, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 2, 6, 13, 14, 0, 0, DateTimeKind.Unspecified), "Jaje70", 13f, 23f, 2, 0.5652174f },
                    { 69, new DateTime(2012, 7, 30, 8, 56, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 6, 2, 5, 0, 0, 0, DateTimeKind.Unspecified), "Crna cokolada69", 16.42f, 26f, 3, 0.00063153845f },
                    { 68, new DateTime(2012, 5, 6, 15, 55, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 3, 3, 9, 27, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada68", 31.16f, 33f, 3, 0.0009442424f },
                    { 67, new DateTime(2017, 12, 6, 9, 26, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 8, 2, 8, 22, 0, 0, DateTimeKind.Unspecified), "Maslac67", 18.52f, 45f, 0, 0.00041155558f },
                    { 74, new DateTime(2011, 12, 7, 12, 14, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 12, 26, 13, 59, 0, 0, DateTimeKind.Unspecified), "Secer74", 11.21f, 41f, 4, 0.27341464f },
                    { 83, new DateTime(2019, 10, 10, 7, 8, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 5, 13, 16, 53, 0, 0, DateTimeKind.Unspecified), "Maslac83", 39.77f, 12f, 1, 3.3141668f },
                    { 98, new DateTime(2018, 11, 13, 9, 3, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 10, 11, 2, 36, 0, 0, DateTimeKind.Unspecified), "Secer98", 3.31f, 16f, 4, 0.206875f },
                    { 85, new DateTime(2021, 2, 8, 1, 43, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 7, 27, 6, 10, 0, 0, DateTimeKind.Unspecified), "Crna cokolada85", 31.24f, 6f, 1, 5.2066665f },
                    { 66, new DateTime(2018, 2, 14, 10, 47, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 6, 14, 11, 58, 0, 0, DateTimeKind.Unspecified), "Secer66", 17.81f, 6f, 0, 0.0029683332f },
                    { 100, new DateTime(2016, 6, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2011, 9, 13, 23, 58, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada100", 39.17f, 4f, 1, 9.7925f },
                    { 99, new DateTime(2017, 12, 8, 5, 6, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 10, 27, 17, 18, 0, 0, DateTimeKind.Unspecified), "Maslac99", 7.67f, 21f, 0, 0.0003652381f },
                    { 97, new DateTime(2021, 1, 21, 4, 54, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 3, 8, 17, 35, 0, 0, DateTimeKind.Unspecified), "Mlijeko97", 49.86f, 28f, 3, 0.0017807143f },
                    { 96, new DateTime(2020, 2, 12, 16, 5, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2010, 1, 23, 20, 59, 0, 0, DateTimeKind.Unspecified), "Brasno96", 25.08f, 44f, 0, 0.00057f },
                    { 95, new DateTime(2016, 4, 10, 18, 44, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 3, 15, 7, 58, 0, 0, DateTimeKind.Unspecified), "Voda95", 47.57f, 14f, 4, 3.3978572f },
                    { 94, new DateTime(2021, 7, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 12, 25, 17, 1, 0, 0, DateTimeKind.Unspecified), "Jaje94", 21.06f, 36f, 0, 0.000585f },
                    { 93, new DateTime(2021, 6, 6, 18, 15, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 8, 11, 6, 34, 0, 0, DateTimeKind.Unspecified), "Crna cokolada93", 31.55f, 47f, 0, 0.0006712766f },
                    { 92, new DateTime(2014, 2, 23, 14, 58, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 9, 23, 19, 30, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada92", 39.05f, 3f, 1, 13.016666f },
                    { 91, new DateTime(2013, 1, 31, 18, 52, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2010, 9, 17, 15, 54, 0, 0, DateTimeKind.Unspecified), "Maslac91", 39.79f, 3f, 3, 0.013263334f },
                    { 90, new DateTime(2020, 1, 21, 4, 53, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2020, 4, 10, 12, 31, 0, 0, DateTimeKind.Unspecified), "Secer90", 45.98f, 26f, 3, 0.0017684615f },
                    { 89, new DateTime(2013, 10, 19, 23, 32, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 6, 30, 18, 18, 0, 0, DateTimeKind.Unspecified), "Mlijeko89", 17.11f, 8f, 3, 0.0021387502f },
                    { 88, new DateTime(2019, 1, 20, 18, 19, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2010, 10, 14, 23, 56, 0, 0, DateTimeKind.Unspecified), "Brasno88", 9.72f, 1f, 0, 0.00972f },
                    { 87, new DateTime(2018, 1, 14, 14, 46, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2010, 12, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), "Voda87", 41.36f, 35f, 1, 1.1817143f },
                    { 86, new DateTime(2010, 1, 1, 3, 27, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 7, 28, 9, 49, 0, 0, DateTimeKind.Unspecified), "Jaje86", 48.38f, 38f, 1, 1.273158f },
                    { 84, new DateTime(2017, 4, 14, 23, 10, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 8, 2, 21, 41, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada84", 33.58f, 17f, 1, 1.9752942f },
                    { 65, new DateTime(2012, 8, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 7, 1, 9, 7, 0, 0, DateTimeKind.Unspecified), "Mlijeko65", 19.37f, 21f, 0, 0.000922381f },
                    { 32, new DateTime(2021, 3, 27, 19, 16, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 1, 21, 22, 50, 0, 0, DateTimeKind.Unspecified), "Brasno32", 39.1f, 32f, 3, 0.001221875f },
                    { 63, new DateTime(2016, 7, 7, 22, 26, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 1, 7, 7, 6, 0, 0, DateTimeKind.Unspecified), "Voda63", 37.1f, 48f, 2, 0.7729166f },
                    { 34, new DateTime(2015, 2, 24, 0, 47, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 15, 11, 25, 0, 0, DateTimeKind.Unspecified), "Secer34", 13.96f, 31f, 2, 0.45032257f },
                    { 33, new DateTime(2010, 9, 18, 19, 56, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 2, 21, 6, 28, 0, 0, DateTimeKind.Unspecified), "Mlijeko33", 48.57f, 38f, 2, 1.2781578f },
                    { 9, new DateTime(2020, 7, 21, 9, 25, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 12, 13, 1, 30, 0, 0, DateTimeKind.Unspecified), "Mlijeko9", 15.89f, 34f, 3, 0.00046735295f },
                    { 31, new DateTime(2014, 10, 19, 7, 1, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2011, 4, 15, 18, 22, 0, 0, DateTimeKind.Unspecified), "Voda31", 12.9f, 30f, 1, 0.42999998f },
                    { 30, new DateTime(2010, 12, 22, 12, 12, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 8, 27, 12, 22, 0, 0, DateTimeKind.Unspecified), "Jaje30", 28.38f, 27f, 1, 1.0511111f },
                    { 29, new DateTime(2018, 5, 27, 4, 52, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 1, 27, 1, 14, 0, 0, DateTimeKind.Unspecified), "Crna cokolada29", 48.51f, 4f, 1, 12.1275f },
                    { 10, new DateTime(2020, 6, 6, 4, 47, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2016, 11, 22, 14, 53, 0, 0, DateTimeKind.Unspecified), "Secer10", 9.43f, 24f, 4, 0.39291668f },
                    { 11, new DateTime(2016, 1, 21, 6, 3, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 6, 2, 19, 42, 0, 0, DateTimeKind.Unspecified), "Maslac11", 15.76f, 39f, 1, 0.40410256f },
                    { 12, new DateTime(2013, 2, 22, 3, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2019, 5, 7, 12, 26, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada12", 33.02f, 7f, 2, 4.717143f },
                    { 64, new DateTime(2016, 9, 11, 5, 54, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2011, 9, 15, 3, 56, 0, 0, DateTimeKind.Unspecified), "Brasno64", 17.99f, 37f, 3, 0.00048621622f },
                    { 13, new DateTime(2011, 11, 2, 21, 59, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 6, 14, 19, 25, 0, 0, DateTimeKind.Unspecified), "Crna cokolada13", 30.41f, 17f, 4, 1.7888235f },
                    { 35, new DateTime(2021, 1, 3, 19, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 12, 24, 16, 58, 0, 0, DateTimeKind.Unspecified), "Maslac35", 11.01f, 43f, 1, 0.2560465f },
                    { 14, new DateTime(2010, 11, 16, 23, 50, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 2, 24, 19, 3, 0, 0, DateTimeKind.Unspecified), "Jaje14", 10.34f, 19f, 1, 0.54421055f },
                    { 16, new DateTime(2013, 7, 31, 11, 29, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 3, 15, 6, 18, 0, 0, DateTimeKind.Unspecified), "Brasno16", 37.07f, 35f, 0, 0.0010591429f },
                    { 17, new DateTime(2019, 7, 28, 7, 52, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2021, 6, 19, 22, 15, 0, 0, DateTimeKind.Unspecified), "Mlijeko17", 33.67f, 38f, 2, 0.8860526f },
                    { 18, new DateTime(2015, 2, 10, 7, 2, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2017, 11, 11, 23, 23, 0, 0, DateTimeKind.Unspecified), "Secer18", 48.63f, 14f, 1, 3.4735715f },
                    { 19, new DateTime(2015, 3, 8, 19, 33, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2018, 5, 31, 19, 51, 0, 0, DateTimeKind.Unspecified), "Maslac19", 43.41f, 38f, 3, 0.0011423684f },
                    { 20, new DateTime(2018, 12, 12, 16, 58, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 4, 16, 19, 54, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada20", 44.56f, 35f, 3, 0.0012731429f },
                    { 21, new DateTime(2012, 5, 5, 0, 4, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 7, 31, 19, 16, 0, 0, DateTimeKind.Unspecified), "Crna cokolada21", 42.05f, 46f, 0, 0.0009141304f },
                    { 22, new DateTime(2016, 1, 6, 15, 17, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 12, 17, 6, 45, 0, 0, DateTimeKind.Unspecified), "Jaje22", 14f, 6f, 0, 0.0023333333f },
                    { 23, new DateTime(2014, 6, 14, 17, 15, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2012, 4, 27, 3, 25, 0, 0, DateTimeKind.Unspecified), "Voda23", 30.31f, 2f, 3, 0.015155f },
                    { 24, new DateTime(2016, 7, 14, 22, 42, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2020, 8, 26, 5, 12, 0, 0, DateTimeKind.Unspecified), "Brasno24", 47.66f, 33f, 0, 0.0014442424f },
                    { 25, new DateTime(2015, 11, 9, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 9, 30, 19, 56, 0, 0, DateTimeKind.Unspecified), "Mlijeko25", 28.07f, 47f, 3, 0.00059723406f },
                    { 26, new DateTime(2010, 1, 25, 23, 39, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 3, 1, 9, 57, 0, 0, DateTimeKind.Unspecified), "Secer26", 42.28f, 21f, 3, 0.0020133334f },
                    { 15, new DateTime(2020, 2, 26, 19, 27, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2020, 2, 3, 22, 59, 0, 0, DateTimeKind.Unspecified), "Voda15", 13.04f, 38f, 2, 0.3431579f },
                    { 27, new DateTime(2020, 1, 22, 20, 59, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 6, 14, 1, 46, 0, 0, DateTimeKind.Unspecified), "Maslac27", 9.36f, 18f, 3, 0.00052f },
                    { 36, new DateTime(2010, 2, 17, 1, 25, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2012, 2, 21, 13, 33, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada36", 3.98f, 23f, 2, 0.17304347f },
                    { 38, new DateTime(2014, 7, 21, 14, 49, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2017, 6, 20, 10, 47, 0, 0, DateTimeKind.Unspecified), "Jaje38", 14.76f, 43f, 3, 0.00034325582f },
                    { 62, new DateTime(2011, 9, 11, 17, 53, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2019, 2, 14, 21, 45, 0, 0, DateTimeKind.Unspecified), "Jaje62", 41.05f, 18f, 4, 2.2805555f },
                    { 61, new DateTime(2010, 1, 1, 21, 9, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 1, 8, 18, 41, 0, 0, DateTimeKind.Unspecified), "Crna cokolada61", 49.37f, 5f, 3, 0.009874f },
                    { 60, new DateTime(2011, 1, 13, 23, 29, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2018, 4, 19, 18, 24, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada60", 16.46f, 13f, 3, 0.0012661538f },
                    { 59, new DateTime(2018, 12, 27, 14, 49, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2016, 10, 29, 19, 46, 0, 0, DateTimeKind.Unspecified), "Maslac59", 17.98f, 8f, 4, 2.2475f },
                    { 58, new DateTime(2016, 9, 26, 15, 38, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2012, 7, 30, 12, 23, 0, 0, DateTimeKind.Unspecified), "Secer58", 18.78f, 26f, 3, 0.0007223077f },
                    { 57, new DateTime(2015, 3, 6, 6, 4, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2011, 6, 16, 17, 39, 0, 0, DateTimeKind.Unspecified), "Mlijeko57", 49.24f, 47f, 1, 1.0476596f },
                    { 56, new DateTime(2012, 10, 26, 4, 51, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2013, 3, 22, 8, 36, 0, 0, DateTimeKind.Unspecified), "Brasno56", 40.77f, 13f, 4, 3.136154f },
                    { 55, new DateTime(2020, 11, 22, 10, 57, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2015, 11, 25, 17, 56, 0, 0, DateTimeKind.Unspecified), "Voda55", 16.95f, 46f, 1, 0.36847827f },
                    { 54, new DateTime(2015, 3, 3, 1, 25, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2015, 12, 3, 12, 6, 0, 0, DateTimeKind.Unspecified), "Jaje54", 8.88f, 37f, 3, 0.00024000001f },
                    { 53, new DateTime(2015, 8, 14, 18, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2019, 12, 4, 10, 5, 0, 0, DateTimeKind.Unspecified), "Crna cokolada53", 29.93f, 11f, 0, 0.0027209092f },
                    { 52, new DateTime(2021, 8, 21, 9, 42, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 14, 22, 32, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada52", 26.36f, 46f, 1, 0.57304347f },
                    { 37, new DateTime(2015, 12, 31, 8, 32, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2014, 2, 20, 8, 53, 0, 0, DateTimeKind.Unspecified), "Crna cokolada37", 23.75f, 47f, 4, 0.5053192f },
                    { 51, new DateTime(2019, 3, 3, 2, 38, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 9, 28, 11, 16, 0, 0, DateTimeKind.Unspecified), "Maslac51", 38.97f, 42f, 3, 0.0009278572f },
                    { 49, new DateTime(2021, 5, 4, 23, 59, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2016, 12, 13, 16, 27, 0, 0, DateTimeKind.Unspecified), "Mlijeko49", 12.67f, 16f, 0, 0.000791875f },
                    { 48, new DateTime(2011, 6, 30, 12, 52, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2011, 1, 21, 5, 41, 0, 0, DateTimeKind.Unspecified), "Brasno48", 35.9f, 34f, 4, 1.0558825f },
                    { 47, new DateTime(2017, 6, 10, 7, 39, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2014, 4, 18, 4, 36, 0, 0, DateTimeKind.Unspecified), "Voda47", 16.63f, 37f, 3, 0.00044945945f },
                    { 46, new DateTime(2021, 6, 16, 18, 31, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2017, 2, 8, 18, 19, 0, 0, DateTimeKind.Unspecified), "Jaje46", 6.63f, 6f, 4, 1.105f },
                    { 45, new DateTime(2020, 2, 4, 17, 31, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2011, 11, 20, 21, 44, 0, 0, DateTimeKind.Unspecified), "Crna cokolada45", 24.08f, 20f, 4, 1.204f },
                    { 44, new DateTime(2015, 2, 20, 9, 19, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2016, 2, 14, 6, 6, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada44", 11.63f, 38f, 1, 0.30605263f },
                    { 43, new DateTime(2020, 1, 9, 23, 20, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2014, 5, 31, 1, 31, 0, 0, DateTimeKind.Unspecified), "Maslac43", 39.64f, 49f, 4, 0.8089796f },
                    { 42, new DateTime(2014, 4, 18, 3, 32, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2014, 5, 29, 23, 30, 0, 0, DateTimeKind.Unspecified), "Secer42", 11.04f, 5f, 1, 2.208f },
                    { 41, new DateTime(2019, 11, 29, 20, 43, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2012, 3, 21, 18, 38, 0, 0, DateTimeKind.Unspecified), "Mlijeko41", 30.75f, 42f, 3, 0.0007321429f },
                    { 40, new DateTime(2014, 11, 23, 19, 10, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 7, 6, 18, 33, 0, 0, DateTimeKind.Unspecified), "Brasno40", 20.74f, 18f, 2, 1.1522222f },
                    { 39, new DateTime(2010, 5, 29, 4, 25, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2015, 3, 7, 20, 15, 0, 0, DateTimeKind.Unspecified), "Voda39", 25.1f, 19f, 2, 1.3210527f },
                    { 50, new DateTime(2019, 3, 31, 10, 49, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2021, 4, 22, 10, 47, 0, 0, DateTimeKind.Unspecified), "Secer50", 43.11f, 20f, 0, 0.0021555f },
                    { 28, new DateTime(2011, 5, 17, 4, 43, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2013, 3, 23, 9, 17, 0, 0, DateTimeKind.Unspecified), "Mlijecna cokolada28", 31.74f, 32f, 2, 0.991875f }
                });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "Quantity", "Unit" },
                values: new object[] { 25.06f, 1 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 2, 11, 9.17f, 2 },
                    { 1, 9, 49.77f, 3 },
                    { 8, 8, 46.51f, 3 },
                    { 3, 7, 12.24f, 4 },
                    { 3, 6, 18.13f, 2 },
                    { 2, 2, 27.48f, 3 },
                    { 2, 12, 19.25f, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 1, new DateTime(2016, 11, 15, 12, 16, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 12, 26, 6, 46, 0, 0, DateTimeKind.Unspecified), "Rafaelo2" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 14, 7, new DateTime(2015, 7, 6, 4, 54, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 11, 6, 21, 11, 0, 0, DateTimeKind.Unspecified), "Rafaelo14" },
                    { 26, 1, new DateTime(2018, 6, 17, 20, 5, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 5, 22, 8, 31, 0, 0, DateTimeKind.Unspecified), "Rafaelo26" },
                    { 30, 6, new DateTime(2010, 7, 15, 16, 40, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 12, 21, 14, 34, 0, 0, DateTimeKind.Unspecified), "Kinder30" },
                    { 34, 9, new DateTime(2014, 6, 21, 21, 12, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 2, 5, 2, 8, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce34" },
                    { 35, 3, new DateTime(2019, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 10, 7, 12, 13, 0, 0, DateTimeKind.Unspecified), "Dummy recept35" },
                    { 80, 5, new DateTime(2020, 11, 6, 17, 19, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 11, 5, 12, 38, 0, 0, DateTimeKind.Unspecified), "Snickers80" },
                    { 41, 11, new DateTime(2014, 5, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 7, 13, 11, 33, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama41" },
                    { 68, 1, new DateTime(2014, 10, 14, 1, 15, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 10, 29, 4, 42, 0, 0, DateTimeKind.Unspecified), "Snickers68" },
                    { 88, 6, new DateTime(2012, 6, 2, 8, 42, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 12, 26, 0, 30, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama88" },
                    { 90, 1, new DateTime(2017, 11, 3, 8, 42, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 10, 19, 16, 28, 0, 0, DateTimeKind.Unspecified), "Kinder90" },
                    { 91, 9, new DateTime(2021, 11, 14, 14, 44, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 7, 21, 10, 54, 0, 0, DateTimeKind.Unspecified), "Twix91" },
                    { 94, 6, new DateTime(2016, 1, 10, 20, 48, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 8, 13, 10, 11, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce94" },
                    { 36, 11, new DateTime(2018, 9, 6, 8, 37, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 2, 25, 22, 19, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac36" },
                    { 32, 9, new DateTime(2010, 12, 2, 5, 30, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 8, 11, 6, 22, 0, 0, DateTimeKind.Unspecified), "Snickers32" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 44, 12, 8.41f, 0 },
                    { 96, 12, 16.72f, 4 },
                    { 99, 5, 31.52f, 2 },
                    { 100, 12, 19.75f, 1 },
                    { 74, 14, 43.61f, 2 },
                    { 19, 14, 7.64f, 4 },
                    { 66, 14, 17.48f, 2 },
                    { 86, 14, 2.84f, 4 },
                    { 6, 14, 27.06f, 1 },
                    { 15, 26, 27.94f, 1 },
                    { 28, 26, 26.14f, 2 },
                    { 27, 26, 30.22f, 3 },
                    { 60, 26, 6.95f, 3 },
                    { 40, 26, 18.62f, 2 },
                    { 80, 26, 28.53f, 2 },
                    { 45, 30, 34.06f, 0 },
                    { 81, 30, 48.89f, 2 },
                    { 82, 30, 6.38f, 3 },
                    { 22, 30, 44.23f, 3 },
                    { 46, 30, 38.65f, 2 },
                    { 13, 30, 31.91f, 0 },
                    { 60, 30, 42.5f, 2 },
                    { 14, 30, 18.82f, 4 },
                    { 81, 32, 11.08f, 4 },
                    { 96, 8, 5.79f, 2 },
                    { 95, 8, 25.33f, 3 },
                    { 95, 3, 39.61f, 0 },
                    { 95, 1, 32.3f, 2 },
                    { 47, 2, 20.78f, 0 },
                    { 48, 1, 34.98f, 1 },
                    { 48, 8, 30.24f, 2 },
                    { 48, 12, 9.24f, 2 },
                    { 49, 11, 12.43f, 4 },
                    { 51, 5, 23.77f, 3 },
                    { 52, 1, 18.18f, 1 },
                    { 53, 3, 31.28f, 1 },
                    { 53, 6, 39.12f, 3 },
                    { 56, 2, 20.06f, 3 },
                    { 57, 1, 46.96f, 3 },
                    { 72, 32, 29.85f, 4 },
                    { 62, 8, 23.12f, 3 },
                    { 65, 6, 7.09f, 2 },
                    { 65, 9, 17.12f, 0 },
                    { 67, 11, 36.34f, 4 },
                    { 71, 3, 11.57f, 2 },
                    { 84, 9, 46.47f, 1 },
                    { 86, 5, 23.12f, 4 },
                    { 87, 4, 9.38f, 0 },
                    { 88, 10, 1.81f, 4 },
                    { 88, 11, 1.25f, 0 },
                    { 89, 12, 41.05f, 2 },
                    { 90, 12, 15.2f, 0 },
                    { 64, 5, 19.04f, 3 },
                    { 27, 32, 8.36f, 1 },
                    { 83, 34, 30.37f, 1 },
                    { 100, 34, 34.37f, 0 },
                    { 30, 80, 6f, 1 },
                    { 61, 88, 8.93f, 2 },
                    { 87, 88, 35.86f, 0 },
                    { 16, 88, 10.42f, 2 },
                    { 72, 88, 28.91f, 1 },
                    { 57, 88, 15.9f, 1 },
                    { 74, 88, 2.16f, 0 },
                    { 1, 90, 18.53f, 0 },
                    { 94, 90, 45.27f, 2 },
                    { 53, 90, 12.82f, 1 },
                    { 96, 90, 4.73f, 3 },
                    { 31, 80, 41.13f, 2 },
                    { 57, 90, 2.26f, 3 },
                    { 31, 91, 22.44f, 3 },
                    { 88, 91, 8.85f, 0 },
                    { 9, 91, 6.8f, 1 },
                    { 99, 91, 6.78f, 3 },
                    { 10, 91, 16.21f, 2 },
                    { 98, 91, 19.67f, 2 },
                    { 82, 94, 21.84f, 4 },
                    { 37, 94, 2.12f, 3 },
                    { 92, 94, 33.6f, 2 },
                    { 43, 94, 10.4f, 3 },
                    { 71, 94, 6.39f, 2 },
                    { 89, 90, 16.93f, 4 },
                    { 45, 3, 46.63f, 1 },
                    { 11, 80, 2.8f, 1 },
                    { 12, 68, 9f, 3 },
                    { 66, 34, 19.82f, 1 },
                    { 76, 34, 45.33f, 4 },
                    { 56, 35, 32.76f, 0 },
                    { 95, 35, 48.31f, 0 },
                    { 53, 35, 26.44f, 1 },
                    { 74, 35, 21.92f, 3 },
                    { 68, 35, 47.04f, 3 },
                    { 21, 35, 14.91f, 2 },
                    { 31, 35, 45.94f, 0 },
                    { 62, 36, 27.57f, 0 },
                    { 7, 36, 46.24f, 0 },
                    { 15, 80, 7.84f, 2 },
                    { 39, 36, 3.28f, 0 },
                    { 60, 36, 25.53f, 0 },
                    { 6, 36, 34.56f, 4 },
                    { 59, 36, 20.13f, 3 },
                    { 50, 41, 31.39f, 1 },
                    { 77, 41, 25.93f, 2 },
                    { 69, 41, 1.45f, 1 },
                    { 82, 41, 43.82f, 4 },
                    { 14, 41, 38.59f, 0 },
                    { 18, 68, 14.37f, 2 },
                    { 3, 68, 34.69f, 4 },
                    { 55, 68, 21.87f, 1 },
                    { 41, 36, 35.8f, 2 },
                    { 1, 94, 15f, 4 },
                    { 20, 94, 35.85f, 3 },
                    { 44, 1, 21.55f, 2 },
                    { 44, 6, 4.83f, 0 },
                    { 11, 8, 12.97f, 2 },
                    { 12, 1, 37.01f, 0 },
                    { 12, 9, 32.09f, 2 },
                    { 12, 10, 32.03f, 2 },
                    { 13, 2, 39.13f, 0 },
                    { 13, 4, 24.54f, 2 },
                    { 13, 9, 35.23f, 3 },
                    { 16, 4, 29.95f, 0 },
                    { 19, 11, 28.83f, 4 },
                    { 20, 2, 23.18f, 4 },
                    { 10, 4, 27.63f, 1 },
                    { 21, 10, 34.61f, 4 },
                    { 22, 7, 26.89f, 1 },
                    { 24, 7, 6.51f, 3 },
                    { 24, 10, 22.17f, 0 },
                    { 28, 8, 46.25f, 1 },
                    { 30, 2, 6.42f, 0 },
                    { 30, 4, 41.56f, 0 },
                    { 32, 10, 12.36f, 3 },
                    { 34, 12, 14.82f, 4 },
                    { 36, 10, 4.91f, 0 },
                    { 21, 7, 10.16f, 3 },
                    { 37, 7, 14.62f, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 59, new DateTime(2010, 12, 14, 10, 43, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 5, 4, 14, 33, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac1" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 24, new DateTime(2020, 11, 28, 21, 2, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 6, 27, 5, 3, 0, 0, DateTimeKind.Unspecified), "Ferrero3" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 44, new DateTime(2018, 6, 21, 13, 27, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 12, 25, 6, 42, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama4" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 89, new DateTime(2013, 11, 20, 22, 5, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 7, 8, 13, 42, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama5" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 94, new DateTime(2016, 5, 4, 8, 24, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 7, 19, 23, 3, 0, 0, DateTimeKind.Unspecified), "Kinder6" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 73, new DateTime(2014, 6, 16, 7, 3, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 1, 28, 11, 34, 0, 0, DateTimeKind.Unspecified), "Twix7" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 45, new DateTime(2019, 7, 6, 16, 32, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 7, 8, 12, 16, 0, 0, DateTimeKind.Unspecified), "Snickers8" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 77, new DateTime(2021, 4, 24, 6, 30, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 7, 17, 20, 35, 0, 0, DateTimeKind.Unspecified), "Orah9" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 91, new DateTime(2017, 12, 17, 7, 34, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 3, 1, 0, 34, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce10" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 34, new DateTime(2019, 10, 30, 21, 53, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 4, 21, 6, 9, 0, 0, DateTimeKind.Unspecified), "Dummy recept11" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 28, new DateTime(2015, 4, 25, 2, 57, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 11, 26, 17, 44, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac12" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 17, 40, new DateTime(2013, 1, 29, 1, 51, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 5, 10, 4, 54, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama17" },
                    { 66, 47, new DateTime(2019, 8, 25, 2, 46, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 9, 18, 22, 38, 0, 0, DateTimeKind.Unspecified), "Kinder66" },
                    { 95, 48, new DateTime(2018, 4, 24, 5, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 5, 2, 16, 38, 0, 0, DateTimeKind.Unspecified), "Dummy recept95" },
                    { 49, 39, new DateTime(2015, 8, 19, 6, 48, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 6, 27, 12, 34, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac49" },
                    { 99, 35, new DateTime(2020, 6, 22, 19, 6, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 11, 19, 23, 48, 0, 0, DateTimeKind.Unspecified), "Ferrero99" },
                    { 43, 50, new DateTime(2014, 10, 24, 19, 37, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 6, 15, 10, 17, 0, 0, DateTimeKind.Unspecified), "Twix43" },
                    { 81, 35, new DateTime(2013, 10, 13, 14, 57, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 10, 6, 20, 13, 0, 0, DateTimeKind.Unspecified), "Orah81" },
                    { 93, 51, new DateTime(2017, 6, 9, 1, 54, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 3, 21, 21, 4, 0, 0, DateTimeKind.Unspecified), "Orah93" },
                    { 61, 35, new DateTime(2012, 4, 3, 5, 39, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 8, 25, 11, 12, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac61" },
                    { 52, 35, new DateTime(2016, 3, 24, 7, 34, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 11, 26, 12, 49, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama52" },
                    { 16, 42, new DateTime(2014, 11, 5, 18, 49, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 12, 22, 6, 14, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama16" },
                    { 55, 46, new DateTime(2011, 3, 24, 8, 24, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 8, 2, 16, 31, 0, 0, DateTimeKind.Unspecified), "Twix55" },
                    { 83, 22, new DateTime(2012, 12, 7, 13, 44, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 9, 21, 18, 44, 0, 0, DateTimeKind.Unspecified), "Dummy recept83" },
                    { 19, 33, new DateTime(2015, 11, 1, 3, 38, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 2, 28, 8, 11, 0, 0, DateTimeKind.Unspecified), "Twix19" },
                    { 50, 16, new DateTime(2012, 1, 30, 10, 9, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 6, 28, 21, 24, 0, 0, DateTimeKind.Unspecified), "Rafaelo50" },
                    { 79, 17, new DateTime(2017, 11, 22, 12, 28, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 2, 25, 19, 1, 0, 0, DateTimeKind.Unspecified), "Twix79" },
                    { 89, 17, new DateTime(2010, 1, 18, 9, 36, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 9, 13, 13, 1, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama89" },
                    { 67, 19, new DateTime(2017, 6, 23, 11, 45, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 7, 21, 20, 45, 0, 0, DateTimeKind.Unspecified), "Twix67" },
                    { 46, 21, new DateTime(2013, 9, 19, 16, 42, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 11, 12, 9, 7, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce46" },
                    { 54, 21, new DateTime(2011, 8, 29, 10, 25, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 11, 3, 15, 21, 0, 0, DateTimeKind.Unspecified), "Kinder54" },
                    { 63, 21, new DateTime(2015, 1, 18, 19, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 10, 25, 23, 30, 0, 0, DateTimeKind.Unspecified), "Ferrero63" },
                    { 74, 21, new DateTime(2012, 12, 10, 8, 45, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 12, 19, 19, 54, 0, 0, DateTimeKind.Unspecified), "Rafaelo74" },
                    { 82, 53, new DateTime(2015, 10, 15, 10, 2, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 9, 16, 1, 47, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce82" },
                    { 22, 23, new DateTime(2013, 2, 4, 18, 56, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 10, 2, 5, 2, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce22" },
                    { 20, 25, new DateTime(2014, 10, 24, 22, 28, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 12, 9, 13, 12, 0, 0, DateTimeKind.Unspecified), "Snickers20" },
                    { 71, 26, new DateTime(2016, 10, 17, 23, 52, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 4, 8, 5, 9, 0, 0, DateTimeKind.Unspecified), "Dummy recept71" },
                    { 97, 27, new DateTime(2016, 6, 1, 13, 58, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 3, 13, 3, 36, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac97" },
                    { 58, 28, new DateTime(2016, 8, 22, 22, 3, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 6, 13, 12, 35, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce58" },
                    { 84, 29, new DateTime(2013, 12, 27, 1, 55, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 5, 16, 3, 35, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac84" },
                    { 92, 30, new DateTime(2011, 9, 14, 4, 22, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 7, 17, 4, 50, 0, 0, DateTimeKind.Unspecified), "Snickers92" },
                    { 44, 32, new DateTime(2010, 2, 10, 20, 30, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 10, 28, 9, 59, 0, 0, DateTimeKind.Unspecified), "Snickers44" },
                    { 69, 34, new DateTime(2017, 4, 19, 3, 59, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 4, 10, 7, 17, 0, 0, DateTimeKind.Unspecified), "Orah69" },
                    { 28, 55, new DateTime(2013, 11, 13, 2, 5, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 8, 26, 4, 34, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama28" },
                    { 56, 72, new DateTime(2013, 6, 11, 17, 22, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 6, 18, 13, 41, 0, 0, DateTimeKind.Unspecified), "Snickers56" },
                    { 23, 56, new DateTime(2019, 11, 9, 23, 34, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 7, 26, 17, 1, 0, 0, DateTimeKind.Unspecified), "Dummy recept23" },
                    { 76, 81, new DateTime(2017, 1, 26, 4, 42, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 6, 5, 5, 42, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama76" },
                    { 29, 82, new DateTime(2019, 1, 9, 11, 36, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 12, 18, 18, 31, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama29" },
                    { 39, 82, new DateTime(2019, 3, 15, 11, 12, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 7, 22, 21, 55, 0, 0, DateTimeKind.Unspecified), "Ferrero39" },
                    { 53, 83, new DateTime(2019, 8, 31, 12, 9, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2017, 4, 22, 21, 46, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama53" },
                    { 64, 86, new DateTime(2013, 7, 11, 6, 48, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 11, 23, 14, 12, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama64" },
                    { 60, 89, new DateTime(2019, 10, 17, 10, 44, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 3, 20, 8, 35, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac60" },
                    { 65, 90, new DateTime(2012, 1, 21, 5, 18, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 7, 6, 6, 36, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama65" },
                    { 70, 79, new DateTime(2010, 1, 17, 16, 14, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 7, 2, 21, 50, 0, 0, DateTimeKind.Unspecified), "Specijalitet kuce70" },
                    { 13, 91, new DateTime(2015, 6, 13, 14, 5, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 12, 7, 6, 27, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac13" },
                    { 51, 91, new DateTime(2020, 2, 3, 19, 49, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2021, 7, 2, 11, 48, 0, 0, DateTimeKind.Unspecified), "Ferrero51" },
                    { 40, 92, new DateTime(2019, 1, 16, 18, 10, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 11, 17, 21, 4, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama40" },
                    { 47, 92, new DateTime(2019, 8, 16, 15, 30, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2015, 11, 2, 7, 54, 0, 0, DateTimeKind.Unspecified), "Dummy recept47" },
                    { 77, 93, new DateTime(2012, 9, 9, 1, 49, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 11, 11, 1, 34, 0, 0, DateTimeKind.Unspecified), "Kolac s jabukama77" },
                    { 98, 93, new DateTime(2015, 9, 20, 6, 53, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 1, 13, 3, 39, 0, 0, DateTimeKind.Unspecified), "Rafaelo98" },
                    { 27, 95, new DateTime(2013, 11, 11, 9, 43, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 4, 3, 15, 52, 0, 0, DateTimeKind.Unspecified), "Ferrero27" },
                    { 62, 98, new DateTime(2013, 8, 10, 23, 19, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 1, 28, 12, 33, 0, 0, DateTimeKind.Unspecified), "Rafaelo62" },
                    { 18, 91, new DateTime(2019, 4, 29, 1, 47, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 9, 30, 4, 18, 0, 0, DateTimeKind.Unspecified), "Kinder18" },
                    { 31, 79, new DateTime(2015, 12, 24, 0, 8, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 8, 13, 16, 16, 0, 0, DateTimeKind.Unspecified), "Twix31" },
                    { 96, 78, new DateTime(2018, 12, 5, 16, 14, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 2, 23, 8, 58, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac96" },
                    { 33, 77, new DateTime(2015, 9, 3, 18, 52, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2012, 5, 14, 2, 9, 0, 0, DateTimeKind.Unspecified), "Orah33" },
                    { 15, 57, new DateTime(2014, 1, 24, 1, 11, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 4, 12, 15, 42, 0, 0, DateTimeKind.Unspecified), "Ferrero15" },
                    { 42, 57, new DateTime(2019, 3, 5, 20, 7, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 9, 17, 4, 24, 0, 0, DateTimeKind.Unspecified), "Kinder42" },
                    { 45, 59, new DateTime(2014, 6, 28, 2, 48, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 9, 3, 21, 13, 0, 0, DateTimeKind.Unspecified), "Orah45" },
                    { 57, 59, new DateTime(2012, 12, 3, 0, 21, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2019, 8, 26, 19, 36, 0, 0, DateTimeKind.Unspecified), "Orah57" },
                    { 75, 59, new DateTime(2021, 3, 10, 9, 50, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 7, 8, 0, 28, 0, 0, DateTimeKind.Unspecified), "Ferrero75" },
                    { 48, 60, new DateTime(2015, 12, 18, 13, 3, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 7, 7, 0, 50, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac48" },
                    { 59, 63, new DateTime(2011, 6, 11, 20, 8, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 3, 16, 1, 5, 0, 0, DateTimeKind.Unspecified), "Dummy recept59" },
                    { 21, 64, new DateTime(2017, 2, 18, 17, 6, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 7, 19, 12, 18, 0, 0, DateTimeKind.Unspecified), "Orah21" },
                    { 73, 65, new DateTime(2015, 3, 26, 3, 50, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2014, 4, 2, 3, 1, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac73" },
                    { 25, 67, new DateTime(2010, 9, 4, 1, 3, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2016, 5, 7, 20, 47, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac25" },
                    { 87, 67, new DateTime(2013, 2, 27, 8, 51, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2010, 4, 17, 12, 53, 0, 0, DateTimeKind.Unspecified), "Ferrero87" },
                    { 100, 68, new DateTime(2010, 12, 20, 20, 33, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2020, 7, 2, 9, 6, 0, 0, DateTimeKind.Unspecified), "Kolac s jagodama100" },
                    { 72, 73, new DateTime(2011, 8, 8, 1, 35, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 11, 26, 10, 17, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac72" },
                    { 24, 74, new DateTime(2017, 8, 8, 13, 56, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 12, 24, 17, 20, 0, 0, DateTimeKind.Unspecified), "Cokoladni kolac24" },
                    { 37, 75, new DateTime(2016, 9, 23, 22, 6, 0, 0, DateTimeKind.Unspecified), 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 1, 6, 18, 22, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac37" },
                    { 38, 75, new DateTime(2021, 1, 9, 7, 27, 0, 0, DateTimeKind.Unspecified), 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2013, 4, 13, 9, 34, 0, 0, DateTimeKind.Unspecified), "Rafaelo38" },
                    { 86, 76, new DateTime(2019, 2, 23, 8, 35, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 3, 2, 12, 50, 0, 0, DateTimeKind.Unspecified), "Rafaelo86" },
                    { 78, 55, new DateTime(2015, 3, 28, 15, 45, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2018, 6, 12, 8, 36, 0, 0, DateTimeKind.Unspecified), "Kinder78" },
                    { 85, 14, new DateTime(2014, 11, 13, 18, 20, 0, 0, DateTimeKind.Unspecified), 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in auctor enim, eget efficitur sem. Curabitur in suscipit est. In maximus tortor ac dignissim lobortis. Morbi viverra lorem sit amet aliquam hendrerit.", new DateTime(2011, 10, 26, 17, 20, 0, 0, DateTimeKind.Unspecified), "Bijeli kolac85" }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 12, 85, 37.66f, 1 },
                    { 57, 72, 12.19f, 4 },
                    { 30, 72, 6.75f, 0 },
                    { 76, 72, 13.9f, 2 },
                    { 65, 56, 21.38f, 4 },
                    { 7, 56, 36.82f, 0 },
                    { 26, 56, 31.43f, 2 },
                    { 81, 56, 21.18f, 0 },
                    { 48, 56, 25.02f, 3 },
                    { 44, 100, 43.29f, 1 },
                    { 19, 100, 25.21f, 0 },
                    { 74, 100, 2.14f, 4 },
                    { 8, 100, 23.05f, 0 },
                    { 90, 100, 24.75f, 4 },
                    { 66, 87, 25.43f, 2 },
                    { 98, 87, 23.38f, 4 },
                    { 65, 87, 31.17f, 1 },
                    { 97, 87, 48.87f, 4 },
                    { 6, 87, 9.8f, 1 },
                    { 38, 25, 10.54f, 0 },
                    { 84, 25, 29.6f, 4 },
                    { 57, 25, 44.1f, 3 },
                    { 36, 72, 10.6f, 3 },
                    { 70, 25, 16.57f, 1 },
                    { 52, 24, 27.89f, 0 },
                    { 98, 24, 41.8f, 1 },
                    { 25, 33, 47.1f, 4 },
                    { 70, 33, 40.42f, 2 },
                    { 86, 33, 14.68f, 1 },
                    { 44, 86, 36.95f, 0 },
                    { 40, 86, 21.88f, 4 },
                    { 99, 86, 21.03f, 0 },
                    { 77, 86, 39.67f, 3 },
                    { 85, 86, 26.82f, 2 },
                    { 82, 86, 34.6f, 3 },
                    { 90, 38, 11.47f, 1 },
                    { 18, 38, 2.6f, 2 },
                    { 89, 38, 45.59f, 0 },
                    { 38, 38, 26.26f, 4 },
                    { 54, 38, 19.66f, 3 },
                    { 14, 37, 20.67f, 3 },
                    { 63, 37, 30.13f, 4 },
                    { 80, 37, 6.63f, 4 },
                    { 35, 37, 12.63f, 2 },
                    { 92, 24, 14.49f, 2 },
                    { 96, 24, 2.17f, 2 },
                    { 99, 24, 21.49f, 4 },
                    { 30, 24, 8.84f, 2 },
                    { 33, 25, 44.23f, 3 },
                    { 39, 25, 20.53f, 0 },
                    { 8, 73, 14.75f, 3 },
                    { 83, 57, 40.32f, 0 },
                    { 78, 57, 18.99f, 1 },
                    { 35, 57, 26.49f, 2 },
                    { 3, 57, 35.03f, 4 },
                    { 25, 45, 6.64f, 2 },
                    { 16, 45, 1.31f, 2 },
                    { 36, 45, 48.79f, 4 },
                    { 5, 42, 15.26f, 3 },
                    { 58, 42, 4.56f, 1 },
                    { 35, 42, 47.5f, 3 },
                    { 69, 42, 23.83f, 3 },
                    { 7, 42, 20.59f, 4 },
                    { 6, 42, 13.51f, 3 },
                    { 60, 42, 47.73f, 1 },
                    { 56, 15, 42.56f, 3 },
                    { 34, 15, 19.57f, 2 },
                    { 7, 15, 49.46f, 2 },
                    { 36, 15, 7.47f, 4 },
                    { 92, 15, 31.97f, 4 },
                    { 94, 15, 19.36f, 2 },
                    { 34, 23, 2.33f, 1 },
                    { 52, 57, 31.95f, 1 },
                    { 28, 57, 10.32f, 4 },
                    { 32, 75, 31.17f, 3 },
                    { 55, 75, 23.18f, 4 },
                    { 33, 73, 24.43f, 0 },
                    { 96, 73, 45.22f, 4 },
                    { 57, 73, 38.15f, 1 },
                    { 66, 73, 20.69f, 4 },
                    { 48, 21, 18.53f, 1 },
                    { 17, 21, 11.45f, 0 },
                    { 30, 21, 27.62f, 2 },
                    { 4, 59, 5.44f, 0 },
                    { 61, 59, 8.4f, 1 },
                    { 80, 59, 6.88f, 1 },
                    { 29, 33, 1.05f, 0 },
                    { 48, 59, 41.72f, 2 },
                    { 2, 48, 36.48f, 2 },
                    { 100, 48, 42.14f, 0 },
                    { 13, 48, 24.92f, 2 },
                    { 26, 48, 31.75f, 0 },
                    { 23, 75, 8.53f, 4 },
                    { 35, 75, 41.72f, 0 },
                    { 63, 75, 29.42f, 1 },
                    { 40, 75, 38.87f, 0 },
                    { 11, 75, 17.18f, 1 },
                    { 37, 75, 38.63f, 0 },
                    { 59, 59, 30.99f, 2 },
                    { 91, 33, 42.03f, 2 },
                    { 38, 33, 26.63f, 4 },
                    { 16, 96, 32.81f, 3 },
                    { 23, 40, 14.95f, 1 },
                    { 84, 51, 34.72f, 4 },
                    { 70, 51, 39.83f, 0 },
                    { 73, 51, 19.57f, 0 },
                    { 57, 51, 33.06f, 2 },
                    { 22, 51, 4.54f, 0 },
                    { 18, 18, 36.31f, 2 },
                    { 86, 18, 39.5f, 0 },
                    { 37, 18, 15.91f, 3 },
                    { 87, 18, 2.23f, 0 },
                    { 4, 18, 13.81f, 4 },
                    { 88, 18, 38.41f, 3 },
                    { 50, 13, 41.39f, 4 },
                    { 42, 13, 49.82f, 0 },
                    { 1, 13, 43.7f, 4 },
                    { 60, 13, 8.96f, 4 },
                    { 46, 13, 44.75f, 2 },
                    { 76, 65, 21.44f, 1 },
                    { 78, 65, 20.03f, 2 },
                    { 1, 65, 18.12f, 4 },
                    { 90, 65, 32.99f, 2 },
                    { 81, 40, 48.46f, 4 },
                    { 72, 40, 13.62f, 3 },
                    { 97, 40, 19.79f, 1 },
                    { 19, 40, 35.39f, 4 },
                    { 26, 62, 14.9f, 4 },
                    { 61, 62, 35.55f, 2 },
                    { 96, 62, 44.84f, 1 },
                    { 39, 27, 36.76f, 2 },
                    { 96, 27, 34.08f, 1 },
                    { 64, 27, 49.24f, 3 },
                    { 14, 27, 16.9f, 1 },
                    { 14, 98, 10.02f, 4 },
                    { 88, 98, 37.79f, 1 },
                    { 72, 98, 1.48f, 4 },
                    { 38, 65, 7.84f, 0 },
                    { 31, 98, 48.72f, 0 },
                    { 6, 77, 46.36f, 1 },
                    { 33, 77, 21.82f, 4 },
                    { 43, 77, 25.18f, 1 },
                    { 57, 47, 25.57f, 4 },
                    { 55, 47, 28.27f, 0 },
                    { 2, 47, 28.85f, 2 },
                    { 69, 47, 42.91f, 2 },
                    { 93, 47, 35.1f, 3 },
                    { 35, 47, 47.17f, 2 },
                    { 59, 47, 27.85f, 1 },
                    { 6, 98, 8.03f, 1 },
                    { 56, 23, 24.37f, 1 },
                    { 88, 65, 35.64f, 1 },
                    { 48, 65, 11.08f, 4 },
                    { 6, 29, 49.44f, 2 },
                    { 81, 76, 14.42f, 2 },
                    { 6, 76, 22.22f, 1 },
                    { 4, 76, 35.02f, 1 },
                    { 76, 76, 3.82f, 4 },
                    { 51, 76, 28.67f, 3 },
                    { 8, 76, 45.1f, 0 },
                    { 18, 76, 39.44f, 2 },
                    { 65, 70, 13.51f, 2 },
                    { 74, 70, 41.92f, 0 },
                    { 49, 70, 46.58f, 3 },
                    { 11, 70, 13.04f, 3 },
                    { 94, 70, 5.08f, 3 },
                    { 4, 31, 20.09f, 2 },
                    { 17, 31, 12.71f, 1 },
                    { 46, 31, 7.22f, 3 },
                    { 86, 31, 33.98f, 4 },
                    { 1, 96, 34.17f, 1 },
                    { 58, 96, 3.46f, 1 },
                    { 42, 96, 23.62f, 0 },
                    { 32, 96, 19.94f, 2 },
                    { 8, 29, 40.41f, 4 },
                    { 1, 29, 4.75f, 3 },
                    { 65, 29, 38.83f, 3 },
                    { 62, 29, 28.4f, 1 },
                    { 51, 65, 3.66f, 3 },
                    { 74, 65, 14.41f, 2 },
                    { 21, 65, 12.99f, 0 },
                    { 45, 60, 38.12f, 1 },
                    { 16, 60, 46.56f, 0 },
                    { 72, 60, 34.51f, 0 },
                    { 21, 60, 5.92f, 0 },
                    { 58, 60, 7.99f, 3 },
                    { 36, 60, 29.14f, 3 },
                    { 42, 60, 37.9f, 3 },
                    { 79, 65, 25.52f, 3 },
                    { 84, 60, 19.95f, 1 },
                    { 30, 64, 41.05f, 3 },
                    { 66, 64, 14.77f, 2 },
                    { 18, 53, 13.89f, 2 },
                    { 58, 53, 45.12f, 0 },
                    { 33, 53, 22.45f, 1 },
                    { 7, 39, 28.72f, 0 },
                    { 54, 39, 41.75f, 4 },
                    { 38, 39, 42.28f, 2 },
                    { 3, 39, 1.88f, 4 },
                    { 98, 39, 19.45f, 0 },
                    { 37, 64, 48.49f, 3 },
                    { 64, 23, 35.54f, 0 },
                    { 53, 23, 34.22f, 0 },
                    { 28, 23, 40.92f, 2 },
                    { 36, 71, 31.82f, 1 },
                    { 64, 71, 37.23f, 0 },
                    { 94, 71, 4.47f, 0 },
                    { 5, 20, 31.87f, 0 },
                    { 17, 20, 12.56f, 2 },
                    { 30, 20, 19.71f, 0 },
                    { 76, 20, 15.2f, 0 },
                    { 23, 20, 6.23f, 3 },
                    { 26, 20, 21.85f, 0 },
                    { 9, 20, 42.44f, 3 },
                    { 37, 20, 16.05f, 3 },
                    { 59, 22, 24.49f, 0 },
                    { 6, 22, 48.2f, 1 },
                    { 7, 22, 12.89f, 1 },
                    { 26, 22, 15.99f, 0 },
                    { 86, 22, 21.65f, 2 },
                    { 60, 83, 29.74f, 1 },
                    { 97, 83, 17.79f, 3 },
                    { 46, 83, 20.92f, 3 },
                    { 45, 83, 3.56f, 2 },
                    { 66, 83, 45.6f, 1 },
                    { 96, 71, 22.27f, 3 },
                    { 14, 97, 33.23f, 1 },
                    { 49, 97, 35.74f, 3 },
                    { 1, 97, 18.33f, 3 },
                    { 10, 44, 30.97f, 0 },
                    { 68, 44, 11.97f, 3 },
                    { 52, 44, 37.64f, 0 },
                    { 42, 44, 39.54f, 0 },
                    { 74, 44, 2.43f, 3 },
                    { 98, 44, 31.36f, 3 },
                    { 78, 44, 32.6f, 1 },
                    { 14, 92, 21.17f, 3 },
                    { 41, 92, 10.37f, 4 },
                    { 93, 92, 45.07f, 2 },
                    { 91, 83, 19.05f, 3 },
                    { 38, 92, 15.3f, 2 },
                    { 85, 84, 7.75f, 1 },
                    { 72, 84, 1.77f, 4 },
                    { 76, 58, 29.12f, 0 },
                    { 7, 58, 46.09f, 2 },
                    { 84, 58, 28.29f, 4 },
                    { 94, 58, 7.35f, 3 },
                    { 15, 58, 10.53f, 4 },
                    { 8, 58, 8.51f, 2 },
                    { 13, 97, 49.09f, 1 },
                    { 5, 97, 34.74f, 3 },
                    { 15, 84, 37.08f, 1 },
                    { 18, 44, 12.18f, 4 },
                    { 83, 83, 44.79f, 4 },
                    { 18, 74, 16.68f, 0 },
                    { 26, 89, 41.83f, 3 },
                    { 2, 89, 2.63f, 4 },
                    { 53, 89, 39.96f, 1 },
                    { 24, 89, 35.91f, 0 },
                    { 60, 89, 39.46f, 0 },
                    { 82, 79, 7.54f, 0 },
                    { 64, 79, 31.14f, 4 },
                    { 4, 79, 45.99f, 2 },
                    { 54, 79, 37.24f, 1 },
                    { 94, 79, 42.09f, 0 },
                    { 70, 79, 14f, 1 },
                    { 12, 50, 37.94f, 2 },
                    { 31, 50, 37.03f, 4 },
                    { 81, 50, 13.76f, 4 },
                    { 98, 50, 11.67f, 0 },
                    { 34, 50, 22.1f, 0 },
                    { 99, 50, 12.55f, 2 },
                    { 97, 50, 30.56f, 2 },
                    { 18, 85, 15.64f, 2 },
                    { 75, 85, 16.35f, 0 },
                    { 44, 85, 17.79f, 1 },
                    { 55, 89, 35.9f, 2 },
                    { 42, 89, 47.71f, 3 },
                    { 77, 67, 45.89f, 3 },
                    { 17, 67, 8.42f, 1 },
                    { 98, 74, 48.7f, 0 },
                    { 60, 74, 28.36f, 2 },
                    { 22, 74, 42.33f, 2 },
                    { 13, 74, 2.85f, 0 },
                    { 37, 74, 17.61f, 0 },
                    { 31, 63, 45.14f, 2 },
                    { 84, 63, 32.87f, 1 },
                    { 62, 63, 33.93f, 4 },
                    { 22, 54, 33.15f, 1 },
                    { 41, 54, 22.95f, 0 },
                    { 7, 83, 22.91f, 0 },
                    { 90, 54, 43.23f, 1 },
                    { 46, 54, 18.78f, 2 },
                    { 69, 54, 11.78f, 1 },
                    { 56, 54, 32.38f, 2 },
                    { 86, 46, 5.93f, 1 },
                    { 60, 46, 31.09f, 0 },
                    { 36, 46, 15.29f, 0 },
                    { 4, 46, 18.11f, 0 },
                    { 55, 46, 25.02f, 2 },
                    { 44, 67, 48.08f, 3 },
                    { 48, 67, 7.04f, 1 },
                    { 61, 54, 11.77f, 0 },
                    { 97, 62, 9.64f, 0 },
                    { 66, 19, 44.97f, 2 },
                    { 48, 19, 11.74f, 2 },
                    { 23, 43, 43.82f, 1 },
                    { 94, 43, 13.52f, 2 },
                    { 21, 43, 11.06f, 2 },
                    { 4, 95, 11.35f, 1 },
                    { 69, 95, 22.74f, 0 },
                    { 57, 95, 16.99f, 3 },
                    { 56, 95, 24.81f, 1 },
                    { 82, 95, 27.98f, 2 },
                    { 69, 66, 16.52f, 0 },
                    { 67, 66, 44.59f, 4 },
                    { 39, 66, 36.53f, 0 },
                    { 24, 66, 21f, 1 },
                    { 23, 66, 32.55f, 2 },
                    { 64, 66, 47.95f, 2 },
                    { 72, 66, 33.22f, 2 },
                    { 52, 55, 23.1f, 3 },
                    { 28, 55, 30.95f, 3 },
                    { 41, 55, 42.01f, 4 },
                    { 12, 55, 30.79f, 1 },
                    { 34, 55, 25.69f, 1 },
                    { 81, 16, 36.81f, 4 },
                    { 76, 43, 41.84f, 1 },
                    { 46, 43, 18.71f, 3 },
                    { 71, 43, 2.58f, 3 },
                    { 15, 43, 12.78f, 3 },
                    { 11, 23, 14.69f, 4 },
                    { 64, 78, 13.28f, 2 },
                    { 6, 78, 3.54f, 3 },
                    { 70, 78, 6.19f, 3 },
                    { 91, 78, 4.15f, 2 },
                    { 9, 78, 5.07f, 1 },
                    { 32, 28, 35.96f, 4 },
                    { 37, 28, 26.2f, 0 },
                    { 30, 28, 39.63f, 2 },
                    { 76, 28, 33.26f, 2 },
                    { 61, 16, 36.64f, 0 },
                    { 17, 82, 47.75f, 3 },
                    { 3, 82, 26.5f, 4 },
                    { 98, 82, 2.49f, 2 },
                    { 51, 82, 36.58f, 0 },
                    { 30, 82, 18.76f, 2 },
                    { 80, 82, 47.96f, 0 },
                    { 99, 82, 7.68f, 0 },
                    { 71, 93, 30.09f, 2 },
                    { 51, 93, 40.16f, 0 },
                    { 19, 93, 34.65f, 1 },
                    { 16, 93, 14.38f, 4 },
                    { 89, 82, 49.9f, 3 },
                    { 25, 19, 18.68f, 0 },
                    { 37, 16, 9.79f, 4 },
                    { 28, 16, 18.76f, 2 },
                    { 46, 61, 40.15f, 3 },
                    { 45, 61, 39.31f, 4 },
                    { 26, 61, 4.9f, 1 },
                    { 99, 61, 12.96f, 3 },
                    { 82, 52, 4.19f, 4 },
                    { 36, 52, 35.78f, 2 },
                    { 11, 52, 31.52f, 1 },
                    { 46, 52, 33.35f, 1 },
                    { 71, 52, 5.55f, 1 },
                    { 14, 52, 4.26f, 3 },
                    { 35, 52, 40.25f, 2 },
                    { 70, 52, 42.98f, 1 },
                    { 25, 69, 2.88f, 4 },
                    { 55, 69, 10.99f, 4 },
                    { 9, 69, 5.44f, 0 },
                    { 18, 69, 3.49f, 3 },
                    { 73, 69, 32.63f, 4 },
                    { 53, 69, 32.07f, 0 },
                    { 70, 69, 9.83f, 1 },
                    { 32, 19, 37.71f, 2 },
                    { 98, 19, 41.01f, 3 },
                    { 25, 61, 36.85f, 3 },
                    { 3, 61, 1.73f, 3 },
                    { 1, 81, 30.04f, 4 },
                    { 69, 81, 15.62f, 4 },
                    { 14, 16, 21.79f, 3 },
                    { 62, 17, 40.2f, 4 },
                    { 21, 17, 19.28f, 0 },
                    { 55, 17, 40.66f, 2 },
                    { 79, 17, 36.7f, 4 },
                    { 78, 17, 19.64f, 3 },
                    { 74, 17, 7.93f, 0 },
                    { 70, 17, 2.95f, 4 },
                    { 69, 17, 28.98f, 2 },
                    { 61, 17, 33.46f, 3 },
                    { 52, 16, 44.84f, 1 },
                    { 17, 49, 39.37f, 4 },
                    { 2, 49, 12.11f, 1 },
                    { 21, 49, 49.77f, 2 },
                    { 26, 99, 17.21f, 3 },
                    { 62, 99, 4.22f, 3 },
                    { 72, 99, 46.35f, 2 },
                    { 77, 99, 22.3f, 1 },
                    { 24, 99, 15.98f, 0 },
                    { 41, 81, 24.48f, 1 },
                    { 34, 81, 23.58f, 1 },
                    { 16, 81, 43.02f, 1 },
                    { 12, 49, 43.83f, 1 },
                    { 38, 62, 29.83f, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 1 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 47, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 2 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 3 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 4 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 5 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 6 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 7 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 8 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 9 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 10 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 67, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 11 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 12 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 13 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 14 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 15 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 16 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 79, 17 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 18 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 19 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 20 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 21 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 22 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 23 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 24 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 25 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 80, 26 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 27 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 28 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 29 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 30 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 31 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 27, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 32 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 29, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 91, 33 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 34 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 95, 35 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 36 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 80, 37 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 38 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 39 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 40 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 50, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 77, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 41 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 42 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 43 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 68, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 44 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 45 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 86, 46 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 93, 47 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 100, 48 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 49 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 50 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 73, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 51 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 52 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 53 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 54 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 55 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 56 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 28, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 52, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 57 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 58 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 59, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 80, 59 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 60 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 61 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 62 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 84, 63 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 64 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 21, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 78, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 79, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 65 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 39, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 67, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 66 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 48, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 77, 67 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 68 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 25, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 73, 69 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 70 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 71 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 36, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 72 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 73 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 22, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 74 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 23, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 35, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 63, 75 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 76, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 81, 76 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 33, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 43, 77 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 91, 78 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 54, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 64, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 70, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 79 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 11, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 80 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 34, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 81 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 3, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 17, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 30, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 80, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 82 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 7, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 45, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 46, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 83, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 91, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 83 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 15, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 84 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 12, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 18, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 75, 85 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 40, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 77, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 85, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 86 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 65, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 66, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 97, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 87 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 61, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 87, 88 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 2, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 55, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 60, 89 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 53, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 89, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 94, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 96, 90 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 9, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 10, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 98, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 99, 91 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 38, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 41, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 93, 92 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 51, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 93 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 20, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 37, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 43, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 71, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 92, 94 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 4, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 56, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 57, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 69, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 82, 95 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 16, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 32, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 42, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 58, 96 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 1, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 5, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 13, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 49, 97 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 14, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 31, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 88, 98 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 24, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 26, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 62, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 72, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 77, 99 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 8, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 19, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 44, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 74, 100 });

            migrationBuilder.DeleteData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 90, 100 });

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Salata" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Palacinke" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Waffle" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Hamburger" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Sendvic" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Torta" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pita" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2018, 8, 6, 8, 30, 52, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Sladoled" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Jela s rostilja" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2000, 4, 4, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 11, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Peciva" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Brasno", 18.4f, 25f, 0.000736f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Mlijeko", 10.3f, 15f, 3, 0.0006866667f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Secer", 5.5f, 250f, 0.022f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Maslac", 20f, 2f, 0, 0.01f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Mlijecna cokolada", 10f, 500f, 1, 0.02f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Crna cokolada", 17.4f, 500f, 1, 0.0348f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Jaje", 3.6f, 10f, 4, 0.36f });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CreatedBy", "ModifiedAt", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit", "UnitPrice" },
                values: new object[] { new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Voda", 1.2f, 1f, 3, 0.0012f });

            migrationBuilder.UpdateData(
                table: "RecipeIngredients",
                keyColumns: new[] { "IngredientId", "RecipeId" },
                keyValues: new object[] { 6, 3 },
                columns: new[] { "Quantity", "Unit" },
                values: new object[] { 1.7f, 0 });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 1, 10, 5f, 1 },
                    { 2, 1, 2.5f, 3 },
                    { 3, 1, 500f, 1 },
                    { 4, 2, 20f, 1 },
                    { 8, 2, 350f, 2 },
                    { 7, 3, 4f, 4 },
                    { 5, 3, 400f, 1 },
                    { 8, 9, 70f, 2 },
                    { 8, 5, 1.1f, 3 },
                    { 4, 5, 125f, 1 },
                    { 7, 5, 1f, 4 },
                    { 2, 6, 50f, 2 },
                    { 5, 6, 15f, 1 },
                    { 1, 4, 275f, 1 },
                    { 4, 7, 80f, 1 },
                    { 6, 7, 3.2f, 0 },
                    { 7, 10, 2f, 4 },
                    { 5, 11, 100f, 1 },
                    { 4, 11, 740f, 1 },
                    { 5, 12, 100f, 1 },
                    { 4, 12, 740f, 1 },
                    { 1, 1, 2f, 0 },
                    { 3, 9, 1.9f, 0 },
                    { 4, 9, 20f, 1 },
                    { 2, 9, 2f, 3 },
                    { 7, 8, 3f, 4 },
                    { 2, 8, 1f, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Fini cokoladni kolac.", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Cokoladni kolac" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Osvjezavajuci bijeli kolac", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Bijeli kolac" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac koji ima kokos", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Rafaelo" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac koji ima ferrero roche (samo u imenu)", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Ferrero" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac napravljen s jabukama", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac s jagodama" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac napravljen s jagodama", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac s jabukama" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac za djecu", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kinder" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Dva kolaca u jednom", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Twix" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac s ljesnacima i karamelom", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Snickers" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(1999, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Kolac s orahom", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Orah" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedAt", "Description", "ModifiedAt", "Name" },
                values: new object[] { 7, new DateTime(1998, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified), "Ovaj kolac sluzi za pokazivanje funkcionalnosti load more buttona", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Specijalitet kuce" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedAt", "CreatedBy", "Description", "ModifiedAt", "Name" },
                values: new object[] { 3, new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified), 1, "Dummy Description", new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Dummy recept" });
        }
    }
}
