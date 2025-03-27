using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Tracio.Data.Entities;

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

    public virtual DbSet<GroupRoute> GroupRoutes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsCategory> ProductsCategories { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<RouteCheckpoint> RouteCheckpoints { get; set; }

    public virtual DbSet<RouteReference> RouteReferences { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<ServiceCategory> ServiceCategories { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public static string GetConnectionString(string connectionStringName)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString = config.GetConnectionString(connectionStringName);
        return connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString("DefaultConnection")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("PK__Blogs__FA0AA72DECC9C036");

            entity.Property(e => e.BlogId).HasColumnName("blogId");
            entity.Property(e => e.AuthorId).HasColumnName("authorId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.LikeCount).HasColumnName("likeCount");
            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Author).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Blogs__authorId__5BE2A6F2");

            entity.HasOne(d => d.Category).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Blogs__categoryI__5CD6CB2B");

            entity.HasOne(d => d.Tag).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK__Blogs__tagId__5DCAEF64");
        });

        modelBuilder.Entity<BlogCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__BlogCate__23CAF1D810C9BAEB");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<BlogTag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__BlogTags__50FC01578EDDCA23");

            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .HasColumnName("tagName");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__C6D03BCD395AA970");

            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.BookingDate)
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
                .HasConstraintName("FK__Bookings__userId__3F466844");
        });

        modelBuilder.Entity<BookingProduct>(entity =>
        {
            entity.HasKey(e => e.ProductBookingId).HasName("PK__BookingP__DAC8E7610CF4C426");

            entity.Property(e => e.ProductBookingId).HasColumnName("productBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingPr__booki__4E88ABD4");

            entity.HasOne(d => d.Product).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__BookingPr__produ__4D94879B");
        });

        modelBuilder.Entity<BookingService>(entity =>
        {
            entity.HasKey(e => e.ServiceBookingId).HasName("PK__BookingS__37EED9306FD7CC74");

            entity.Property(e => e.ServiceBookingId).HasColumnName("serviceBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingSe__booki__45F365D3");

            entity.HasOne(d => d.Service).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__BookingSe__servi__44FF419A");
        });

        modelBuilder.Entity<ChatOfGroup>(entity =>
        {
            entity.HasKey(e => e.GroupChatId).HasName("PK__ChatOfGr__8453A397ED9ED409");

            entity.ToTable("ChatOfGroup");

            entity.Property(e => e.GroupChatId).HasColumnName("groupChatId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Group).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__ChatOfGro__group__693CA210");

            entity.HasOne(d => d.User).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ChatOfGro__userI__68487DD7");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__88C1034DE87CDEF9");

            entity.ToTable("Group");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.CreatorId).HasColumnName("creatorId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.GroupName)
                .HasMaxLength(255)
                .HasColumnName("groupName");
            entity.Property(e => e.MemberCount).HasColumnName("memberCount");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Creator).WithMany(p => p.Groups)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK__Group__creatorId__619B8048");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => e.MemberShipId).HasName("PK__GroupMem__543A6D5BF8456B05");

            entity.ToTable("GroupMember");

            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.JoinedTime)
                .HasColumnType("datetime")
                .HasColumnName("joinedTime");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupMemb__group__6477ECF3");

            entity.HasOne(d => d.User).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__GroupMemb__userI__656C112C");
        });

        modelBuilder.Entity<GroupRoute>(entity =>
        {
            entity.HasKey(e => e.GroupRouteId).HasName("PK__GroupRou__D8AC9C3240222212");

            entity.Property(e => e.GroupRouteId).HasColumnName("groupRouteId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.RouteId).HasColumnName("routeId");
            entity.Property(e => e.SharedTime).HasColumnType("datetime");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupRoutes)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupRout__group__75A278F5");

            entity.HasOne(d => d.Route).WithMany(p => p.GroupRoutes)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__GroupRout__route__76969D2E");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__2D10D16A751C21D1");

            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Condition).HasColumnName("condition");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .HasColumnName("productName");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.StockQuantity).HasColumnName("stockQuantity");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Products__catego__4AB81AF0");
        });

        modelBuilder.Entity<ProductsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Products__23CAF1D811636B80");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__2ECD6E04338822CD");

            entity.Property(e => e.ReviewId).HasColumnName("reviewId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TargetId).HasColumnName("targetId");
            entity.Property(e => e.TargetType)
                .HasMaxLength(255)
                .HasColumnName("targetType");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reviews__userId__5165187F");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__CD98462A2BE0A9C9");

            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Permissions).HasColumnName("permissions");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK__Routes__BAC024C7EE29B214");

            entity.Property(e => e.RouteId).HasColumnName("routeId");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.CreatorId).HasColumnName("creatorId");
            entity.Property(e => e.Distance).HasColumnName("distance");
            entity.Property(e => e.EndLocation).HasColumnName("endLocation");
            entity.Property(e => e.EstimatedTime).HasColumnName("estimatedTime");
            entity.Property(e => e.RouteDescription).HasColumnName("routeDescription");
            entity.Property(e => e.RoutePath).HasColumnName("routePath");
            entity.Property(e => e.SegmentPolyline).HasColumnName("segmentPolyline");
            entity.Property(e => e.SharedWithPublic).HasColumnName("sharedWithPublic");
            entity.Property(e => e.StartLocation).HasColumnName("startLocation");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.Creator).WithMany(p => p.Routes)
                .HasForeignKey(d => d.CreatorId)
                .HasConstraintName("FK__Routes__creatorI__6C190EBB");
        });

        modelBuilder.Entity<RouteCheckpoint>(entity =>
        {
            entity.HasKey(e => e.PointId).HasName("PK__RouteChe__4CB435AE529C9236");

            entity.Property(e => e.PointId).HasColumnName("pointId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Lng).HasColumnName("lng");
            entity.Property(e => e.PointName)
                .HasMaxLength(255)
                .HasColumnName("pointName");
            entity.Property(e => e.PointNumber).HasColumnName("pointNumber");
            entity.Property(e => e.SegmentId).HasColumnName("segmentId");
            entity.Property(e => e.SequenceNumber).HasColumnName("sequenceNumber");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.Segment).WithMany(p => p.RouteCheckpoints)
                .HasForeignKey(d => d.SegmentId)
                .HasConstraintName("FK__RouteChec__segme__6EF57B66");
        });

        modelBuilder.Entity<RouteReference>(entity =>
        {
            entity.HasKey(e => e.ReferenceId).HasName("PK__RouteRef__7B826DDEA9D955CB");

            entity.Property(e => e.ReferenceId).HasColumnName("referenceId");
            entity.Property(e => e.BlogId).HasColumnName("blogId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.RouteId).HasColumnName("routeId");

            entity.HasOne(d => d.Blog).WithMany(p => p.RouteReferences)
                .HasForeignKey(d => d.BlogId)
                .HasConstraintName("FK__RouteRefe__blogI__71D1E811");

            entity.HasOne(d => d.Route).WithMany(p => p.RouteReferences)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__RouteRefe__route__72C60C4A");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__455070DF61C080D5");

            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Availability).HasColumnName("availability");
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
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");

            entity.HasOne(d => d.Category).WithMany(p => p.Services)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Services__catego__4222D4EF");
        });

        modelBuilder.Entity<ServiceCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ServiceC__23CAF1D8C383CAB7");

            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFFE397DAC0");

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E6164B1F52597").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
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
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Users__roleId__3A81B327");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
