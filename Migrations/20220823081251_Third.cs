using Microsoft.EntityFrameworkCore.Migrations;

namespace CustomerMicroservice.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Requirements_RequirementPropertyId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_RequirementPropertyId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RequirementPropertyId",
                table: "Customers");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PropertyId",
                table: "Customers",
                column: "PropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Requirements_PropertyId",
                table: "Customers",
                column: "PropertyId",
                principalTable: "Requirements",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Requirements_PropertyId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PropertyId",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "RequirementPropertyId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RequirementPropertyId",
                table: "Customers",
                column: "RequirementPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Requirements_RequirementPropertyId",
                table: "Customers",
                column: "RequirementPropertyId",
                principalTable: "Requirements",
                principalColumn: "PropertyId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
