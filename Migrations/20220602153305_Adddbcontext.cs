using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sweet_Management_Tool.Migrations
{
    public partial class Adddbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Fname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sname",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Institution = table.Column<string>(type: "TEXT", nullable: false),
                    IsAvailable = table.Column<bool>(type: "INTEGER", nullable: false),
                    InUseBy = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "709a40af-4a4e-40b6-887b-d30dcdf07030", "db72e6db-01bf-432b-8675-1d08242bb162", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "78bf8cbe-1f70-4d6d-890b-247bc57e6150", "7b483dfe-e56c-4d5b-97cd-b32652794d29", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "d4e41d27-8605-4e69-8587-2636ed98e286", "Teacher", "TEACHER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Fname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Sname", "TwoFactorEnabled", "UserName" },
                values: new object[] { "27b9af34-a133-43e2-8dd2-aef04ddb2b8c", 0, "7b483dfe-e56c-4d5b-97cd-b32652794d29", "admin@admin.com", false, "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEO42irBWaKrt7I7GyoBuVNxfObF3akb2rfAqwWEyCQ2HnXnMqgjc2iyNE1YmJIAq8g==", null, false, "245416ac-78f4-4444-8611-2eb6572cd1d2", "Admin", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "709a40af-4a4e-40b6-887b-d30dcdf07030", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "78bf8cbe-1f70-4d6d-890b-247bc57e6150", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "709a40af-4a4e-40b6-887b-d30dcdf07030", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "78bf8cbe-1f70-4d6d-890b-247bc57e6150", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02", "27b9af34-a133-43e2-8dd2-aef04ddb2b8c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "709a40af-4a4e-40b6-887b-d30dcdf07030");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78bf8cbe-1f70-4d6d-890b-247bc57e6150");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ecfbe7ad-bb6b-49e6-ac2b-6359a73fbf02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27b9af34-a133-43e2-8dd2-aef04ddb2b8c");

            migrationBuilder.DropColumn(
                name: "Fname",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Sname",
                table: "AspNetUsers");
        }
    }
}
