using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tracio.Data.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Blogs__authorId__3F115E1A",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingPr__booki__25518C17",
                table: "BookingProducts");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingPr__produ__2645B050",
                table: "BookingProducts");

            migrationBuilder.DropForeignKey(
                name: "FK__Bookings__userId__1DB06A4F",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingSe__booki__208CD6FA",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingSe__servi__2180FB33",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK__ChatOfGro__group__4D5F7D71",
                table: "ChatOfGroup");

            migrationBuilder.DropForeignKey(
                name: "FK__ChatOfGro__userI__4E53A1AA",
                table: "ChatOfGroup");

            migrationBuilder.DropForeignKey(
                name: "FK__Group__creatorId__30C33EC3",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK__GroupMemb__group__3493CFA7",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK__GroupMemb__userI__3587F3E0",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__userId__2BFE89A6",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Services__catego__18EBB532",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK__Users__roleId__151B244E",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users__CB9A1CFF29E61DF3",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "UQ__Users__4849DA013DF3B62A",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "UQ__Users__AB6E61643411D9E7",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Services__455070DF52169085",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ServiceC__23CAF1D80B2C0558",
                table: "ServiceCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Roles__CD98462AC0A6CE35",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reviews__2ECD6E040648FA94",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Products__23CAF1D89B699DCD",
                table: "ProductsCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Products__2D10D16AE927EFB6",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK__GroupMem__05AFB8461FADC7E0",
                table: "GroupMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Group__88C1034D8EE2D26D",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ChatOfGr__8453A397553864AA",
                table: "ChatOfGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BookingS__37EED930E4E53BB2",
                table: "BookingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bookings__C6D03BCDB50CE6AC",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BookingP__DAC8E761ABC5965A",
                table: "BookingProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BlogTags__50FC0157408AE799",
                table: "BlogTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Blogs__FA0AA72D8673FEDC",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BlogCate__23CAF1D802B79687",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "brand",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "viewCount",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "preferredRouteTypes",
                table: "Users",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "cyclingLevel",
                table: "Users",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ProductsCategories",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "memberShipId",
                table: "GroupMember",
                newName: "MemberShipId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "BookingServices",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "BookingProducts",
                newName: "Quantity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Users",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "fullName",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Users",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "serviceName",
                table: "Services",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<int>(
                name: "availability",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Services",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "ServiceCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "ServiceCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "roleName",
                table: "Roles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "targetType",
                table: "Reviews",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Reviews",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "targetId",
                table: "Reviews",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "ProductsCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "status",
                table: "ProductsCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Products",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "condition",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Products",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "joinedTime",
                table: "GroupMember",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Group",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "groupName",
                table: "Group",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Group",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Group",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "Group",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "ChatOfGroup",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<DateTime>(
                name: "bookingDate",
                table: "Bookings",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "tagName",
                table: "BlogTags",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Blogs",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Blogs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<int>(
                name: "likeCount",
                table: "Blogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Blogs",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true,
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.AddColumn<int>(
                name: "categoryId",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "BlogCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users__CB9A1CFFE397DAC0",
                table: "Users",
                column: "userId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Services__455070DF61C080D5",
                table: "Services",
                column: "serviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ServiceC__23CAF1D8C383CAB7",
                table: "ServiceCategories",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Roles__CD98462A2BE0A9C9",
                table: "Roles",
                column: "roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reviews__2ECD6E04338822CD",
                table: "Reviews",
                column: "reviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Products__23CAF1D811636B80",
                table: "ProductsCategories",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Products__2D10D16A751C21D1",
                table: "Products",
                column: "productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__GroupMem__543A6D5BF8456B05",
                table: "GroupMember",
                column: "MemberShipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Group__88C1034DE87CDEF9",
                table: "Group",
                column: "groupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ChatOfGr__8453A397ED9ED409",
                table: "ChatOfGroup",
                column: "groupChatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BookingS__37EED9306FD7CC74",
                table: "BookingServices",
                column: "serviceBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bookings__C6D03BCD395AA970",
                table: "Bookings",
                column: "bookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BookingP__DAC8E7610CF4C426",
                table: "BookingProducts",
                column: "productBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BlogTags__50FC01578EDDCA23",
                table: "BlogTags",
                column: "tagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Blogs__FA0AA72DECC9C036",
                table: "Blogs",
                column: "blogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BlogCate__23CAF1D810C9BAEB",
                table: "BlogCategories",
                column: "categoryId");

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
                name: "UQ__Users__AB6E6164B1F52597",
                table: "Users",
                column: "email",
                unique: true,
                filter: "[email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_categoryId",
                table: "Blogs",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_tagId",
                table: "Blogs",
                column: "tagId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoutes_groupId",
                table: "GroupRoutes",
                column: "groupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupRoutes_routeId",
                table: "GroupRoutes",
                column: "routeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Blogs__authorId__5BE2A6F2",
                table: "Blogs",
                column: "authorId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Blogs__categoryI__5CD6CB2B",
                table: "Blogs",
                column: "categoryId",
                principalTable: "BlogCategories",
                principalColumn: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Blogs__tagId__5DCAEF64",
                table: "Blogs",
                column: "tagId",
                principalTable: "BlogTags",
                principalColumn: "tagId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingPr__booki__4E88ABD4",
                table: "BookingProducts",
                column: "bookingId",
                principalTable: "Bookings",
                principalColumn: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingPr__produ__4D94879B",
                table: "BookingProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK__Bookings__userId__3F466844",
                table: "Bookings",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingSe__booki__45F365D3",
                table: "BookingServices",
                column: "bookingId",
                principalTable: "Bookings",
                principalColumn: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingSe__servi__44FF419A",
                table: "BookingServices",
                column: "serviceId",
                principalTable: "Services",
                principalColumn: "serviceId");

            migrationBuilder.AddForeignKey(
                name: "FK__ChatOfGro__group__693CA210",
                table: "ChatOfGroup",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK__ChatOfGro__userI__68487DD7",
                table: "ChatOfGroup",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Group__creatorId__619B8048",
                table: "Group",
                column: "creatorId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__GroupMemb__group__6477ECF3",
                table: "GroupMember",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK__GroupMemb__userI__656C112C",
                table: "GroupMember",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Products__catego__4AB81AF0",
                table: "Products",
                column: "categoryId",
                principalTable: "ProductsCategories",
                principalColumn: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__userId__5165187F",
                table: "Reviews",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Services__catego__4222D4EF",
                table: "Services",
                column: "categoryId",
                principalTable: "ServiceCategories",
                principalColumn: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__roleId__3A81B327",
                table: "Users",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "roleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Blogs__authorId__5BE2A6F2",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK__Blogs__categoryI__5CD6CB2B",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK__Blogs__tagId__5DCAEF64",
                table: "Blogs");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingPr__booki__4E88ABD4",
                table: "BookingProducts");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingPr__produ__4D94879B",
                table: "BookingProducts");

            migrationBuilder.DropForeignKey(
                name: "FK__Bookings__userId__3F466844",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingSe__booki__45F365D3",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK__BookingSe__servi__44FF419A",
                table: "BookingServices");

            migrationBuilder.DropForeignKey(
                name: "FK__ChatOfGro__group__693CA210",
                table: "ChatOfGroup");

            migrationBuilder.DropForeignKey(
                name: "FK__ChatOfGro__userI__68487DD7",
                table: "ChatOfGroup");

            migrationBuilder.DropForeignKey(
                name: "FK__Group__creatorId__619B8048",
                table: "Group");

            migrationBuilder.DropForeignKey(
                name: "FK__GroupMemb__group__6477ECF3",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK__GroupMemb__userI__656C112C",
                table: "GroupMember");

            migrationBuilder.DropForeignKey(
                name: "FK__Products__catego__4AB81AF0",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK__Reviews__userId__5165187F",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK__Services__catego__4222D4EF",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK__Users__roleId__3A81B327",
                table: "Users");

            migrationBuilder.DropTable(
                name: "GroupRoutes");

            migrationBuilder.DropTable(
                name: "RouteCheckpoints");

            migrationBuilder.DropTable(
                name: "RouteReferences");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Users__CB9A1CFFE397DAC0",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "UQ__Users__AB6E6164B1F52597",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Services__455070DF61C080D5",
                table: "Services");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ServiceC__23CAF1D8C383CAB7",
                table: "ServiceCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Roles__CD98462A2BE0A9C9",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Reviews__2ECD6E04338822CD",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Products__23CAF1D811636B80",
                table: "ProductsCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Products__2D10D16A751C21D1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_categoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK__GroupMem__543A6D5BF8456B05",
                table: "GroupMember");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Group__88C1034DE87CDEF9",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK__ChatOfGr__8453A397ED9ED409",
                table: "ChatOfGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BookingS__37EED9306FD7CC74",
                table: "BookingServices");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Bookings__C6D03BCD395AA970",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BookingP__DAC8E7610CF4C426",
                table: "BookingProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BlogTags__50FC01578EDDCA23",
                table: "BlogTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Blogs__FA0AA72DECC9C036",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_categoryId",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_tagId",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK__BlogCate__23CAF1D810C9BAEB",
                table: "BlogCategories");

            migrationBuilder.DropColumn(
                name: "availability",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "status",
                table: "ServiceCategories");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "targetId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "condition",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "description",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "status",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "categoryId",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Users",
                newName: "cyclingLevel");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "Users",
                newName: "preferredRouteTypes");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "ProductsCategories",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "MemberShipId",
                table: "GroupMember",
                newName: "memberShipId");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BookingServices",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "BookingProducts",
                newName: "quantity");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Users",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "phoneNumber",
                table: "Users",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "fullName",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Users",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Users",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "serviceName",
                table: "Services",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "ServiceCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "roleName",
                table: "Roles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "targetType",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Reviews",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "ProductsCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "ProductsCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "productName",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Products",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "brand",
                table: "Products",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "Products",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Products",
                type: "float",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "joinedTime",
                table: "GroupMember",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Group",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "groupName",
                table: "Group",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Group",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "ChatOfGroup",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "bookingDate",
                table: "Bookings",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tagName",
                table: "BlogTags",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updatedTime",
                table: "Blogs",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Blogs",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "likeCount",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdTime",
                table: "Blogs",
                type: "datetime",
                nullable: true,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "viewCount",
                table: "Blogs",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "categoryName",
                table: "BlogCategories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK__Users__CB9A1CFF29E61DF3",
                table: "Users",
                column: "userId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Services__455070DF52169085",
                table: "Services",
                column: "serviceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ServiceC__23CAF1D80B2C0558",
                table: "ServiceCategories",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Roles__CD98462AC0A6CE35",
                table: "Roles",
                column: "roleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Reviews__2ECD6E040648FA94",
                table: "Reviews",
                column: "reviewId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Products__23CAF1D89B699DCD",
                table: "ProductsCategories",
                column: "categoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Products__2D10D16AE927EFB6",
                table: "Products",
                column: "productId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__GroupMem__05AFB8461FADC7E0",
                table: "GroupMember",
                column: "memberShipId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Group__88C1034D8EE2D26D",
                table: "Group",
                column: "groupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__ChatOfGr__8453A397553864AA",
                table: "ChatOfGroup",
                column: "groupChatId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BookingS__37EED930E4E53BB2",
                table: "BookingServices",
                column: "serviceBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Bookings__C6D03BCDB50CE6AC",
                table: "Bookings",
                column: "bookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BookingP__DAC8E761ABC5965A",
                table: "BookingProducts",
                column: "productBookingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BlogTags__50FC0157408AE799",
                table: "BlogTags",
                column: "tagId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Blogs__FA0AA72D8673FEDC",
                table: "Blogs",
                column: "blogId");

            migrationBuilder.AddPrimaryKey(
                name: "PK__BlogCate__23CAF1D802B79687",
                table: "BlogCategories",
                column: "categoryId");

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

            migrationBuilder.AddForeignKey(
                name: "FK__Blogs__authorId__3F115E1A",
                table: "Blogs",
                column: "authorId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingPr__booki__25518C17",
                table: "BookingProducts",
                column: "bookingId",
                principalTable: "Bookings",
                principalColumn: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingPr__produ__2645B050",
                table: "BookingProducts",
                column: "productId",
                principalTable: "Products",
                principalColumn: "productId");

            migrationBuilder.AddForeignKey(
                name: "FK__Bookings__userId__1DB06A4F",
                table: "Bookings",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingSe__booki__208CD6FA",
                table: "BookingServices",
                column: "bookingId",
                principalTable: "Bookings",
                principalColumn: "bookingId");

            migrationBuilder.AddForeignKey(
                name: "FK__BookingSe__servi__2180FB33",
                table: "BookingServices",
                column: "serviceId",
                principalTable: "Services",
                principalColumn: "serviceId");

            migrationBuilder.AddForeignKey(
                name: "FK__ChatOfGro__group__4D5F7D71",
                table: "ChatOfGroup",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK__ChatOfGro__userI__4E53A1AA",
                table: "ChatOfGroup",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Group__creatorId__30C33EC3",
                table: "Group",
                column: "creatorId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__GroupMemb__group__3493CFA7",
                table: "GroupMember",
                column: "groupId",
                principalTable: "Group",
                principalColumn: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK__GroupMemb__userI__3587F3E0",
                table: "GroupMember",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Reviews__userId__2BFE89A6",
                table: "Reviews",
                column: "userId",
                principalTable: "Users",
                principalColumn: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK__Services__catego__18EBB532",
                table: "Services",
                column: "categoryId",
                principalTable: "ServiceCategories",
                principalColumn: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK__Users__roleId__151B244E",
                table: "Users",
                column: "roleId",
                principalTable: "Roles",
                principalColumn: "roleId");
        }
    }
}
