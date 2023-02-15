using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.ActionType.Data.Migrations
{
    /// <inheritdoc />
    public partial class fkUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionTypes_Users_UserID",
                table: "ActionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ActionTypes_UserID",
                table: "ActionTypes");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ActionTypes");

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypes_CreatedBy",
                table: "ActionTypes",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionTypes_Users_CreatedBy",
                table: "ActionTypes",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionTypes_Users_CreatedBy",
                table: "ActionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ActionTypes_CreatedBy",
                table: "ActionTypes");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "ActionTypes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ActionTypes_UserID",
                table: "ActionTypes",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionTypes_Users_UserID",
                table: "ActionTypes",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
