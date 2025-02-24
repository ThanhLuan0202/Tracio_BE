using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Tracio.Data.Models;

namespace Tracio.Data.Data;

public partial class TracioDbContext : DbContext
{
    public TracioDbContext()
    {
    }

    public TracioDbContext(DbContextOptions<TracioDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogCategory> BlogCategories { get; set; }

    public virtual DbSet<BlogTag> BlogTags { get; set; }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingProduct> BookingProducts { get; set; }

    public virtual DbSet<BookingService> BookingServices { get; set; }

    public virtual DbSet<ChatOfGroup> ChatOfGroups { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsCategory> ProductsCategories { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=TracioDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("PK__Blogs__FA0AA72D8673FEDC");

            entity.Property(e => e.BlogId).HasColumnName("blogId");
            entity.Property(e => e.AuthorId).HasColumnName("authorId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.LikeCount)
                .HasDefaultValue(0)
                .HasColumnName("likeCount");
            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");
            entity.Property(e => e.ViewCount)
                .HasDefaultValue(0)
                .HasColumnName("viewCount");

            entity.HasOne(d => d.Author).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Blogs__authorId__3F115E1A");
        });

        modelBuilder.Entity<BlogCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__BlogCate__23CAF1D802B79687");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<BlogTag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__BlogTags__50FC0157408AE799");

            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .HasColumnName("tagName");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__C6D03BCDB50CE6AC");

            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.BookingDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("bookingDate");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TotalAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalAmount");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Bookings__userId__1DB06A4F");
        });

        modelBuilder.Entity<BookingProduct>(entity =>
        {
            entity.HasKey(e => e.ProductBookingId).HasName("PK__BookingP__DAC8E761ABC5965A");

            entity.Property(e => e.ProductBookingId).HasColumnName("productBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingPr__booki__25518C17");

            entity.HasOne(d => d.Product).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__BookingPr__produ__2645B050");
        });

        modelBuilder.Entity<BookingService>(entity =>
        {
            entity.HasKey(e => e.ServiceBookingId).HasName("PK__BookingS__37EED930E4E53BB2");

            entity.Property(e => e.ServiceBookingId).HasColumnName("serviceBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingSe__booki__208CD6FA");

            entity.HasOne(d => d.Service).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__BookingSe__servi__2180FB33");
        });

        modelBuilder.Entity<ChatOfGroup>(entity =>
        {
            entity.HasKey(e => e.GroupChatId).HasName("PK__ChatOfGr__8453A397553864AA");

            entity.ToTable("ChatOfGroup");

            entity.Property(e => e.GroupChatId).HasColumnName("groupChatId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Group).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__ChatOfGro__group__4D5F7D71");

            entity.HasOne(d => d.User).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ChatOfGro__userI__4E53A1AA");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__88C1034D8EE2D26D");

            entity.ToTable("Group");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.CreatorId).HasColumnName("creatorId");
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .HasColumnName("groupName");
            entity.Property(e => e.MemberCount).HasColumnName("memberCount");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Creator).WithMany(p => p.Groups)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK__Group__creatorId__30C33EC3");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => e.MemberShipId).HasName("PK__GroupMem__05AFB8461FADC7E0");

            entity.ToTable("GroupMember");

            entity.Property(e => e.MemberShipId).HasColumnName("memberShipId");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.JoinedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("joinedTime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupMemb__group__3493CFA7");

            entity.HasOne(d => d.User).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__GroupMemb__userI__3587F3E0");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__2D10D16AE927EFB6");

            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Brand)
                .HasMaxLength(255)
                .HasColumnName("brand");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("productName");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.StockQuantity).HasColumnName("stockQuantity");
        });

        modelBuilder.Entity<ProductsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Products__23CAF1D89B699DCD");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__2ECD6E040648FA94");

            entity.Property(e => e.ReviewId).HasColumnName("reviewId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.TargetType)
                .HasMaxLength(50)
                .HasColumnName("targetType");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reviews__userId__2BFE89A6");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__CD98462AC0A6CE35");

            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Permissions).HasColumnName("permissions");
            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__455070DF52169085");

            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.EstimatedTime).HasColumnName("estimatedTime");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.ServiceName)
                .HasMaxLength(255)
                .HasColumnName("serviceName");

            entity.HasOne(d => d.Category).WithMany(p => p.Services)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Services__catego__18EBB532");
        });

        modelBuilder.Entity<ServiceCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ServiceC__23CAF1D80B2C0558");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF29E61DF3");

            entity.HasIndex(e => e.PhoneNumber, "UQ__Users__4849DA013DF3B62A").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E61643411D9E7").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.CreatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.CyclingLevel)
                .HasMaxLength(50)
                .HasColumnName("cyclingLevel");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("fullName");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.PreferredRouteTypes).HasColumnName("preferredRouteTypes");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.UpdatedTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__roleId__151B244E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
