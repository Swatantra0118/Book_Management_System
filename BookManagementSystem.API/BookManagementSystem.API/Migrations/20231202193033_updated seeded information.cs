using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class updatedseededinformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3cd31d3c-3bf6-46b0-becd-c78af422b3ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "7c045755-edea-4e4c-af0a-736fbeaec6ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f15710ad-b89e-45d9-90de-eef1fb67c47f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f474c4e0-e75d-478d-bf7a-99655d0aecca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "f474c4e0-e75d-478d-bf7a-99655d0aecca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "fe1378d3-f5cc-4842-9834-1b9c39b7e72f" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("84898149-c2f5-4d44-a926-476198f2ae0e"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9c9a8402-436a-4e66-a7ef-a54d2a59f303"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("13196934-7d5a-4bef-9ef5-589afb1b2196"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("2845a8d0-e269-41bd-b7b3-b3f40e2eb40e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("35c5be02-61f6-40c7-bb7e-603b8a769191"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("c97fe7d4-6292-4d84-ad72-f82830955a94"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cd31d3c-3bf6-46b0-becd-c78af422b3ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c045755-edea-4e4c-af0a-736fbeaec6ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f15710ad-b89e-45d9-90de-eef1fb67c47f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f474c4e0-e75d-478d-bf7a-99655d0aecca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe1378d3-f5cc-4842-9834-1b9c39b7e72f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1241922f-bec4-4cb1-b674-c179ed8cf4ad", 0, "ed9a0d4b-05f6-412f-8c65-279afab4f885", "pranav@test.com", false, false, null, "Pranav", "PRANAV@TEST.COM", "PRANAV@TEST.COM", "AQAAAAIAAYagAAAAEJqNkmrjtB6NauWAVWPZsQVkxYWMZkeg6b8ab+nl2HhHDWTlPSrUIftYnlovNjYjQQ==", null, false, "bb54a61f-4e50-4c95-9def-e0b3b4ce0986", 1, false, "pranav@test.com" },
                    { "15bfaa56-6bd4-46a9-a199-4b323dc4f42e", 0, "3d7167ef-70d7-4934-855b-0b6276ff70cd", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEKb1k7Mfgrg4TayRHrIMknfNkidQdjalY91dY1xJzZ1LaTPRDBdErTmFBIJisUFi6w==", null, false, "5b2379ed-9fae-42bd-ac5d-4f2f01aac6cf", 0, false, "admin@test.com" },
                    { "35628368-97ed-478f-8eaa-271f021b5699", 0, "0b7215ef-2a4e-474d-96ad-8ced4a92aece", "swatantra@test.com", false, false, null, "Swatantra", "SWATANTRA@TEST.COM", "SWATANTRA@TEST.COM", "AQAAAAIAAYagAAAAEHMclQQVa0lhO+63x5ajEQR7tQ/OjOKltettFDy0JcWuuTs1tNxaUvCUG3Z84iAdRg==", null, false, "365e947c-a843-4a87-b727-0e7d821a0007", 1, false, "swatantra@test.com" },
                    { "4293c9ba-6247-4a69-8f3c-562fc8ce158d", 0, "d20394cc-1af8-4e11-b1c1-2e3d0352e5e6", "avinash@test.com", false, false, null, "Avinash", "AVINASH@TEST.COM", "AVINASH@TEST.COM", "AQAAAAIAAYagAAAAENzmEgu2XQSkIZyoD8us0gHzVtKKBIo7YfCyxPD/gir9kD9P+aB5mK2bST/vnGiUxQ==", null, false, "c490d1b9-4155-476b-8bc6-d21d4a94eafe", 1, false, "avinash@test.com" },
                    { "ae2acc87-0a22-4590-8638-09e341d2bc9e", 0, "1e6aa2c2-7b44-4f07-a5a3-028a545af5fc", "abhishek@test.com", false, false, null, "Abhishek", "ABHISHEK@TEST.COM", "ABHISHEK@TEST.COM", "AQAAAAIAAYagAAAAEPX9K7dOJzs64grlMmKbRPHGtjI7Ku9FIUEYIYeUgq+kIMmeJp4gOF9ZHoQ/1gRdpw==", null, false, "cee77915-c39b-48cf-835e-5b63f877a8a6", 1, false, "abhishek@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("899774ac-8253-4182-b9a6-492ec28d86ac"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "15bfaa56-6bd4-46a9-a199-4b323dc4f42e", "Jail Diary", 4.0, "Jail Diary By Bhagat Singh" },
                    { new Guid("8d7056c3-3c9e-46d1-b200-e50183770e70"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "15bfaa56-6bd4-46a9-a199-4b323dc4f42e", "Harry Potter", 5.0, "Harry Potter and the Sorcerer's Stone" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("03b99ed1-8bf0-4078-b090-47b8b3dabf13"), "Science Fiction", "Science Fiction" },
                    { new Guid("134f2a64-db65-472f-9f9a-eaf120abc386"), "Novel", "/Novel" },
                    { new Guid("39612b8b-8506-4343-8cf5-d5e1a3fc2eb9"), "Fantasy", "/Fantasy" },
                    { new Guid("83615b1e-88a4-4263-9a1b-41783606c3ca"), "Others", "/Others" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "1241922f-bec4-4cb1-b674-c179ed8cf4ad" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "15bfaa56-6bd4-46a9-a199-4b323dc4f42e" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "15bfaa56-6bd4-46a9-a199-4b323dc4f42e" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "35628368-97ed-478f-8eaa-271f021b5699" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4293c9ba-6247-4a69-8f3c-562fc8ce158d" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ae2acc87-0a22-4590-8638-09e341d2bc9e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "1241922f-bec4-4cb1-b674-c179ed8cf4ad" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "15bfaa56-6bd4-46a9-a199-4b323dc4f42e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "15bfaa56-6bd4-46a9-a199-4b323dc4f42e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "35628368-97ed-478f-8eaa-271f021b5699" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "4293c9ba-6247-4a69-8f3c-562fc8ce158d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "ae2acc87-0a22-4590-8638-09e341d2bc9e" });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("899774ac-8253-4182-b9a6-492ec28d86ac"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("8d7056c3-3c9e-46d1-b200-e50183770e70"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("03b99ed1-8bf0-4078-b090-47b8b3dabf13"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("134f2a64-db65-472f-9f9a-eaf120abc386"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("39612b8b-8506-4343-8cf5-d5e1a3fc2eb9"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("83615b1e-88a4-4263-9a1b-41783606c3ca"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1241922f-bec4-4cb1-b674-c179ed8cf4ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15bfaa56-6bd4-46a9-a199-4b323dc4f42e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35628368-97ed-478f-8eaa-271f021b5699");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4293c9ba-6247-4a69-8f3c-562fc8ce158d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae2acc87-0a22-4590-8638-09e341d2bc9e");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TokensAvailable", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3cd31d3c-3bf6-46b0-becd-c78af422b3ee", 0, "b0008e97-60ec-43c6-b4dc-39cbad594e82", "abhishek@test.com", false, false, null, "Abhishek", "ABHISHEK@TEST.COM", "ABHISHEK@TEST.COM", "AQAAAAIAAYagAAAAEKDfFIZPuejbddbte0toZVhPxJd+X7S72qKi9lUE23j7IL256+u9JmTPHOVeM3AtuQ==", null, false, "6023f57a-5b78-4e8d-a10b-5e7d8a61ddf0", 1, false, "abhishek@test.com" },
                    { "7c045755-edea-4e4c-af0a-736fbeaec6ea", 0, "01194e4f-e93c-49d1-bec3-a55faa87767b", "avinash@test.com", false, false, null, "Avinash", "AVINASH@TEST.COM", "AVINASH@TEST.COM", "AQAAAAIAAYagAAAAEJ3MbtFyFMnzZuhcUXJsqASCq3zaZu7g+cvekbTbMIDqVxiQNwr0YopJENG/apS64A==", null, false, "1e66f560-ed87-4d5c-a8d2-c3447ebb63d8", 1, false, "avinash@test.com" },
                    { "f15710ad-b89e-45d9-90de-eef1fb67c47f", 0, "0f5553b3-29b6-40e6-a66b-a601a2d3bdf3", "pranav@test.com", false, false, null, "Pranav", "PRANAV@TEST.COM", "PRANAV@TEST.COM", "AQAAAAIAAYagAAAAEHIS/25dChXo/t4+Gebl400QTbt4ql66bJBzETS95chRREG2PgQf90DerdHoCSMQNA==", null, false, "3ac28219-9424-47d2-836b-0daeb19dce07", 1, false, "pranav@test.com" },
                    { "f474c4e0-e75d-478d-bf7a-99655d0aecca", 0, "0fca15a4-2ef9-48bc-997b-f957328cf541", "admin@test.com", false, false, null, "Admin", "ADMIN@TEST.COM", "ADMIN@TEST.COM", "AQAAAAIAAYagAAAAEHXAzQt8Mf2gkA1Z9jzzs8+3Uwb+pskKc0ZCzoyQuFOQosFeyxWi4cnGO3Nbks7TKg==", null, false, "def72360-71cf-4afa-a8d0-10c8bc320d5b", 0, false, "admin@test.com" },
                    { "fe1378d3-f5cc-4842-9834-1b9c39b7e72f", 0, "47f310eb-2f1a-485b-8cf6-f70b858f1c34", "swatantra@test.com", false, false, null, "Swatantra", "SWATANTRA@TEST.COM", "SWATANTRA@TEST.COM", "AQAAAAIAAYagAAAAELH89uPJEQzaaT1/7TAYe9FPMPBQTq+UWmgkLQaa1Kwh04JYfoRz2s0bwq2BOFBr+A==", null, false, "6a78eace-162f-426f-b61d-0051600757b0", 1, false, "swatantra@test.com" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CurrentlyBorrowedByUserId", "Description", "FeaturedImageUrl", "IsAvailable", "LentByUserId", "Name", "Ratings", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("84898149-c2f5-4d44-a926-476198f2ae0e"), "J.K Rolling", null, "Harry Potter and the Sorcerer's Stone, also known as Harry Potter and the Philosopher's Stone outside of the United States, is a fantasy novel written by British author J. K. Rowling. The novel chronicles the lives of a young wizard, Harry Potter, and his friends Hermione Granger and Ron Weasley, all of whom are first-year students at Hogwarts School of Witchcraft and Wizardry. The story covers Harry's first discovery of his magical heritage, his enrollment at Hogwarts, his making of close friends and enemies, and his confrontation with the dark wizard Lord Voldemort. The novel was first published in the United Kingdom by Bloomsbury Ltd. on 26 June 1997.\r\n\r\nA lonely orphan living with his unwelcoming aunt, uncle, and cousin, Harry Potter learns on his eleventh birthday that he is an orphaned wizard and is famous throughout the wizarding world as the boy who survived the attack by Lord Voldemort, a powerful dark wizard who killed Harry's parents in their attempt to thwart his bid for power. Harry is summoned from his life as an unwanted child by his parents' friend Rubeus Hagrid, a giant and Hogwarts' Keeper of Keys and Grounds, who reveals to him that he is a wizard and has been accepted at Hogwarts School of Witchcraft and Wizardry.\r\n\r\nAt Hogwarts, Harry is sorted into Gryffindor House and befriends Ron Weasley and Hermione Granger. Together, they learn about magic, defend themselves from dark creatures, and uncover a plot by Voldemort, who has returned to power and is hiding within the school, to steal the Sorcerer's Stone, a powerful object that would grant him immortality.", "https://images.pexels.com/photos/8391515/pexels-photo-8391515.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", true, "f474c4e0-e75d-478d-bf7a-99655d0aecca", "Harry Potter", 0.0, "Harry Potter and the Sorcerer's Stone" },
                    { new Guid("9c9a8402-436a-4e66-a7ef-a54d2a59f303"), "Bhagat Singh", null, " Bhagat Singh's Jail Diary is a poignant and thought-provoking collection of writings penned by the Indian revolutionary during his imprisonment in Lahore Central Jail from 1929 to 1931. It offers a glimpse into his mind and soul, revealing his deep love for his country, his unwavering commitment to social justice, and his unwavering belief in the power of revolution.  The diary is a tapestry of personal reflections, political treatises, and literary musings, reflecting Singh's multifaceted personality and his wide-ranging intellectual interests. He delves into topics such as imperialism, capitalism, socialism, atheism, and religion, engaging with the ideas of prominent thinkers like Karl Marx, Vladimir Lenin, and Fyodor Dostoevsky.  Singh's writings are characterized by their clarity, passion, and sincerity. He fearlessly exposes the injustices of British rule in India and the plight of the oppressed masses. He calls for a radical transformation of society, advocating for a classless, egalitarian society based on the principles of socialism and communism.  The Jail Diary is not just a historical document; it is a testament to the indomitable spirit of a young man who dared to challenge the status quo and fight for a better world. It continues to inspire and challenge readers, reminding us of the power of individual action and the importance of fighting for what is right.", "https://m.media-amazon.com/images/I/51h5ch+vZIL.jpg", true, "f474c4e0-e75d-478d-bf7a-99655d0aecca", "Jail Diary", 0.0, "Jail Diary By Bhagat Singh" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "UrlHandle" },
                values: new object[,]
                {
                    { new Guid("13196934-7d5a-4bef-9ef5-589afb1b2196"), "Science Fiction", "Science Fiction" },
                    { new Guid("2845a8d0-e269-41bd-b7b3-b3f40e2eb40e"), "Fantasy", "/Fantasy" },
                    { new Guid("35c5be02-61f6-40c7-bb7e-603b8a769191"), "Others", "/Others" },
                    { new Guid("c97fe7d4-6292-4d84-ad72-f82830955a94"), "Novel", "/Novel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "3cd31d3c-3bf6-46b0-becd-c78af422b3ee" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "7c045755-edea-4e4c-af0a-736fbeaec6ea" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f15710ad-b89e-45d9-90de-eef1fb67c47f" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "f474c4e0-e75d-478d-bf7a-99655d0aecca" },
                    { "95cb1e1c-d8b6-45a2-b240-6d211c06fd00", "f474c4e0-e75d-478d-bf7a-99655d0aecca" },
                    { "80ee5384-80a7-4aac-b4c8-b80b7dd25ac1", "fe1378d3-f5cc-4842-9834-1b9c39b7e72f" }
                });
        }
    }
}
