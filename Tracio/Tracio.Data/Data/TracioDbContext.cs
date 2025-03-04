using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LUAN_NE;Database=TracioDB;User Id=sa;Password=12345;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.BlogId).HasName("PK__Blogs__FA0AA72D3A123613");

            entity.Property(e => e.BlogId)
                .ValueGeneratedNever()
                .HasColumnName("blogId");
            entity.Property(e => e.AuthorId).HasColumnName("authorId");
            entity.Property(e => e.CategoryId).HasColumnName("categoryId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.LikeCount).HasColumnName("likeCount");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TagId).HasColumnName("tagId");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedTime)
                .HasColumnType("datetime")
                .HasColumnName("updatedTime");

            entity.HasOne(d => d.Author).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK__Blogs__authorId__6E01572D");

            entity.HasOne(d => d.Category).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__Blogs__categoryI__6EF57B66");

            entity.HasOne(d => d.Tag).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.TagId)
                .HasConstraintName("FK__Blogs__tagId__6FE99F9F");
        });

        modelBuilder.Entity<BlogCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__BlogCate__23CAF1D8B8F7F730");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .HasColumnName("categoryName");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<BlogTag>(entity =>
        {
            entity.HasKey(e => e.LagId).HasName("PK__BlogTags__4AF427FF4EAEB4DA");

            entity.Property(e => e.LagId)
                .ValueGeneratedNever()
                .HasColumnName("lagId");
            entity.Property(e => e.TagName)
                .HasMaxLength(255)
                .HasColumnName("tagName");
        });

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__C6D03BCDD8F4034A");

            entity.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("bookingId");
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
                .HasConstraintName("FK__Bookings__userId__5165187F");
        });

        modelBuilder.Entity<BookingProduct>(entity =>
        {
            entity.HasKey(e => e.ProductBookingId).HasName("PK__BookingP__DAC8E761DC54D71F");

            entity.Property(e => e.ProductBookingId)
                .ValueGeneratedNever()
                .HasColumnName("productBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ProductId).HasColumnName("productId");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingPr__booki__60A75C0F");

            entity.HasOne(d => d.Product).WithMany(p => p.BookingProducts)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__BookingPr__produ__5FB337D6");
        });

        modelBuilder.Entity<BookingService>(entity =>
        {
            entity.HasKey(e => e.ServiceBookingId).HasName("PK__BookingS__37EED9307FB474C2");

            entity.Property(e => e.ServiceBookingId)
                .ValueGeneratedNever()
                .HasColumnName("serviceBookingId");
            entity.Property(e => e.BookingId).HasColumnName("bookingId");
            entity.Property(e => e.Notes).HasColumnName("notes");
            entity.Property(e => e.ServiceId).HasColumnName("serviceId");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.Booking).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.BookingId)
                .HasConstraintName("FK__BookingSe__booki__5812160E");

            entity.HasOne(d => d.Service).WithMany(p => p.BookingServices)
                .HasForeignKey(d => d.ServiceId)
                .HasConstraintName("FK__BookingSe__servi__571DF1D5");
        });

        modelBuilder.Entity<ChatOfGroup>(entity =>
        {
            entity.HasKey(e => e.GroupChatId).HasName("PK__ChatOfGr__8453A3970E22601D");

            entity.ToTable("ChatOfGroup");

            entity.Property(e => e.GroupChatId)
                .ValueGeneratedNever()
                .HasColumnName("groupChatId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Group).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__ChatOfGro__group__7A672E12");

            entity.HasOne(d => d.User).WithMany(p => p.ChatOfGroups)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__ChatOfGro__userI__797309D9");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PK__Group__88C1034D3F0F1B0B");

            entity.ToTable("Group");

            entity.Property(e => e.GroupId)
                .ValueGeneratedNever()
                .HasColumnName("groupId");
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
                .HasConstraintName("FK__Group__creatorId__72C60C4A");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => e.MemberShipId).HasName("PK__GroupMem__543A6D5B417965D7");

            entity.ToTable("GroupMember");

            entity.Property(e => e.MemberShipId).ValueGeneratedNever();
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
                .HasConstraintName("FK__GroupMemb__group__75A278F5");

            entity.HasOne(d => d.User).WithMany(p => p.GroupMembers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__GroupMemb__userI__76969D2E");
        });

        modelBuilder.Entity<GroupRoute>(entity =>
        {
            entity.HasKey(e => e.GroupRouteId).HasName("PK__GroupRou__D8AC9C322017F58E");

            entity.Property(e => e.GroupRouteId)
                .ValueGeneratedNever()
                .HasColumnName("groupRouteId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.RouteId).HasColumnName("routeId");
            entity.Property(e => e.SharedTime).HasColumnType("datetime");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupRoutes)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupRout__group__06CD04F7");

            entity.HasOne(d => d.Route).WithMany(p => p.GroupRoutes)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__GroupRout__route__07C12930");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__2D10D16A286F2A66");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("productId");
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
                .HasConstraintName("FK__Products__catego__5CD6CB2B");
        });

        modelBuilder.Entity<ProductsCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__Products__23CAF1D807B22580");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
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
            entity.HasKey(e => e.ReviewId).HasName("PK__Reviews__2ECD6E0493C9EA31");

            entity.Property(e => e.ReviewId)
                .ValueGeneratedNever()
                .HasColumnName("reviewId");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.CreatedTime)
                .HasColumnType("datetime")
                .HasColumnName("createdTime");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.TargetId).HasColumnName("targetId");
            entity.Property(e => e.TargetType)
                .HasMaxLength(255)
                .HasColumnName("targetType");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.User).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__Reviews__userId__6383C8BA");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__CD98462ABFAD4745");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("roleId");
            entity.Property(e => e.Permissions).HasColumnName("permissions");
            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("roleName");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity.HasKey(e => e.RouteId).HasName("PK__Routes__BAC024C7D2A2FDBD");

            entity.Property(e => e.RouteId)
                .ValueGeneratedNever()
                .HasColumnName("routeId");
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
                .HasConstraintName("FK__Routes__creatorI__7D439ABD");
        });

        modelBuilder.Entity<RouteCheckpoint>(entity =>
        {
            entity.HasKey(e => e.PointId).HasName("PK__RouteChe__4CB435AE19DB62D3");

            entity.Property(e => e.PointId)
                .ValueGeneratedNever()
                .HasColumnName("pointId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Lng).HasColumnName("lng");
            entity.Property(e => e.PointName)
                .HasMaxLength(255)
                .HasColumnName("pointName");
            entity.Property(e => e.PointNumber).HasColumnName("pointNumber");
            entity.Property(e => e.SegmentId).HasColumnName("segmentId");
            entity.Property(e => e.SequenceNumber).HasColumnName("sequenceNumber");

            entity.HasOne(d => d.Segment).WithMany(p => p.RouteCheckpoints)
                .HasForeignKey(d => d.SegmentId)
                .HasConstraintName("FK__RouteChec__segme__00200768");
        });

        modelBuilder.Entity<RouteReference>(entity =>
        {
            entity.HasKey(e => e.ReferenceId).HasName("PK__RouteRef__7B826DDE38F08AA5");

            entity.Property(e => e.ReferenceId)
                .ValueGeneratedNever()
                .HasColumnName("referenceId");
            entity.Property(e => e.BlogId).HasColumnName("blogId");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.RouteId).HasColumnName("routeId");

            entity.HasOne(d => d.Blog).WithMany(p => p.RouteReferences)
                .HasForeignKey(d => d.BlogId)
                .HasConstraintName("FK__RouteRefe__blogI__02FC7413");

            entity.HasOne(d => d.Route).WithMany(p => p.RouteReferences)
                .HasForeignKey(d => d.RouteId)
                .HasConstraintName("FK__RouteRefe__route__03F0984C");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.ServiceId).HasName("PK__Services__455070DF0F3BF123");

            entity.Property(e => e.ServiceId)
                .ValueGeneratedNever()
                .HasColumnName("serviceId");
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
                .HasConstraintName("FK__Services__catego__5441852A");
        });

        modelBuilder.Entity<ServiceCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__ServiceC__23CAF1D8EBB3CF64");

            entity.Property(e => e.CategoryId)
                .ValueGeneratedNever()
                .HasColumnName("categoryId");
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
            entity.HasKey(e => e.UserId).HasName("PK__Users__CB9A1CFF06904314");

            entity.HasIndex(e => e.Email, "UQ__Users__AB6E61644D63A23C").IsUnique();

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("userId");
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
                .HasConstraintName("FK__Users__roleId__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
