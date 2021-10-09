using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.CSharp.JQuery_Ajax_CRUD.Migrations
{
    public partial class INITAL1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TrasactionId",
                table: "Transactions",
                newName: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TransactionId",
                table: "Transactions",
                newName: "TrasactionId");
        }
    }
}
