using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurgerApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changing_models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IncludeFries",
                table: "OrderBurger");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Burgers");

            migrationBuilder.AddColumn<bool>(
                name: "HasFries",
                table: "Burgers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegan",
                table: "Burgers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsVegeterian",
                table: "Burgers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HasFries", "IsVegan", "IsVegeterian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HasFries", "IsVegan", "IsVegeterian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HasFries", "IsVegan", "IsVegeterian" },
                values: new object[] { true, false, false });

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HasFries", "IsVegan", "IsVegeterian" },
                values: new object[] { true, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasFries",
                table: "Burgers");

            migrationBuilder.DropColumn(
                name: "IsVegan",
                table: "Burgers");

            migrationBuilder.DropColumn(
                name: "IsVegeterian",
                table: "Burgers");

            migrationBuilder.AddColumn<bool>(
                name: "IncludeFries",
                table: "OrderBurger",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Burgers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Category",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Category",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Category",
                value: 2);
        }
    }
}
