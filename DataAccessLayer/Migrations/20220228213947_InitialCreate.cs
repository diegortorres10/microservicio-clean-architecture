using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "persons",
                columns: table => new
                {
                    person_id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "NVARCHAR(250)", nullable: false),
                    gender = table.Column<string>(type: "NVARCHAR(50)", nullable: false),
                    age = table.Column<int>(type: "INT", nullable: false),
                    identification = table.Column<string>(type: "NVARCHAR(15)", nullable: false),
                    address = table.Column<string>(type: "NVARCHAR(150)", nullable: false),
                    phone = table.Column<string>(type: "NVARCHAR(15)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_user", x => x.person_id);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    client_id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    password = table.Column<string>(type: "NVARCHAR(25)", nullable: false),
                    state = table.Column<bool>(type: "BIT", nullable: false),
                    PersonId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_client", x => x.client_id);
                    table.ForeignKey(
                        name: "fk_client_account",
                        column: x => x.PersonId,
                        principalTable: "persons",
                        principalColumn: "person_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    account_id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    account_number = table.Column<int>(type: "INT", nullable: false),
                    account_type = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    initial_balance = table.Column<float>(type: "REAL", nullable: false),
                    state = table.Column<bool>(type: "BIT", nullable: false),
                    ClientId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_account", x => x.account_id);
                    table.ForeignKey(
                        name: "fk_account_client",
                        column: x => x.ClientId,
                        principalTable: "clients",
                        principalColumn: "client_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "movements",
                columns: table => new
                {
                    movement_id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    movement_date = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    movement_type = table.Column<string>(type: "NVARCHAR(100)", nullable: false),
                    movement_value = table.Column<float>(type: "REAL", nullable: false),
                    balance = table.Column<float>(type: "REAL", nullable: false),
                    AccountId = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_movement", x => x.movement_id);
                    table.ForeignKey(
                        name: "fk_movement_account",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "account_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_ClientId",
                table: "accounts",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_clients_PersonId",
                table: "clients",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movements_AccountId",
                table: "movements",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movements");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "persons");
        }
    }
}
