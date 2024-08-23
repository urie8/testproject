using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mute_mate.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "category", "image", "question" },
                values: new object[,]
                {
                    { 1, "Colors", "", "What color is this?" },
                    { 2, "Animals", "", "What animal is this?" },
                    { 3, "Letters", "", "What letter is this?" },
                    { 4, "Letters", "", "What letter is this?" },
                    { 5, "Letters", "", "What letter is this?" },
                    { 6, "Letters", "", "What letter is this?" },
                    { 7, "Letters", "", "What letter is this?" },
                    { 8, "Letters", "", "What letter is this?" },
                    { 9, "Letters", "", "What letter is this?" },
                    { 10, "Letters", "", "What letter is this?" },
                    { 11, "Letters", "", "What letter is this?" },
                    { 12, "Letters", "", "What letter is this?" },
                    { 13, "Letters", "", "What letter is this?" },
                    { 14, "Letters", "", "What letter is this?" },
                    { 15, "Letters", "", "What letter is this?" },
                    { 16, "Letters", "", "What letter is this?" },
                    { 17, "Letters", "", "What letter is this?" },
                    { 18, "Letters", "", "What letter is this?" },
                    { 19, "Letters", "", "What letter is this?" },
                    { 20, "Letters", "", "What letter is this?" },
                    { 21, "Letters", "", "What letter is this?" },
                    { 22, "Letters", "", "What letter is this?" },
                    { 23, "Letters", "", "What letter is this?" },
                    { 24, "Letters", "", "What letter is this?" },
                    { 25, "Letters", "", "What letter is this?" },
                    { 26, "Letters", "", "What letter is this?" },
                    { 27, "Letters", "", "What letter is this?" },
                    { 28, "Letters", "", "What letter is this?" },
                    { 29, "Colors", "", "What color is this?" },
                    { 30, "Colors", "", "What color is this?" },
                    { 31, "Colors", "", "What color is this?" },
                    { 32, "Colors", "", "What color is this?" },
                    { 33, "Colors", "", "What color is this?" },
                    { 34, "Colors", "", "What color is this?" },
                    { 35, "Colors", "", "What color is this?" },
                    { 36, "Colors", "", "What color is this?" },
                    { 37, "Colors", "", "What color is this?" }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "id", "answer", "is_correct", "question_id" },
                values: new object[,]
                {
                    { 1, "A", true, 3 },
                    { 2, "B", false, 3 },
                    { 3, "C", false, 3 },
                    { 4, "D", false, 3 },
                    { 5, "N", false, 4 },
                    { 6, "B", true, 4 },
                    { 7, "T", false, 4 },
                    { 8, "F", false, 5 },
                    { 9, "N", false, 5 },
                    { 10, "Z", false, 5 },
                    { 11, "C", true, 5 },
                    { 12, "K", false, 5 },
                    { 13, "D", true, 6 },
                    { 14, "P", false, 6 },
                    { 15, "H", false, 6 },
                    { 16, "R", false, 6 },
                    { 17, "G", false, 7 },
                    { 18, "R", false, 7 },
                    { 19, "I", false, 7 },
                    { 20, "E", true, 7 },
                    { 21, "O", false, 8 },
                    { 22, "F", true, 8 },
                    { 23, "H", false, 8 },
                    { 24, "T", false, 8 },
                    { 25, "M", false, 9 },
                    { 26, "U", false, 9 },
                    { 27, "G", true, 9 },
                    { 28, "E", false, 9 },
                    { 29, "Q", false, 10 },
                    { 30, "H", true, 10 },
                    { 31, "S", false, 10 },
                    { 32, "Y", false, 10 },
                    { 33, "A", false, 11 },
                    { 34, "G", false, 11 },
                    { 35, "L", false, 11 },
                    { 36, "I", true, 11 },
                    { 37, "J", true, 12 },
                    { 38, "W", false, 12 },
                    { 39, "X", false, 12 },
                    { 40, "E", false, 12 },
                    { 41, "J", false, 13 },
                    { 42, "V", false, 13 },
                    { 43, "K", true, 13 },
                    { 44, "N", false, 13 },
                    { 45, "L", true, 14 },
                    { 46, "O", false, 14 },
                    { 47, "T", false, 14 },
                    { 48, "B", false, 14 },
                    { 49, "P", false, 15 },
                    { 50, "M", true, 15 },
                    { 51, "S", false, 15 },
                    { 52, "Z", false, 15 },
                    { 53, "J", false, 16 },
                    { 54, "F", false, 16 },
                    { 55, "U", false, 16 },
                    { 56, "N", true, 16 },
                    { 57, "O", true, 17 },
                    { 58, "Q", false, 17 },
                    { 59, "K", false, 17 },
                    { 60, "H", false, 17 },
                    { 61, "R", false, 18 },
                    { 63, "C", false, 18 },
                    { 64, "P", true, 18 },
                    { 65, "I", false, 18 },
                    { 66, "M", false, 18 },
                    { 67, "Q", true, 19 },
                    { 68, "X", false, 19 },
                    { 69, "W", false, 19 },
                    { 70, "D", false, 20 },
                    { 71, "Y", false, 20 },
                    { 72, "T", false, 20 },
                    { 73, "R", true, 20 },
                    { 74, "´Q", false, 21 },
                    { 75, "Á", false, 21 },
                    { 76, "H", true, 21 },
                    { 77, "I", false, 21 },
                    { 78, "T", true, 22 },
                    { 79, "F", false, 22 },
                    { 80, "N", false, 22 },
                    { 81, "M", false, 22 },
                    { 82, "J", false, 23 },
                    { 83, "X", false, 23 },
                    { 84, "U", true, 23 },
                    { 85, "L", false, 23 },
                    { 86, "O", false, 24 },
                    { 87, "B", false, 24 },
                    { 88, "E", false, 24 },
                    { 89, "V", true, 24 },
                    { 90, "V", false, 25 },
                    { 91, "W", true, 25 },
                    { 92, "G", false, 25 },
                    { 93, "M", false, 25 },
                    { 94, "X", true, 26 },
                    { 95, "K", false, 26 },
                    { 96, "Z", false, 26 },
                    { 97, "H", false, 26 },
                    { 98, "D", false, 27 },
                    { 99, "S", false, 27 },
                    { 100, "U", false, 27 },
                    { 101, "Y", true, 27 },
                    { 102, "Y", false, 28 },
                    { 103, "W", false, 28 },
                    { 104, "V", false, 28 },
                    { 105, "Z", true, 28 },
                    { 106, "Blue", false, 1 },
                    { 107, "Orange", true, 1 },
                    { 108, "Black", false, 1 },
                    { 109, "Red", false, 1 },
                    { 110, "Red", true, 29 },
                    { 111, "White", false, 29 },
                    { 112, "Yellow", false, 29 },
                    { 113, "Purple", false, 29 },
                    { 114, "Orange", false, 30 },
                    { 115, "Green", false, 30 },
                    { 116, "Pink", false, 30 },
                    { 117, "Blue", true, 30 },
                    { 118, "Grey", false, 31 },
                    { 119, "Purple", false, 31 },
                    { 120, "Green", true, 31 },
                    { 121, "White", false, 31 },
                    { 122, "Red", false, 32 },
                    { 123, "Blue", false, 32 },
                    { 124, "Grey", false, 32 },
                    { 125, "Black", true, 32 },
                    { 126, "Green", false, 33 },
                    { 127, "White", true, 33 },
                    { 128, "Black", false, 33 },
                    { 129, "Pink", false, 33 },
                    { 130, "Yellow", false, 34 },
                    { 131, "Orange", false, 34 },
                    { 132, "Pink", true, 34 },
                    { 133, "Grey", false, 34 },
                    { 134, "Green", false, 35 },
                    { 135, "Purple", false, 35 },
                    { 136, "White", false, 35 },
                    { 137, "Yellow", true, 35 },
                    { 138, "Grey", true, 36 },
                    { 139, "Black", false, 36 },
                    { 140, "Orange", false, 36 },
                    { 141, "Red", false, 36 },
                    { 142, "Grey", false, 37 },
                    { 143, "Purple", true, 37 },
                    { 144, "Pink", false, 37 },
                    { 145, "Blue", false, 37 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37);
        }
    }
}
