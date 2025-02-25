using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracio.Data.Migrations
{
    /// <inheritdoc />
    public partial class addStatusCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BlogCate__23CAF1D802B79687", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    tagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BlogTags__50FC0157408AE799", x => x.tagId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    stockQuantity = table.Column<int>(type: "int", nullable: true),
                    brand = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    rating = table.Column<double>(type: "float", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__2D10D16AE927EFB6", x => x.productId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__23CAF1D89B699DCD", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    permissions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__CD98462AC0A6CE35", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ServiceC__23CAF1D80B2C0558", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: true),
                    cyclingLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    preferredRouteTypes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MemberShipId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__CB9A1CFF29E61DF3", x => x.userId);
                    table.ForeignKey(
                        name: "FK__Users__roleId__151B244E",
                        column: x => x.roleId,
                        principalTable: "Roles",
                        principalColumn: "roleId");
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    serviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    estimatedTime = table.Column<double>(type: "float", nullable: true),
                    rating = table.Column<double>(type: "float", nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Services__455070DF52169085", x => x.serviceId);
                    table.ForeignKey(
                        name: "FK__Services__catego__18EBB532",
                        column: x => x.categoryId,
                        principalTable: "ServiceCategories",
                        principalColumn: "categoryId");
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    blogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorId = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tagId = table.Column<int>(type: "int", nullable: true),
                    viewCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    likeCount = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blogs__FA0AA72D8673FEDC", x => x.blogId);
                    table.ForeignKey(
                        name: "FK__Blogs__authorId__3F115E1A",
                        column: x => x.authorId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: true),
                    bookingDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bookings__C6D03BCDB50CE6AC", x => x.bookingId);
                    table.ForeignKey(
                        name: "FK__Bookings__userId__1DB06A4F",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    groupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    creatorId = table.Column<int>(type: "int", nullable: true),
                    memberCount = table.Column<int>(type: "int", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Group__88C1034D8EE2D26D", x => x.groupId);
                    table.ForeignKey(
                        name: "FK__Group__creatorId__30C33EC3",
                        column: x => x.creatorId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    reviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: true),
                    targetType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__2ECD6E040648FA94", x => x.reviewId);
                    table.ForeignKey(
                        name: "FK__Reviews__userId__2BFE89A6",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "BookingProducts",
                columns: table => new
                {
                    productBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingId = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookingP__DAC8E761ABC5965A", x => x.productBookingId);
                    table.ForeignKey(
                        name: "FK__BookingPr__booki__25518C17",
                        column: x => x.bookingId,
                        principalTable: "Bookings",
                        principalColumn: "bookingId");
                    table.ForeignKey(
                        name: "FK__BookingPr__produ__2645B050",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId");
                });

            migrationBuilder.CreateTable(
                name: "BookingServices",
                columns: table => new
                {
                    serviceBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingId = table.Column<int>(type: "int", nullable: true),
                    serviceId = table.Column<int>(type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookingS__37EED930E4E53BB2", x => x.serviceBookingId);
                    table.ForeignKey(
                        name: "FK__BookingSe__booki__208CD6FA",
                        column: x => x.bookingId,
                        principalTable: "Bookings",
                        principalColumn: "bookingId");
                    table.ForeignKey(
                        name: "FK__BookingSe__servi__2180FB33",
                        column: x => x.serviceId,
                        principalTable: "Services",
                        principalColumn: "serviceId");
                });

            migrationBuilder.CreateTable(
                name: "ChatOfGroup",
                columns: table => new
                {
                    groupChatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChatOfGr__8453A397553864AA", x => x.groupChatId);
                    table.ForeignKey(
                        name: "FK__ChatOfGro__group__4D5F7D71",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "groupId");
                    table.ForeignKey(
                        name: "FK__ChatOfGro__userI__4E53A1AA",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    memberShipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    joinedTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GroupMem__05AFB8461FADC7E0", x => x.memberShipId);
                    table.ForeignKey(
                        name: "FK__GroupMemb__group__3493CFA7",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "groupId");
                    table.ForeignKey(
                        name: "FK__GroupMemb__userI__3587F3E0",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_authorId",
                table: "Blogs",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingProducts_bookingId",
                table: "BookingProducts",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingProducts_productId",
                table: "BookingProducts",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_userId",
                table: "Bookings",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_bookingId",
                table: "BookingServices",
                column: "bookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingServices_serviceId",
                table: "BookingServices",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatOfGroup_groupId",
                table: "ChatOfGroup",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatOfGroup_userId",
                table: "ChatOfGroup",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_creatorId",
                table: "Group",
                column: "creatorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_groupId",
                table: "GroupMember",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_userId",
                table: "GroupMember",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_userId",
                table: "Reviews",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_categoryId",
                table: "Services",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleId",
                table: "Users",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__4849DA013DF3B62A",
                table: "Users",
                column: "phoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__AB6E61643411D9E7",
                table: "Users",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "BookingProducts");

            migrationBuilder.DropTable(
                name: "BookingServices");

            migrationBuilder.DropTable(
                name: "ChatOfGroup");

            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "ProductsCategories");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "ServiceCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
