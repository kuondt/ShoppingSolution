using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingSolution.Data.Migrations
{
    public partial class Add_Product_Image_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 7, 28, 16, 10, 8, 82, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(maxLength: 200, nullable: false),
                    Caption = table.Column<string>(maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    SortOrder = table.Column<int>(nullable: false),
                    FileSize = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "2a8bb666-5693-401a-8354-a5c1791c8c4c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "234961eb-17d6-4c00-88c7-e30374acc973", "AQAAAAEAACcQAAAAEFdqv3lPO/nLZ3gq/vf7N5s+imchMS/hfGf6ddzwx20IQhMyNR1JDh6771RahNUIoA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 30, 22, 23, 32, 685, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 7, 28, 16, 10, 8, 82, DateTimeKind.Local).AddTicks(2754),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("7e2de1ee-b97b-4698-abe4-c22a0332b2c9"),
                column: "ConcurrencyStamp",
                value: "dc3ff4af-cab8-4e5e-98c7-cd12aaf4c2d9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("8dd4e4e7-cbb1-4db8-8cd8-3024401afc74"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5dccf20-b933-4393-8058-d3491d3c942a", "AQAAAAEAACcQAAAAEO5zcdKYkTp+J0wfz0ImQu/UzVs4/F+6j6xR/m5CprAFm283gL2bYGmLch0wGQiTfg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 7, 28, 16, 10, 8, 119, DateTimeKind.Local).AddTicks(7738));
        }
    }
}
