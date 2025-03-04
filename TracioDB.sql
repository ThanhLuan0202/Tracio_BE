IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TracioDB')
BEGIN
    CREATE DATABASE TracioDB;
END
GO

USE TracioDB;
GO

-- Bảng Roles
CREATE TABLE Roles (
    roleId INT PRIMARY KEY,
    roleName NVARCHAR(255),
    permissions NVARCHAR(MAX)
);

-- Bảng Users
CREATE TABLE Users (
    userId INT PRIMARY KEY,
    fullName NVARCHAR(255),
    email NVARCHAR(255) UNIQUE,
    password NVARCHAR(255),
    phoneNumber NVARCHAR(20),
    roleId INT,
    address NVARCHAR(MAX),
    createdTime DATETIME,
    updatedTime DATETIME,
    MemberShipId INT,
    FOREIGN KEY (roleId) REFERENCES Roles(roleId)
);

-- Bảng ServiceCategories
CREATE TABLE ServiceCategories (
    categoryId INT PRIMARY KEY,
    categoryName NVARCHAR(255),
    description NVARCHAR(MAX)
);

-- Bảng Services
CREATE TABLE Services (
    serviceId INT PRIMARY KEY,
    serviceName NVARCHAR(255),
    description NVARCHAR(MAX),
    price DECIMAL(10,2),
    availability INT,
    estimatedTime FLOAT,
    rating FLOAT,
    categoryId INT,
    FOREIGN KEY (categoryId) REFERENCES ServiceCategories(categoryId)
);

-- Bảng BookingServices
CREATE TABLE BookingServices (
    serviceBookingId INT PRIMARY KEY,
    serviceId INT,
    bookingId INT,
    Quantity INT,
    subtotal DECIMAL(10,2),
    notes NVARCHAR(MAX),
    FOREIGN KEY (serviceId) REFERENCES Services(serviceId),
    FOREIGN KEY (bookingId) REFERENCES Bookings(productId)   
	
);

-- Bảng ProductsCategories
CREATE TABLE ProductsCategories (
    categoryId INT PRIMARY KEY,
    categoryName NVARCHAR(255),
    description NVARCHAR(MAX)
);

-- Bảng Products
CREATE TABLE Products (
    productId INT PRIMARY KEY,
    productName NVARCHAR(255),
    description NVARCHAR(MAX),
    stockQuantity INT,
    categoryId INT,
    condition NVARCHAR(MAX),
    createdTime DATETIME,
    image NVARCHAR(MAX),
    FOREIGN KEY (categoryId) REFERENCES ProductsCategories(categoryId)
);

-- Bảng Bookings
CREATE TABLE Bookings (
    bookingId INT PRIMARY KEY,
    userId INT,
    bookingDate DATETIME,
    status NVARCHAR(50),
    notes NVARCHAR(MAX),
    totalAmount DECIMAL(10,2),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);

-- Bảng BookingProducts
CREATE TABLE BookingProducts (
    productBookingId INT PRIMARY KEY,
    productId INT,
    bookingId INT,
    Quantity INT,
    subtotal DECIMAL(10,2),
    notes NVARCHAR(MAX),
    FOREIGN KEY (productId) REFERENCES Products(productId),
    FOREIGN KEY (bookingId) REFERENCES Bookings(bookingId)
);

-- Bảng Reviews
CREATE TABLE Reviews (
    reviewId INT PRIMARY KEY,
    userId INT,
    targetId INT,
    targetType NVARCHAR(255),
    rating INT,
    content NVARCHAR(MAX),
    createdTime DATETIME,
    FOREIGN KEY (userId) REFERENCES Users(userId)
);

-- Bảng Blogs
CREATE TABLE Blogs (
    blogId INT PRIMARY KEY,
    authorId INT,
	categoryId INT,
    title NVARCHAR(255),
    content NVARCHAR(MAX),
    tagId INT,
    likeCount INT,
    createdTime DATETIME,
    updatedTime DATETIME,
    FOREIGN KEY (authorId) REFERENCES Users(userId),
    FOREIGN KEY (categoryId) REFERENCES BlogCategories(categoryId),
	FOREIGN KEY (tagId) REFERENCES BlogTags(lagId)

); 

-- Bảng BlogTags
CREATE TABLE BlogTags (
    lagId INT PRIMARY KEY,
    tagName NVARCHAR(255)
);

-- Bảng BlogCategories
CREATE TABLE BlogCategories (
    categoryId INT PRIMARY KEY,
    categoryName NVARCHAR(255),
    description NVARCHAR(MAX)
);

-- Bảng Group
CREATE TABLE [Group] (
    groupId INT PRIMARY KEY,
    groupName NVARCHAR(255),
    description NVARCHAR(MAX),
    creatorId INT,
    memberCount INT,
    status NVARCHAR(50),
    createdTime DATETIME,
    updatedTime DATETIME,
    FOREIGN KEY (creatorId) REFERENCES Users(userId)
);

-- Bảng GroupMember
CREATE TABLE GroupMember (
    MemberShipId INT PRIMARY KEY,
    groupId INT,
    userId INT,
    status NVARCHAR(50),
    joinedTime DATETIME,
    FOREIGN KEY (groupId) REFERENCES [Group](groupId),
    FOREIGN KEY (userId) REFERENCES Users(userId)
);

-- Bảng ChatOfGroup
CREATE TABLE ChatOfGroup (
    groupChatId INT PRIMARY KEY,
    content NVARCHAR(MAX),
    userId INT,
    groupId INT,
    createdTime DATETIME,
    FOREIGN KEY (userId) REFERENCES Users(userId),
    FOREIGN KEY (groupId) REFERENCES [Group](groupId)
);

-- Bảng Routes
CREATE TABLE Routes (
    routeId INT PRIMARY KEY,
    creatorId INT,
    startLocation NVARCHAR(MAX),
    endLocation NVARCHAR(MAX),
    distance FLOAT,
    estimatedTime FLOAT,
    routeDescription NVARCHAR(MAX),
    sharedWithPublic BIT,
    createdTime DATETIME,
    routePath NVARCHAR(MAX),
    segmentPolyline NVARCHAR(MAX),
    StreetList NVARCHAR(MAX),
    FOREIGN KEY (creatorId) REFERENCES Users(userId)
);

-- Bảng RouteCheckpoints
CREATE TABLE RouteCheckpoints (
    pointId INT PRIMARY KEY,
    segmentId INT,
    pointNumber INT,
    pointName NVARCHAR(255),
    sequenceNumber INT,
    description NVARCHAR(MAX),
    lng FLOAT,
    FOREIGN KEY (segmentId) REFERENCES Routes(routeId)
);

-- Bảng RouteReferences
CREATE TABLE RouteReferences (
    referenceId INT PRIMARY KEY,
    blogId INT,
    routeId INT,
    description NVARCHAR(MAX),
    FOREIGN KEY (blogId) REFERENCES Blogs(blogId),
    FOREIGN KEY (routeId) REFERENCES Routes(routeId)
);

-- Bảng GroupRoutes
CREATE TABLE GroupRoutes (
    groupRouteId INT PRIMARY KEY,
    groupId INT,
    routeId INT,
    content NVARCHAR(MAX),
    SharedTime DATETIME,
    FOREIGN KEY (groupId) REFERENCES [Group](groupId),
    FOREIGN KEY (routeId) REFERENCES Routes(routeId)
);