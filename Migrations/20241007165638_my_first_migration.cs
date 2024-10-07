using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksHotelFullRestAPI.Migrations
{
    /// <inheritdoc />
    public partial class my_first_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "bookings",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_id = table.Column<int>(type: "int", nullable: false),
                    guest_id = table.Column<int>(type: "int", nullable: false),
                    employee_id = table.Column<int>(type: "int", nullable: false),
                    start_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    total_cost = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookings", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "guests",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    identification_number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    phone_number = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    birthdate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guests", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "room_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_room_types", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    room_number = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    room_type_id = table.Column<int>(type: "int", nullable: false),
                    price_per_night = table.Column<double>(type: "double", nullable: false),
                    availability = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    max_occupancy_person = table.Column<byte>(type: "tinyint unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_rooms_room_types_room_type_id",
                        column: x => x.room_type_id,
                        principalTable: "room_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "bookings",
                columns: new[] { "id", "employee_id", "end_date", "guest_id", "room_id", "start_date", "total_cost" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 275.0 },
                    { 2, 1, new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 640.0 },
                    { 3, 2, new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 5, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 480.0 },
                    { 4, 2, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 7, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.0 },
                    { 5, 3, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 160.0 }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "email", "first_name", "identification_number", "last_name", "password" },
                values: new object[,]
                {
                    { 1, "carlos.sanchez@example.com", "Carlos", "1012345678", "Sánchez", "Hashedpassword1" },
                    { 2, "laura.martinez@example.com", "Laura", "2012345678", "Martínez", "Hashedpassword2" },
                    { 3, "andres.hernandez@example.com", "Andrés", "3012345678", "Hernández", "Hashedpassword_3" },
                    { 4, "marta.jimenez@example.com", "Marta", "4012345678", "Jiménez", "Hashedpassword4" },
                    { 5, "javier.lopez@example.com", "Javier", "5012345678", "López", "Hashedpassword5" },
                    { 6, "valentina.gutierrez@example.com", "Valentina", "6012345678", "Gutiérrez", "Hashedpassword6" },
                    { 7, "diego.torres@example.com", "Diego", "7012345678", "Torres", "Hashedpassword7" }
                });

            migrationBuilder.InsertData(
                table: "guests",
                columns: new[] { "id", "birthdate", "email", "first_name", "identification_number", "last_name", "phone_number" },
                values: new object[,]
                {
                    { 1, new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "juan.perez@example.com", "Juan", "123456789", "Pérez", "3001234567" },
                    { 2, new DateTime(1990, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ana.garcia@example.com", "Ana", "987654321", "García", "3109876543" },
                    { 3, new DateTime(1988, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "luis.martinez@example.com", "Luis", "456789123", "Martínez", "3145678912" },
                    { 4, new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria.lopez@example.com", "María", "321654987", "López", "3159876543" }
                });

            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "Habitación básica con una cama individual", "Simple" },
                    { 2, "Habitación con dos camas individuales o una cama doble", "Doble" },
                    { 3, "Habitación lujosa con cama king size y sala de estar", "Suite" },
                    { 4, "Habitación espaciosa con varias camas para familias", "Familiar" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_person", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, (byte)1, 55.0, "501", 1 },
                    { 2, false, (byte)1, 60.0, "502", 1 },
                    { 3, true, (byte)2, 85.0, "503", 2 },
                    { 4, false, (byte)2, 90.0, "504", 2 },
                    { 5, true, (byte)2, 160.0, "505", 3 },
                    { 6, true, (byte)2, 165.0, "506", 3 },
                    { 7, true, (byte)4, 220.0, "507", 4 },
                    { 8, false, (byte)4, 225.0, "508", 4 },
                    { 9, true, (byte)1, 58.0, "509", 1 },
                    { 10, true, (byte)1, 62.0, "510", 1 },
                    { 11, true, (byte)1, 65.0, "601", 1 },
                    { 12, false, (byte)1, 60.0, "602", 1 },
                    { 13, true, (byte)1, 75.0, "603", 1 },
                    { 14, false, (byte)1, 70.0, "604", 1 },
                    { 15, true, (byte)1, 80.0, "605", 1 },
                    { 16, true, (byte)1, 85.0, "606", 1 },
                    { 17, true, (byte)2, 95.0, "607", 2 },
                    { 18, true, (byte)2, 100.0, "608", 2 },
                    { 19, true, (byte)2, 105.0, "609", 2 },
                    { 20, false, (byte)2, 92.0, "610", 2 },
                    { 21, true, (byte)2, 98.0, "701", 2 },
                    { 22, true, (byte)2, 110.0, "702", 2 },
                    { 23, true, (byte)2, 115.0, "703", 2 },
                    { 24, false, (byte)2, 105.0, "704", 2 },
                    { 25, true, (byte)2, 170.0, "705", 3 },
                    { 26, true, (byte)2, 175.0, "706", 3 },
                    { 27, true, (byte)2, 160.0, "707", 3 },
                    { 28, false, (byte)2, 180.0, "708", 3 },
                    { 29, true, (byte)2, 190.0, "709", 3 },
                    { 30, true, (byte)2, 195.0, "710", 3 },
                    { 31, true, (byte)2, 200.0, "801", 3 },
                    { 32, true, (byte)2, 205.0, "802", 3 },
                    { 33, true, (byte)4, 240.0, "803", 4 },
                    { 34, false, (byte)4, 250.0, "804", 4 },
                    { 35, true, (byte)4, 260.0, "805", 4 },
                    { 36, true, (byte)4, 255.0, "806", 4 },
                    { 37, false, (byte)4, 265.0, "807", 4 },
                    { 38, true, (byte)4, 275.0, "808", 4 },
                    { 39, true, (byte)4, 280.0, "809", 4 },
                    { 40, true, (byte)4, 290.0, "810", 4 },
                    { 41, false, (byte)4, 300.0, "811", 4 },
                    { 42, true, (byte)4, 310.0, "812", 4 },
                    { 43, true, (byte)4, 320.0, "813", 4 },
                    { 44, true, (byte)4, 330.0, "814", 4 },
                    { 45, true, (byte)4, 340.0, "815", 4 },
                    { 46, false, (byte)4, 350.0, "816", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_rooms_room_type_id",
                table: "rooms",
                column: "room_type_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookings");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "guests");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "room_types");
        }
    }
}
