using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructure.Persistence.Migrations
{
    public partial class DomesticExpense_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenses_ExpenseTypes_ConceptId",
                table: "Expenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExpenseTypes",
                table: "ExpenseTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses");

            migrationBuilder.RenameTable(
                name: "ExpenseTypes",
                newName: "Concept");

            migrationBuilder.RenameTable(
                name: "Expenses",
                newName: "Transaction");

            migrationBuilder.RenameIndex(
                name: "IX_Expenses_ConceptId",
                table: "Transaction",
                newName: "IX_Transaction_ConceptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Concept",
                table: "Concept",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Concept_ConceptId",
                table: "Transaction",
                column: "ConceptId",
                principalTable: "Concept",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Concept_ConceptId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Concept",
                table: "Concept");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Expenses");

            migrationBuilder.RenameTable(
                name: "Concept",
                newName: "ExpenseTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_ConceptId",
                table: "Expenses",
                newName: "IX_Expenses_ConceptId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenses",
                table: "Expenses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExpenseTypes",
                table: "ExpenseTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenses_ExpenseTypes_ConceptId",
                table: "Expenses",
                column: "ConceptId",
                principalTable: "ExpenseTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
