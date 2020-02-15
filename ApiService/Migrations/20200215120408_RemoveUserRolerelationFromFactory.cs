using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiService.Migrations
{
    public partial class RemoveUserRolerelationFromFactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Factory_FactoryId",
                table: "UserRole");

            migrationBuilder.DropIndex(
                name: "IX_UserRole_FactoryId",
                table: "UserRole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserRole_FactoryId",
                table: "UserRole",
                column: "FactoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Factory_FactoryId",
                table: "UserRole",
                column: "FactoryId",
                principalTable: "Factory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
