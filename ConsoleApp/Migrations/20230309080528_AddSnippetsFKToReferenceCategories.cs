using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp.Migrations
{
    public partial class AddSnippetsFKToReferenceCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "snippets");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "snippets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<long>(
                name: "category_id",
                table: "snippets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_snippets_category_id",
                table: "snippets",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_snippets_id",
                table: "snippets",
                column: "id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_snippets_categories_category_id",
                table: "snippets",
                column: "category_id",
                principalTable: "categories",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_snippets_categories_category_id",
                table: "snippets");

            migrationBuilder.DropIndex(
                name: "IX_snippets_category_id",
                table: "snippets");

            migrationBuilder.DropIndex(
                name: "IX_snippets_id",
                table: "snippets");

            migrationBuilder.DropColumn(
                name: "category_id",
                table: "snippets");

            migrationBuilder.AlterColumn<long>(
                name: "id",
                table: "snippets",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "snippets",
                type: "TEXT",
                nullable: true);
        }
    }
}
