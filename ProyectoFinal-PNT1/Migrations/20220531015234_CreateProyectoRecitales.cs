using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoFinal_PNT1.Migrations
{
    public partial class CreateProyectoRecitales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bandas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bandas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCliente = table.Column<string>(nullable: true),
                    dniCliente = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "recitales",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(nullable: true),
                    fecha = table.Column<DateTime>(nullable: false),
                    Bandaid = table.Column<int>(nullable: true),
                    Ticketid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recitales", x => x.id);
                    table.ForeignKey(
                        name: "FK_recitales_bandas_Bandaid",
                        column: x => x.Bandaid,
                        principalTable: "bandas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_recitales_tickets_Ticketid",
                        column: x => x.Ticketid,
                        principalTable: "tickets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_recitales_Bandaid",
                table: "recitales",
                column: "Bandaid");

            migrationBuilder.CreateIndex(
                name: "IX_recitales_Ticketid",
                table: "recitales",
                column: "Ticketid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recitales");

            migrationBuilder.DropTable(
                name: "bandas");

            migrationBuilder.DropTable(
                name: "tickets");
        }
    }
}
