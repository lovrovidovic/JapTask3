using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace services.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Recipes");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Salata" },
                    { 11, new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified), "Jela s rostilja" },
                    { 10, new DateTime(2018, 8, 6, 8, 30, 52, 0, DateTimeKind.Unspecified), "Sladoled" },
                    { 9, new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pizza" },
                    { 8, new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified), "Pita" },
                    { 7, new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac" },
                    { 12, new DateTime(2000, 4, 4, 8, 30, 52, 0, DateTimeKind.Unspecified), "Peciva" },
                    { 5, new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified), "Sendvic" },
                    { 4, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Hamburger" },
                    { 3, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Waffle" },
                    { 2, new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), "Palacinke" },
                    { 6, new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Torta" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "NormativePrice", "NormativeQuantity", "NormativeUnit" },
                values: new object[,]
                {
                    { 1, "Brasno", 18.4f, 25f, 0 },
                    { 2, "Mlijeko", 10.3f, 15f, 3 },
                    { 3, "Secer", 5.5f, 250f, 1 },
                    { 4, "Maslac", 20f, 2f, 0 },
                    { 5, "Mlijecna cokolada", 10f, 500f, 1 },
                    { 6, "Crna cokolada", 17.4f, 500f, 1 },
                    { 7, "Jaje", 3.6f, 10f, 4 },
                    { 8, "Voda", 1.2f, 1f, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 2, "sifra", "Mark" },
                    { 1, "123", "user" },
                    { 3, "lozinka", "John" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2008, 5, 19, 8, 30, 52, 0, DateTimeKind.Unspecified), "Fini cokoladni kolac.", "Cokoladni kolac", 1 },
                    { 4, 7, new DateTime(2021, 10, 30, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac koji ima ferrero roche (samo u imenu)", "Ferrero", 1 },
                    { 9, 7, new DateTime(2020, 4, 14, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac s ljesnacima i karamelom", "Snickers", 1 },
                    { 11, 7, new DateTime(1998, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified), "Ovaj kolac sluzi za pokazivanje funkcionalnosti load more buttona", "Specijalitet kuce", 1 },
                    { 12, 3, new DateTime(2017, 7, 9, 8, 30, 52, 0, DateTimeKind.Unspecified), "Dummy Description", "Dummy recept", 1 },
                    { 2, 7, new DateTime(2009, 6, 12, 8, 30, 52, 0, DateTimeKind.Unspecified), "Osvjezavajuci bijeli kolac", "Bijeli kolac", 2 },
                    { 5, 7, new DateTime(2001, 5, 16, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac napravljen s jabukama", "Kolac s jagodama", 2 },
                    { 8, 7, new DateTime(2020, 5, 8, 8, 30, 52, 0, DateTimeKind.Unspecified), "Dva kolaca u jednom", "Twix", 2 },
                    { 10, 7, new DateTime(1999, 8, 10, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac s orahom", "Orah", 2 },
                    { 3, 7, new DateTime(2018, 12, 21, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac koji ima kokos", "Rafaelo", 3 },
                    { 6, 7, new DateTime(2005, 1, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac napravljen s jagodama", "Kolac s jabukama", 3 },
                    { 7, 7, new DateTime(2021, 11, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), "Kolac za djecu", "Kinder", 3 }
                });

            migrationBuilder.InsertData(
                table: "RecipeIngredients",
                columns: new[] { "IngredientId", "RecipeId", "Quantity", "Unit" },
                values: new object[,]
                {
                    { 1, 1, 2f, 0 },
                    { 5, 6, 15f, 1 },
                    { 2, 6, 50f, 2 },
                    { 6, 3, 1.7f, 0 },
                    { 5, 3, 400f, 1 },
                    { 7, 3, 4f, 4 },
                    { 7, 10, 2f, 4 },
                    { 1, 10, 5f, 1 },
                    { 7, 8, 3f, 4 },
                    { 2, 8, 1f, 3 },
                    { 7, 5, 1f, 4 },
                    { 4, 5, 125f, 1 },
                    { 8, 5, 1.1f, 3 },
                    { 8, 2, 350f, 2 },
                    { 4, 2, 20f, 1 },
                    { 4, 12, 740f, 1 },
                    { 5, 12, 100f, 1 },
                    { 4, 11, 740f, 1 },
                    { 5, 11, 100f, 1 },
                    { 8, 9, 70f, 2 },
                    { 4, 9, 20f, 1 },
                    { 3, 9, 1.9f, 0 },
                    { 2, 9, 2f, 3 },
                    { 1, 4, 275f, 1 },
                    { 3, 1, 500f, 1 },
                    { 2, 1, 2.5f, 3 },
                    { 6, 7, 3.2f, 0 },
                    { 4, 7, 80f, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

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
                keyValues: new object[] { 6, 3 });

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

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "TotalCost",
                table: "Recipes",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
