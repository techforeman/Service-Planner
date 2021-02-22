using Microsoft.EntityFrameworkCore.Migrations;

namespace ServicePlanner.DataAccess.Migrations
{
    public partial class AddCategoryToMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Method",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Method_CategoryId",
                table: "Method",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Method_Category_CategoryId",
                table: "Method",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Method_Category_CategoryId",
                table: "Method");

            migrationBuilder.DropIndex(
                name: "IX_Method_CategoryId",
                table: "Method");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Method");
        }
    }
}
