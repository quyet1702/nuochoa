using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ButterflyCarair.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "but73756_but73756");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Details1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details4 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details5 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details6 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details7 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Details8 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Avatar = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Price = table.Column<int>(type: "int", nullable: true),
                    Sold = table.Column<int>(type: "int", nullable: true),
                    ProductLocation = table.Column<int>(type: "int", nullable: true),
                    Image1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image3 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Image4 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: true),
                    Trademark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Concentration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PerfumeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FragranceGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Style = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReleaseYear = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProductType = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Promotion = table.Column<bool>(type: "bit", nullable: false),
                    Describe = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe4 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe5 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe6 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe7 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    Describe8 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare1 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare2 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare3 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare4 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare5 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare6 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare7 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    UsageAndCare8 = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "but73756_but73756",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "but73756_but73756",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "but73756_but73756",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "but73756_but73756",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scent",
                schema: "but73756_but73756",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    ProductCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scent",
                        column: x => x.ProductId,
                        principalSchema: "but73756_but73756",
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "but73756_but73756",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "but73756_but73756",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "but73756_but73756",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "but73756_but73756",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "but73756_but73756",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "but73756_but73756",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "but73756_but73756",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Scent_ProductId",
                schema: "but73756_but73756",
                table: "Scent",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "News",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "Scent",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "but73756_but73756");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "but73756_but73756");
        }
    }
}
