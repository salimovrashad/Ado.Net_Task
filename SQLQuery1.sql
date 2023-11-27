CREATE DATABASE BlogUser
USE BlogUser

CREATE TABLE Users(
	ID int identity PRIMARY KEY,
	Name nvarchar(255) NOT NULL,
	Surname nvarchar(255) NOT NULL,
	Password varchar(255) NOT NULL CHECK (LEN(Password) >= 8)
);

CREATE TABLE Blogs(
	ID int identity PRIMARY KEY,
	Title nvarchar(255) NOT NULL,
	Description nvarchar(255) NOT NULL,
	UsersID int references Users(ID) NOT NULL
);

INSERT INTO Users
VALUES (N'Rəşad', N'Səlimov', 'rashadsalim123');

INSERT INTO Blogs
VALUES (N'BlogTitle', N'BlogDescription', 1);

SELECT* FROM Blogs WHERE ID = 1

UPDATE Blogs SET Title = 'Blogtitle', Description= 'Blogdesc' WHERE Blogs.ID = 1;