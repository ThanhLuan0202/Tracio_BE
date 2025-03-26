IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [BlogCategories] (
        [categoryId] int NOT NULL IDENTITY,
        [categoryName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        CONSTRAINT [PK__BlogCate__23CAF1D810C9BAEB] PRIMARY KEY ([categoryId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [BlogTags] (
        [tagId] int NOT NULL IDENTITY,
        [tagName] nvarchar(255) NULL,
        CONSTRAINT [PK__BlogTags__50FC01578EDDCA23] PRIMARY KEY ([tagId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [ProductsCategories] (
        [categoryId] int NOT NULL IDENTITY,
        [categoryName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Products__23CAF1D811636B80] PRIMARY KEY ([categoryId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Roles] (
        [roleId] int NOT NULL IDENTITY,
        [roleName] nvarchar(255) NULL,
        [permissions] nvarchar(max) NULL,
        CONSTRAINT [PK__Roles__CD98462A2BE0A9C9] PRIMARY KEY ([roleId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [ServiceCategories] (
        [categoryId] int NOT NULL IDENTITY,
        [categoryName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__ServiceC__23CAF1D8C383CAB7] PRIMARY KEY ([categoryId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Products] (
        [productId] int NOT NULL IDENTITY,
        [productName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        [stockQuantity] int NULL,
        [categoryId] int NULL,
        [condition] nvarchar(max) NULL,
        [createdTime] datetime NULL,
        [image] nvarchar(max) NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Products__2D10D16A751C21D1] PRIMARY KEY ([productId]),
        CONSTRAINT [FK__Products__catego__4AB81AF0] FOREIGN KEY ([categoryId]) REFERENCES [ProductsCategories] ([categoryId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Users] (
        [userId] int NOT NULL IDENTITY,
        [fullName] nvarchar(255) NULL,
        [email] nvarchar(255) NULL,
        [password] nvarchar(255) NULL,
        [phoneNumber] nvarchar(20) NULL,
        [roleId] int NULL,
        [address] nvarchar(max) NULL,
        [IsEmailConfirmed] bit NOT NULL,
        [EmailConfirmationToken] nvarchar(max) NULL,
        [createdTime] datetime NULL,
        [updatedTime] datetime NULL,
        [MemberShipId] int NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Users__CB9A1CFFE397DAC0] PRIMARY KEY ([userId]),
        CONSTRAINT [FK__Users__roleId__3A81B327] FOREIGN KEY ([roleId]) REFERENCES [Roles] ([roleId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Services] (
        [serviceId] int NOT NULL IDENTITY,
        [serviceName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        [price] decimal(10,2) NULL,
        [availability] int NULL,
        [estimatedTime] float NULL,
        [rating] float NULL,
        [categoryId] int NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Services__455070DF61C080D5] PRIMARY KEY ([serviceId]),
        CONSTRAINT [FK__Services__catego__4222D4EF] FOREIGN KEY ([categoryId]) REFERENCES [ServiceCategories] ([categoryId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Blogs] (
        [blogId] int NOT NULL IDENTITY,
        [authorId] int NULL,
        [categoryId] int NULL,
        [title] nvarchar(255) NULL,
        [content] nvarchar(max) NULL,
        [tagId] int NULL,
        [likeCount] int NULL,
        [createdTime] datetime NULL,
        [updatedTime] datetime NULL,
        CONSTRAINT [PK__Blogs__FA0AA72DECC9C036] PRIMARY KEY ([blogId]),
        CONSTRAINT [FK__Blogs__authorId__5BE2A6F2] FOREIGN KEY ([authorId]) REFERENCES [Users] ([userId]),
        CONSTRAINT [FK__Blogs__categoryI__5CD6CB2B] FOREIGN KEY ([categoryId]) REFERENCES [BlogCategories] ([categoryId]),
        CONSTRAINT [FK__Blogs__tagId__5DCAEF64] FOREIGN KEY ([tagId]) REFERENCES [BlogTags] ([tagId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Bookings] (
        [bookingId] int NOT NULL IDENTITY,
        [userId] int NULL,
        [bookingDate] datetime NULL,
        [status] nvarchar(50) NULL,
        [notes] nvarchar(max) NULL,
        [totalAmount] decimal(10,2) NULL,
        CONSTRAINT [PK__Bookings__C6D03BCD395AA970] PRIMARY KEY ([bookingId]),
        CONSTRAINT [FK__Bookings__userId__3F466844] FOREIGN KEY ([userId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Group] (
        [groupId] int NOT NULL IDENTITY,
        [groupName] nvarchar(255) NULL,
        [description] nvarchar(max) NULL,
        [creatorId] int NULL,
        [memberCount] int NULL,
        [status] nvarchar(50) NULL,
        [createdTime] datetime NULL,
        [updatedTime] datetime NULL,
        CONSTRAINT [PK__Group__88C1034DE87CDEF9] PRIMARY KEY ([groupId]),
        CONSTRAINT [FK__Group__creatorId__619B8048] FOREIGN KEY ([creatorId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Reviews] (
        [reviewId] int NOT NULL IDENTITY,
        [userId] int NULL,
        [targetId] int NULL,
        [targetType] nvarchar(255) NULL,
        [rating] int NULL,
        [content] nvarchar(max) NULL,
        [createdTime] datetime NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Reviews__2ECD6E04338822CD] PRIMARY KEY ([reviewId]),
        CONSTRAINT [FK__Reviews__userId__5165187F] FOREIGN KEY ([userId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [Routes] (
        [routeId] int NOT NULL IDENTITY,
        [creatorId] int NULL,
        [startLocation] nvarchar(max) NULL,
        [endLocation] nvarchar(max) NULL,
        [distance] float NULL,
        [estimatedTime] float NULL,
        [routeDescription] nvarchar(max) NULL,
        [sharedWithPublic] bit NULL,
        [createdTime] datetime NULL,
        [routePath] nvarchar(max) NULL,
        [segmentPolyline] nvarchar(max) NULL,
        [StreetList] nvarchar(max) NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__Routes__BAC024C7EE29B214] PRIMARY KEY ([routeId]),
        CONSTRAINT [FK__Routes__creatorI__6C190EBB] FOREIGN KEY ([creatorId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [BookingProducts] (
        [productBookingId] int NOT NULL IDENTITY,
        [productId] int NULL,
        [bookingId] int NULL,
        [Quantity] int NULL,
        [subtotal] decimal(10,2) NULL,
        [notes] nvarchar(max) NULL,
        CONSTRAINT [PK__BookingP__DAC8E7610CF4C426] PRIMARY KEY ([productBookingId]),
        CONSTRAINT [FK__BookingPr__booki__4E88ABD4] FOREIGN KEY ([bookingId]) REFERENCES [Bookings] ([bookingId]),
        CONSTRAINT [FK__BookingPr__produ__4D94879B] FOREIGN KEY ([productId]) REFERENCES [Products] ([productId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [BookingServices] (
        [serviceBookingId] int NOT NULL IDENTITY,
        [serviceId] int NULL,
        [bookingId] int NULL,
        [Quantity] int NULL,
        [subtotal] decimal(10,2) NULL,
        [notes] nvarchar(max) NULL,
        CONSTRAINT [PK__BookingS__37EED9306FD7CC74] PRIMARY KEY ([serviceBookingId]),
        CONSTRAINT [FK__BookingSe__booki__45F365D3] FOREIGN KEY ([bookingId]) REFERENCES [Bookings] ([bookingId]),
        CONSTRAINT [FK__BookingSe__servi__44FF419A] FOREIGN KEY ([serviceId]) REFERENCES [Services] ([serviceId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [ChatOfGroup] (
        [groupChatId] int NOT NULL IDENTITY,
        [content] nvarchar(max) NULL,
        [userId] int NULL,
        [groupId] int NULL,
        [createdTime] datetime NULL,
        CONSTRAINT [PK__ChatOfGr__8453A397ED9ED409] PRIMARY KEY ([groupChatId]),
        CONSTRAINT [FK__ChatOfGro__group__693CA210] FOREIGN KEY ([groupId]) REFERENCES [Group] ([groupId]),
        CONSTRAINT [FK__ChatOfGro__userI__68487DD7] FOREIGN KEY ([userId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [GroupMember] (
        [MemberShipId] int NOT NULL IDENTITY,
        [groupId] int NULL,
        [userId] int NULL,
        [status] nvarchar(50) NULL,
        [joinedTime] datetime NULL,
        CONSTRAINT [PK__GroupMem__543A6D5BF8456B05] PRIMARY KEY ([MemberShipId]),
        CONSTRAINT [FK__GroupMemb__group__6477ECF3] FOREIGN KEY ([groupId]) REFERENCES [Group] ([groupId]),
        CONSTRAINT [FK__GroupMemb__userI__656C112C] FOREIGN KEY ([userId]) REFERENCES [Users] ([userId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [GroupRoutes] (
        [groupRouteId] int NOT NULL IDENTITY,
        [groupId] int NULL,
        [routeId] int NULL,
        [content] nvarchar(max) NULL,
        [SharedTime] datetime NULL,
        CONSTRAINT [PK__GroupRou__D8AC9C3240222212] PRIMARY KEY ([groupRouteId]),
        CONSTRAINT [FK__GroupRout__group__75A278F5] FOREIGN KEY ([groupId]) REFERENCES [Group] ([groupId]),
        CONSTRAINT [FK__GroupRout__route__76969D2E] FOREIGN KEY ([routeId]) REFERENCES [Routes] ([routeId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [RouteCheckpoints] (
        [pointId] int NOT NULL IDENTITY,
        [segmentId] int NULL,
        [pointNumber] int NULL,
        [pointName] nvarchar(255) NULL,
        [sequenceNumber] int NULL,
        [description] nvarchar(max) NULL,
        [lng] float NULL,
        [status] nvarchar(50) NULL,
        CONSTRAINT [PK__RouteChe__4CB435AE529C9236] PRIMARY KEY ([pointId]),
        CONSTRAINT [FK__RouteChec__segme__6EF57B66] FOREIGN KEY ([segmentId]) REFERENCES [Routes] ([routeId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE TABLE [RouteReferences] (
        [referenceId] int NOT NULL IDENTITY,
        [blogId] int NULL,
        [routeId] int NULL,
        [description] nvarchar(max) NULL,
        CONSTRAINT [PK__RouteRef__7B826DDEA9D955CB] PRIMARY KEY ([referenceId]),
        CONSTRAINT [FK__RouteRefe__blogI__71D1E811] FOREIGN KEY ([blogId]) REFERENCES [Blogs] ([blogId]),
        CONSTRAINT [FK__RouteRefe__route__72C60C4A] FOREIGN KEY ([routeId]) REFERENCES [Routes] ([routeId])
    );
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Blogs_authorId] ON [Blogs] ([authorId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Blogs_categoryId] ON [Blogs] ([categoryId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Blogs_tagId] ON [Blogs] ([tagId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_BookingProducts_bookingId] ON [BookingProducts] ([bookingId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_BookingProducts_productId] ON [BookingProducts] ([productId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Bookings_userId] ON [Bookings] ([userId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_BookingServices_bookingId] ON [BookingServices] ([bookingId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_BookingServices_serviceId] ON [BookingServices] ([serviceId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_ChatOfGroup_groupId] ON [ChatOfGroup] ([groupId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_ChatOfGroup_userId] ON [ChatOfGroup] ([userId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Group_creatorId] ON [Group] ([creatorId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_GroupMember_groupId] ON [GroupMember] ([groupId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_GroupMember_userId] ON [GroupMember] ([userId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_GroupRoutes_groupId] ON [GroupRoutes] ([groupId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_GroupRoutes_routeId] ON [GroupRoutes] ([routeId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Products_categoryId] ON [Products] ([categoryId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Reviews_userId] ON [Reviews] ([userId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_RouteCheckpoints_segmentId] ON [RouteCheckpoints] ([segmentId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_RouteReferences_blogId] ON [RouteReferences] ([blogId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_RouteReferences_routeId] ON [RouteReferences] ([routeId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Routes_creatorId] ON [Routes] ([creatorId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Services_categoryId] ON [Services] ([categoryId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    CREATE INDEX [IX_Users_roleId] ON [Users] ([roleId]);
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [UQ__Users__AB6E6164B1F52597] ON [Users] ([email]) WHERE [email] IS NOT NULL');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141613_upds'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250310141613_upds', N'9.0.2');
END;

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20250310141728_updss'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20250310141728_updss', N'9.0.2');
END;

COMMIT;
GO

