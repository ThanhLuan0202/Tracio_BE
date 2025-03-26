using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracio.Data.Migrations
{
    /// <inheritdoc />
    public partial class upds : Migration
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
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BlogCate__23CAF1D810C9BAEB", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    tagId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tagName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BlogTags__50FC01578EDDCA23", x => x.tagId);
                });

            migrationBuilder.CreateTable(
                name: "ProductsCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__23CAF1D811636B80", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    permissions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Roles__CD98462A2BE0A9C9", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceCategories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ServiceC__23CAF1D8C383CAB7", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stockQuantity = table.Column<int>(type: "int", nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Products__2D10D16A751C21D1", x => x.productId);
                    table.ForeignKey(
                        name: "FK__Products__catego__4AB81AF0",
                        column: x => x.categoryId,
                        principalTable: "ProductsCategories",
                        principalColumn: "categoryId");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    roleId = table.Column<int>(type: "int", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    EmailConfirmationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MemberShipId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__CB9A1CFFE397DAC0", x => x.userId);
                    table.ForeignKey(
                        name: "FK__Users__roleId__3A81B327",
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
                    serviceName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    availability = table.Column<int>(type: "int", nullable: true),
                    estimatedTime = table.Column<double>(type: "float", nullable: true),
                    rating = table.Column<double>(type: "float", nullable: true),
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Services__455070DF61C080D5", x => x.serviceId);
                    table.ForeignKey(
                        name: "FK__Services__catego__4222D4EF",
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
                    categoryId = table.Column<int>(type: "int", nullable: true),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tagId = table.Column<int>(type: "int", nullable: true),
                    likeCount = table.Column<int>(type: "int", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Blogs__FA0AA72DECC9C036", x => x.blogId);
                    table.ForeignKey(
                        name: "FK__Blogs__authorId__5BE2A6F2",
                        column: x => x.authorId,
                        principalTable: "Users",
                        principalColumn: "userId");
                    table.ForeignKey(
                        name: "FK__Blogs__categoryI__5CD6CB2B",
                        column: x => x.categoryId,
                        principalTable: "BlogCategories",
                        principalColumn: "categoryId");
                    table.ForeignKey(
                        name: "FK__Blogs__tagId__5DCAEF64",
                        column: x => x.tagId,
                        principalTable: "BlogTags",
                        principalColumn: "tagId");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: true),
                    bookingDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    totalAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bookings__C6D03BCD395AA970", x => x.bookingId);
                    table.ForeignKey(
                        name: "FK__Bookings__userId__3F466844",
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
                    groupName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    creatorId = table.Column<int>(type: "int", nullable: true),
                    memberCount = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    updatedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Group__88C1034DE87CDEF9", x => x.groupId);
                    table.ForeignKey(
                        name: "FK__Group__creatorId__619B8048",
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
                    targetId = table.Column<int>(type: "int", nullable: true),
                    targetType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__2ECD6E04338822CD", x => x.reviewId);
                    table.ForeignKey(
                        name: "FK__Reviews__userId__5165187F",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    routeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    creatorId = table.Column<int>(type: "int", nullable: true),
                    startLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    distance = table.Column<double>(type: "float", nullable: true),
                    estimatedTime = table.Column<double>(type: "float", nullable: true),
                    routeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sharedWithPublic = table.Column<bool>(type: "bit", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    routePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    segmentPolyline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetList = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Routes__BAC024C7EE29B214", x => x.routeId);
                    table.ForeignKey(
                        name: "FK__Routes__creatorI__6C190EBB",
                        column: x => x.creatorId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "BookingProducts",
                columns: table => new
                {
                    productBookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productId = table.Column<int>(type: "int", nullable: true),
                    bookingId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookingP__DAC8E7610CF4C426", x => x.productBookingId);
                    table.ForeignKey(
                        name: "FK__BookingPr__booki__4E88ABD4",
                        column: x => x.bookingId,
                        principalTable: "Bookings",
                        principalColumn: "bookingId");
                    table.ForeignKey(
                        name: "FK__BookingPr__produ__4D94879B",
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
                    serviceId = table.Column<int>(type: "int", nullable: true),
                    bookingId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: true),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookingS__37EED9306FD7CC74", x => x.serviceBookingId);
                    table.ForeignKey(
                        name: "FK__BookingSe__booki__45F365D3",
                        column: x => x.bookingId,
                        principalTable: "Bookings",
                        principalColumn: "bookingId");
                    table.ForeignKey(
                        name: "FK__BookingSe__servi__44FF419A",
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
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    createdTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ChatOfGr__8453A397ED9ED409", x => x.groupChatId);
                    table.ForeignKey(
                        name: "FK__ChatOfGro__group__693CA210",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "groupId");
                    table.ForeignKey(
                        name: "FK__ChatOfGro__userI__68487DD7",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    MemberShipId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    userId = table.Column<int>(type: "int", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    joinedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GroupMem__543A6D5BF8456B05", x => x.MemberShipId);
                    table.ForeignKey(
                        name: "FK__GroupMemb__group__6477ECF3",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "groupId");
                    table.ForeignKey(
                        name: "FK__GroupMemb__userI__656C112C",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "userId");
                });

            migrationBuilder.CreateTable(
                name: "GroupRoutes",
                columns: table => new
                {
                    groupRouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    groupId = table.Column<int>(type: "int", nullable: true),
                    routeId = table.Column<int>(type: "int", nullable: true),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SharedTime = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GroupRou__D8AC9C3240222212", x => x.groupRouteId);
                    table.ForeignKey(
                        name: "FK__GroupRout__group__75A278F5",
                        column: x => x.groupId,
                        principalTable: "Group",
                        principalColumn: "groupId");
                    table.ForeignKey(
                        name: "FK__GroupRout__route__76969D2E",
                        column: x => x.routeId,
                        principalTable: "Routes",
                        principalColumn: "routeId");
                });

            migrationBuilder.CreateTable(
                name: "RouteCheckpoints",
                columns: table => new
                {
                    pointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    segmentId = table.Column<int>(type: "int", nullable: true),
                    pointNumber = table.Column<int>(type: "int", nullable: true),
                    pointName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    sequenceNumber = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lng = table.Column<double>(type: "float", nullable: true),
                    status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RouteChe__4CB435AE529C9236", x => x.pointId);
                    table.ForeignKey(
                        name: "FK__RouteChec__segme__6EF57B66",
                        column: x => x.segmentId,
                        principalTable: "Routes",
                        principalColumn: "routeId");
                });

            migrationBuilder.CreateTable(
                name: "RouteReferences",
                columns: table => new
                {
                    referenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogId = table.Column<int>(type: "int", nullable: true),
                    routeId = table.Column<int>(type: "int", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RouteRef__7B826DDEA9D955CB", x => x.referenceId);
                    table.ForeignKey(
                        name: "FK__RouteRefe__blogI__71D1E811",
                        column: x => x.blogId,
                        principalTable: "Blogs",
                        principalColumn: "blogId");
                    table.ForeignKey(
                        name: "FK__RouteRefe__route__72C60C4A",
                        column: x => x.routeId,
                        principalTable: "Routes",
                        principalColumn: "routeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_authorId",
                table: "Blogs",
                column: "authorId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_categoryId",
                table: "Blogs",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_tagId",
                table: "Blogs",
                column: "tagId");

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
                name: "IX_GroupRoutes_groupId",
                table: "GroupRoutes",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoutes_routeId",
                table: "GroupRoutes",
                column: "routeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_userId",
                table: "Reviews",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteCheckpoints_segmentId",
                table: "RouteCheckpoints",
                column: "segmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteReferences_blogId",
                table: "RouteReferences",
                column: "blogId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteReferences_routeId",
                table: "RouteReferences",
                column: "routeId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_creatorId",
                table: "Routes",
                column: "creatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_categoryId",
                table: "Services",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleId",
                table: "Users",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__AB6E6164B1F52597",
                table: "Users",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingProducts");

            migrationBuilder.DropTable(
                name: "BookingServices");

            migrationBuilder.DropTable(
                name: "ChatOfGroup");

            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "GroupRoutes");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RouteCheckpoints");

            migrationBuilder.DropTable(
                name: "RouteReferences");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "ProductsCategories");

            migrationBuilder.DropTable(
                name: "ServiceCategories");

            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
