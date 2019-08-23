using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShelterAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "breeds",
                columns: table => new
                {
                    BreedId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_breeds", x => x.BreedId);
                });

            migrationBuilder.CreateTable(
                name: "animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Admission = table.Column<DateTime>(nullable: false),
                    ImageURL = table.Column<string>(nullable: true),
                    BreedId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animals", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_animals_breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "breeds",
                        principalColumn: "BreedId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_animals_BreedId",
                table: "animals",
                column: "BreedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "animals");

            migrationBuilder.DropTable(
                name: "breeds");
        }
    }
}
