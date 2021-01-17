using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataLayer.Migrations.ETS
{
    public partial class ETS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ets");

            migrationBuilder.CreateTable(
                name: "persons",
                schema: "ets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    surname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    blood = table.Column<int>(type: "integer", nullable: false),
                    phonenumber = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    address = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_persons", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "ets",
                table: "persons",
                columns: new[] { "id", "address", "blood", "name", "phonenumber", "surname" },
                values: new object[,]
                {
                    { 1, "İstanbul - Üsküdar", 6, "İsim", "05321234567", "Soyisim" },
                    { 2, "İstanbul - Ümraniye", 4, "İsim", "05328901234", "Soyisim" },
                    { 3, "İstanbul - Kadıköy", 8, "İsim", "05325678901", "Soyisim" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "persons",
                schema: "ets");
        }
    }
}
