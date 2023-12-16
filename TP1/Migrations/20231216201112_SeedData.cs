using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TP1.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "GenreString" },
                values: new object[,]
                {
                    { "1", "Ficção Científica" },
                    { "10", "Biografia" },
                    { "2", "Fantasia" },
                    { "3", "Mistério" },
                    { "4", "Suspense" },
                    { "5", "Romance" },
                    { "6", "Ficção Histórica" },
                    { "7", "Aventura" },
                    { "8", "Terror" },
                    { "9", "Não Ficção" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CreationDate", "FreeDelivery", "GenreID", "ImageUri", "Name", "Price" },
                values: new object[,]
                {
                    { "10", "Cormac McCarthy", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", "/assets/covers/the_road.jpg", "The Road", 20.75 },
                    { "3", "F. Scott Fitzgerald", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "5", "/assets/covers/the_great_gatsby.jpg", "The Great Gatsby", 24.989999999999998 },
                    { "4", "Virginia Woolf", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "6", "/assets/covers/to_the_lighthouse.jpg", "To the Lighthouse", 17.75 },
                    { "5", "J.D. Salinger", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5", "/assets/covers/the_catcher_in_the_rye.jpg", "The Catcher in the Rye", 19.5 },
                    { "6", "J.R.R. Tolkien", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "2", "/assets/covers/the_hobbit.jpg", "The Hobbit", 29.0 },
                    { "7", "Jane Austen", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "5", "/assets/covers/pride_and_prejudice.jpg", "Pride and Prejudice", 23.989999999999998 },
                    { "8", "Stephen King", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8", "/assets/covers/the_shining.jpg", "The Shining", 26.5 },
                    { "9", "Aldous Huxley", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "1", "/assets/covers/brave_new_world.jpg", "Brave New World", 22.989999999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: "8");
        }
    }
}
