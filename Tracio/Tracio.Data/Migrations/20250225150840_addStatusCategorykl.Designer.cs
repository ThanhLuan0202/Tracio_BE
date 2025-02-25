﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tracio.Data.Data;

#nullable disable

namespace Tracio.Data.Migrations
{
    [DbContext(typeof(TracioDbContext))]
    [Migration("20250225150840_addStatusCategorykl")]
    partial class addStatusCategorykl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tracio.Data.Models.Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("blogId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogId"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("authorId");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("LikeCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("likeCount");

                    b.Property<int?>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("tagId");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("title");

                    b.Property<DateTime?>("UpdatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updatedTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("ViewCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0)
                        .HasColumnName("viewCount");

                    b.HasKey("BlogId")
                        .HasName("PK__Blogs__FA0AA72D8673FEDC");

                    b.HasIndex("AuthorId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Tracio.Data.Models.BlogCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("categoryName");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.HasKey("CategoryId")
                        .HasName("PK__BlogCate__23CAF1D802B79687");

                    b.ToTable("BlogCategories");
                });

            modelBuilder.Entity("Tracio.Data.Models.BlogTag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tagId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("tagName");

                    b.HasKey("TagId")
                        .HasName("PK__BlogTags__50FC0157408AE799");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("Tracio.Data.Models.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime?>("BookingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("bookingDate")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.Property<decimal?>("TotalAmount")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("totalAmount");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("BookingId")
                        .HasName("PK__Bookings__C6D03BCDB50CE6AC");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Tracio.Data.Models.BookingProduct", b =>
                {
                    b.Property<int>("ProductBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("productBookingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductBookingId"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("subtotal");

                    b.HasKey("ProductBookingId")
                        .HasName("PK__BookingP__DAC8E761ABC5965A");

                    b.HasIndex("BookingId");

                    b.HasIndex("ProductId");

                    b.ToTable("BookingProducts");
                });

            modelBuilder.Entity("Tracio.Data.Models.BookingService", b =>
                {
                    b.Property<int>("ServiceBookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("serviceBookingId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceBookingId"));

                    b.Property<int?>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("notes");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnName("serviceId");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("subtotal");

                    b.HasKey("ServiceBookingId")
                        .HasName("PK__BookingS__37EED930E4E53BB2");

                    b.HasIndex("BookingId");

                    b.HasIndex("ServiceId");

                    b.ToTable("BookingServices");
                });

            modelBuilder.Entity("Tracio.Data.Models.ChatOfGroup", b =>
                {
                    b.Property<int>("GroupChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("groupChatId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupChatId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int")
                        .HasColumnName("groupId");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("GroupChatId")
                        .HasName("PK__ChatOfGr__8453A397553864AA");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatOfGroup", (string)null);
                });

            modelBuilder.Entity("Tracio.Data.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("groupId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupId"));

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("CreatorId")
                        .HasColumnType("int")
                        .HasColumnName("creatorId");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("groupName");

                    b.Property<int?>("MemberCount")
                        .HasColumnType("int")
                        .HasColumnName("memberCount");

                    b.Property<DateTime?>("UpdatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updatedTime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("GroupId")
                        .HasName("PK__Group__88C1034D8EE2D26D");

                    b.HasIndex("CreatorId");

                    b.ToTable("Group", (string)null);
                });

            modelBuilder.Entity("Tracio.Data.Models.GroupMember", b =>
                {
                    b.Property<int>("MemberShipId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("memberShipId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberShipId"));

                    b.Property<int?>("GroupId")
                        .HasColumnType("int")
                        .HasColumnName("groupId");

                    b.Property<DateTime?>("JoinedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("joinedTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Status")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("status");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("MemberShipId")
                        .HasName("PK__GroupMem__05AFB8461FADC7E0");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("GroupMember", (string)null);
                });

            modelBuilder.Entity("Tracio.Data.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("productId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Brand")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("brand");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("image");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("productName");

                    b.Property<double?>("Rating")
                        .HasColumnType("float")
                        .HasColumnName("rating");

                    b.Property<int?>("StockQuantity")
                        .HasColumnType("int")
                        .HasColumnName("stockQuantity");

                    b.HasKey("ProductId")
                        .HasName("PK__Products__2D10D16AE927EFB6");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Tracio.Data.Models.ProductsCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("categoryName");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Products__23CAF1D89B699DCD");

                    b.ToTable("ProductsCategories");
                });

            modelBuilder.Entity("Tracio.Data.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("reviewId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<string>("TargetType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("targetType");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    b.HasKey("ReviewId")
                        .HasName("PK__Reviews__2ECD6E040648FA94");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Tracio.Data.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("roleId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Permissions")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("permissions");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("roleName");

                    b.HasKey("RoleId")
                        .HasName("PK__Roles__CD98462AC0A6CE35");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Tracio.Data.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("serviceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<double?>("EstimatedTime")
                        .HasColumnType("float")
                        .HasColumnName("estimatedTime");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("price");

                    b.Property<double?>("Rating")
                        .HasColumnType("float")
                        .HasColumnName("rating");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("serviceName");

                    b.HasKey("ServiceId")
                        .HasName("PK__Services__455070DF52169085");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Tracio.Data.Models.ServiceCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("categoryName");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.HasKey("CategoryId")
                        .HasName("PK__ServiceC__23CAF1D80B2C0558");

                    b.ToTable("ServiceCategories");
                });

            modelBuilder.Entity("Tracio.Data.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("userId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("createdTime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("CyclingLevel")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("cyclingLevel");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("fullName");

                    b.Property<int?>("MemberShipId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phoneNumber");

                    b.Property<string>("PreferredRouteTypes")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("preferredRouteTypes");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("roleId");

                    b.Property<DateTime?>("UpdatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("updatedTime")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("UserId")
                        .HasName("PK__Users__CB9A1CFF29E61DF3");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "PhoneNumber" }, "UQ__Users__4849DA013DF3B62A")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "UQ__Users__AB6E61643411D9E7")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Tracio.Data.Models.Blog", b =>
                {
                    b.HasOne("Tracio.Data.Models.User", "Author")
                        .WithMany("Blogs")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__Blogs__authorId__3F115E1A");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Tracio.Data.Models.Booking", b =>
                {
                    b.HasOne("Tracio.Data.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Bookings__userId__1DB06A4F");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tracio.Data.Models.BookingProduct", b =>
                {
                    b.HasOne("Tracio.Data.Models.Booking", "Booking")
                        .WithMany("BookingProducts")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK__BookingPr__booki__25518C17");

                    b.HasOne("Tracio.Data.Models.Product", "Product")
                        .WithMany("BookingProducts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__BookingPr__produ__2645B050");

                    b.Navigation("Booking");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Tracio.Data.Models.BookingService", b =>
                {
                    b.HasOne("Tracio.Data.Models.Booking", "Booking")
                        .WithMany("BookingServices")
                        .HasForeignKey("BookingId")
                        .HasConstraintName("FK__BookingSe__booki__208CD6FA");

                    b.HasOne("Tracio.Data.Models.Service", "Service")
                        .WithMany("BookingServices")
                        .HasForeignKey("ServiceId")
                        .HasConstraintName("FK__BookingSe__servi__2180FB33");

                    b.Navigation("Booking");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Tracio.Data.Models.ChatOfGroup", b =>
                {
                    b.HasOne("Tracio.Data.Models.Group", "Group")
                        .WithMany("ChatOfGroups")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK__ChatOfGro__group__4D5F7D71");

                    b.HasOne("Tracio.Data.Models.User", "User")
                        .WithMany("ChatOfGroups")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__ChatOfGro__userI__4E53A1AA");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tracio.Data.Models.Group", b =>
                {
                    b.HasOne("Tracio.Data.Models.User", "Creator")
                        .WithMany("Groups")
                        .HasForeignKey("CreatorId")
                        .HasConstraintName("FK__Group__creatorId__30C33EC3");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("Tracio.Data.Models.GroupMember", b =>
                {
                    b.HasOne("Tracio.Data.Models.Group", "Group")
                        .WithMany("GroupMembers")
                        .HasForeignKey("GroupId")
                        .HasConstraintName("FK__GroupMemb__group__3493CFA7");

                    b.HasOne("Tracio.Data.Models.User", "User")
                        .WithMany("GroupMembers")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__GroupMemb__userI__3587F3E0");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tracio.Data.Models.Review", b =>
                {
                    b.HasOne("Tracio.Data.Models.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Reviews__userId__2BFE89A6");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tracio.Data.Models.Service", b =>
                {
                    b.HasOne("Tracio.Data.Models.ServiceCategory", "Category")
                        .WithMany("Services")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Services__catego__18EBB532");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Tracio.Data.Models.User", b =>
                {
                    b.HasOne("Tracio.Data.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__Users__roleId__151B244E");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Tracio.Data.Models.Booking", b =>
                {
                    b.Navigation("BookingProducts");

                    b.Navigation("BookingServices");
                });

            modelBuilder.Entity("Tracio.Data.Models.Group", b =>
                {
                    b.Navigation("ChatOfGroups");

                    b.Navigation("GroupMembers");
                });

            modelBuilder.Entity("Tracio.Data.Models.Product", b =>
                {
                    b.Navigation("BookingProducts");
                });

            modelBuilder.Entity("Tracio.Data.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Tracio.Data.Models.Service", b =>
                {
                    b.Navigation("BookingServices");
                });

            modelBuilder.Entity("Tracio.Data.Models.ServiceCategory", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Tracio.Data.Models.User", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Bookings");

                    b.Navigation("ChatOfGroups");

                    b.Navigation("GroupMembers");

                    b.Navigation("Groups");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
