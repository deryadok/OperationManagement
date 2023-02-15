using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Services.Maintenance.Data.Migrations
{
    /// <inheritdoc />
    public partial class fkUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActionType_Users_UserID",
                table: "ActionType");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistories_ActionType_ActionTypeID",
                table: "MaintenanceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistories_Users_UserID",
                table: "MaintenanceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Users_UserID",
                table: "Maintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroups_Users_UserID",
                table: "PictureGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_UserID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_UserID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_PictureGroups_UserID",
                table: "PictureGroups");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_UserID",
                table: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceHistories_UserID",
                table: "MaintenanceHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionType",
                table: "ActionType");

            migrationBuilder.DropIndex(
                name: "IX_ActionType_UserID",
                table: "ActionType");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "PictureGroups");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "MaintenanceHistories");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ActionType");

            migrationBuilder.RenameTable(
                name: "ActionType",
                newName: "ActionTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionTypes",
                table: "ActionTypes",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CreatedBy",
                table: "Vehicles",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PictureGroups_CreatedBy",
                table: "PictureGroups",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_CreatedBy",
                table: "Maintenances",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistories_CreatedBy",
                table: "MaintenanceHistories",
                column: "CreatedBy");

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

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistories_ActionTypes_ActionTypeID",
                table: "MaintenanceHistories",
                column: "ActionTypeID",
                principalTable: "ActionTypes",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistories_Users_CreatedBy",
                table: "MaintenanceHistories",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Users_CreatedBy",
                table: "Maintenances",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroups_Users_CreatedBy",
                table: "PictureGroups",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_CreatedBy",
                table: "Vehicles",
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

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistories_ActionTypes_ActionTypeID",
                table: "MaintenanceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_MaintenanceHistories_Users_CreatedBy",
                table: "MaintenanceHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Maintenances_Users_CreatedBy",
                table: "Maintenances");

            migrationBuilder.DropForeignKey(
                name: "FK_PictureGroups_Users_CreatedBy",
                table: "PictureGroups");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Users_CreatedBy",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_CreatedBy",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_PictureGroups_CreatedBy",
                table: "PictureGroups");

            migrationBuilder.DropIndex(
                name: "IX_Maintenances_CreatedBy",
                table: "Maintenances");

            migrationBuilder.DropIndex(
                name: "IX_MaintenanceHistories_CreatedBy",
                table: "MaintenanceHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ActionTypes",
                table: "ActionTypes");

            migrationBuilder.DropIndex(
                name: "IX_ActionTypes_CreatedBy",
                table: "ActionTypes");

            migrationBuilder.RenameTable(
                name: "ActionTypes",
                newName: "ActionType");

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "PictureGroups",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "MaintenanceHistories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "ActionType",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ActionType",
                table: "ActionType",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_UserID",
                table: "Vehicles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PictureGroups_UserID",
                table: "PictureGroups",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_UserID",
                table: "Maintenances",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceHistories_UserID",
                table: "MaintenanceHistories",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ActionType_UserID",
                table: "ActionType",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ActionType_Users_UserID",
                table: "ActionType",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistories_ActionType_ActionTypeID",
                table: "MaintenanceHistories",
                column: "ActionTypeID",
                principalTable: "ActionType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MaintenanceHistories_Users_UserID",
                table: "MaintenanceHistories",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maintenances_Users_UserID",
                table: "Maintenances",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PictureGroups_Users_UserID",
                table: "PictureGroups",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Users_UserID",
                table: "Vehicles",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
