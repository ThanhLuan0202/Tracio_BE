IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TracioDB')
BEGIN
    CREATE DATABASE TracioDB;
END
GO

USE TracioDB;
GO

CREATE TABLE Users (
    userId INT IDENTITY(1,1) PRIMARY KEY,
    fullName NVARCHAR(255) NOT NULL,
    email NVARCHAR(255) UNIQUE NOT NULL,
    password NVARCHAR(255) NOT NULL,
    phoneNumber NVARCHAR(20) UNIQUE NOT NULL,
    roleId INT,
    cyclingLevel NVARCHAR(50),
    preferredRouteTypes NVARCHAR(MAX),
    createdTime DATETIME DEFAULT GETDATE(),
    updatedTime DATETIME DEFAULT GETDATE(),
    MemberShipId INT,
    FOREIGN KEY (roleId) REFERENCES Roles(roleId)
);
GO

CREATE TABLE Roles (
    roleId INT IDENTITY(1,1) PRIMARY KEY,
    roleName NVARCHAR(100) NOT NULL,
    permissions NVARCHAR(MAX)
);
GO

CREATE TABLE Services (
    serviceId INT IDENTITY(1,1) PRIMARY KEY,
    serviceName NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),
    price DECIMAL(10,2),
    estimatedTime FLOAT,
    rating FLOAT,
    categoryId INT,
    FOREIGN KEY (categoryId) REFERENCES ServiceCategories(categoryId)
);
GO

CREATE TABLE ServiceCategories (
    categoryId INT IDENTITY(1,1) PRIMARY KEY,
    categoryName NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX)
);
GO

CREATE TABLE Bookings (
    bookingId INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    bookingDate DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50),
    notes NVARCHAR(MAX),
    totalAmount DECIMAL(10,2),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);
GO

CREATE TABLE BookingServices (
    serviceBookingId INT IDENTITY(1,1) PRIMARY KEY,
    bookingId INT,
    serviceId INT,
    quantity INT,
    subtotal DECIMAL(10,2),
    notes NVARCHAR(MAX),
    FOREIGN KEY (bookingId) REFERENCES Bookings(bookingId),
    FOREIGN KEY (serviceId) REFERENCES Services(serviceId)
);
GO

CREATE TABLE Products (
    productId INT IDENTITY(1,1) PRIMARY KEY,
    productName NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX),
    price DECIMAL(10,2),
    stockQuantity INT,
    brand NVARCHAR(255),
    rating FLOAT,
    createdTime DATETIME DEFAULT GETDATE(),
    image NVARCHAR(255)
);
GO

CREATE TABLE BookingProducts (
    productBookingId INT IDENTITY(1,1) PRIMARY KEY,
    bookingId INT,
    productId INT,
    quantity INT,
    subtotal DECIMAL(10,2),
    notes NVARCHAR(MAX),
    FOREIGN KEY (bookingId) REFERENCES Bookings(bookingId),
    FOREIGN KEY (productId) REFERENCES Products(productId)
);
GO

CREATE TABLE ProductsCategories (
    categoryId INT IDENTITY(1,1) PRIMARY KEY,
    categoryName NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX)
);
GO

CREATE TABLE Reviews (
    reviewId INT IDENTITY(1,1) PRIMARY KEY,
    userId INT,
    targetType NVARCHAR(50),
    rating INT CHECK (rating BETWEEN 1 AND 5),
    content NVARCHAR(MAX),
    createdTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);
GO

CREATE TABLE [Group] (
    groupId INT IDENTITY(1,1) PRIMARY KEY,
    groupName NVARCHAR(255) NOT NULL,
    creatorId INT,
    memberCount INT,
    createdTime DATETIME DEFAULT GETDATE(),
    updatedTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (creatorId) REFERENCES Users(userId)
);
GO

CREATE TABLE GroupMember (
    memberShipId INT IDENTITY(1,1) PRIMARY KEY,
    groupId INT,
    userId INT,
    status NVARCHAR(50),
    joinedTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (groupId) REFERENCES [Group](groupId),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);
GO

CREATE TABLE Rides (
    rideId INT IDENTITY(1,1) PRIMARY KEY,
    routeId INT,
    creatorId INT,
    startTime DATETIME,
    endTime DATETIME,
    difficultyLevel NVARCHAR(50),
    FOREIGN KEY (routeId) REFERENCES RouteReferences(referenceId),
    FOREIGN KEY (creatorId) REFERENCES Users(userId)
);
GO

CREATE TABLE Blogs (
    blogId INT IDENTITY(1,1) PRIMARY KEY,
    authorId INT,
    title NVARCHAR(255) NOT NULL,
    content NVARCHAR(MAX),
    tagId INT,
    viewCount INT DEFAULT 0,
    likeCount INT DEFAULT 0,
    createdTime DATETIME DEFAULT GETDATE(),
    updatedTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (authorId) REFERENCES Users(userId)
);
GO

CREATE TABLE BlogTags (
    tagId INT IDENTITY(1,1) PRIMARY KEY,
    tagName NVARCHAR(255) NOT NULL
);
GO

CREATE TABLE BlogCategories (
    categoryId INT IDENTITY(1,1) PRIMARY KEY,
    categoryName NVARCHAR(255) NOT NULL,
    description NVARCHAR(MAX)
);
GO

CREATE TABLE RouteReferences (
    referenceId INT IDENTITY(1,1) PRIMARY KEY,
    blogId INT,
    routeId INT,
    latitude FLOAT,
    longitude FLOAT,
    sequenceNumber INT,
    description NVARCHAR(MAX),
    FOREIGN KEY (blogId) REFERENCES Blogs(blogId),
    FOREIGN KEY (routeId) REFERENCES Rides(rideId)
);
GO

CREATE TABLE GroupRoutes (
    groupRouteId INT IDENTITY(1,1) PRIMARY KEY,
    groupId INT,
    routeId INT,
    content NVARCHAR(MAX),
    sharedTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (groupId) REFERENCES [Group](groupId),
    FOREIGN KEY (routeId) REFERENCES Rides(rideId)
);
GO

CREATE TABLE ChatOfGroup (
    groupChatId INT IDENTITY(1,1) PRIMARY KEY,
    groupId INT,
    userId INT,
    content NVARCHAR(MAX),
    createdTime DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (groupId) REFERENCES [Group](groupId),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);
GO
