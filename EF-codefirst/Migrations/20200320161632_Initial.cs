using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_codefirst.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    id_object = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    path = table.Column<string>(nullable: true),
                    event_ = table.Column<string>(nullable: true),
                    landscape = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    date_created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.id_object);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id_person = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_object = table.Column<int>(nullable: false),
                    gender = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    Itemid_object = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.id_person);
                    table.ForeignKey(
                        name: "FK_Persons_Items_Itemid_object",
                        column: x => x.Itemid_object,
                        principalTable: "Items",
                        principalColumn: "id_object",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_Itemid_object",
                table: "Persons",
                column: "Itemid_object");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
