create table Users(
	userID int identity(1,1) primary key,
	name varchar(70),
	email varchar(70),
	password varchar(70),
	type varchar(10)
);select * from Users

create table class(
	classID int identity(1,1) primary key,
	name varchar(70),
	code varchar(12),
	);select * from class
	
	delete from class where classID=2;
create table enrolls(
	userID int,
	classID int

	foreign key (userID) references Users (UserID) on delete cascade,
	foreign key (classID) references class (classID) on delete cascade
	);

create table teaches(
	userID int,
	classID int

	foreign key (userID) references Users (UserID) on delete cascade,
	foreign key (classID) references class (classID) on delete cascade 
	);delete from teaches where userID=6 


create table post(
	postID int identity(1,1) primary key,
	pDateTime datetime,
	title varchar(80),
	type varchar(20),
	statement varchar(max)
	); select * from post
alter table post
add userID int,

foreign key (userID) references Users (UserID),
classID int,
foreign key (classID) references class (classID);

select p.postID, p.pDateTime, p.title, p.userID, u.name from post p inner join Users u on p.userID = u.userID where p.classID = 1;

create table comment(
	commentID int identity(1,1) primary key,
	statement varchar(max),
	userID int,
	postID int,

	foreign key (userID) references Users (UserID) on delete cascade ,
	foreign key (postID) references post (postID) on delete cascade 
	);	select * from comment

select c.commentID, c.statement, u.name, u.type, u.userID from comment c inner join Users u on c.userID=u.userID where c.postID=1;

create table Files(
	id int identity(1,1) primary key,
	data varbinary(max),
	extension char(5),
	fname varchar(150),
	submissionFileFlag int,
	attachedFileFlag int,
	postID int,
	userID int,

	foreign key (userID) references Users (UserID) on delete cascade ,
	foreign key (postID) references post (postID) on delete cascade 
	);select * from Files
	select fname from Files where postID=5 and userID=2;
	select fname from Files
create table Assignment (
	assignmentID int identity(1,1),
	submissionDate datetime,
	totalMarks int,
	obtainedMarks int,
	postID int,

	foreign key (postID) references post (postID) on delete cascade 
	);select * from Assignment

	select a.submissionDate, p.statement from Assignment a inner join post p on a.postID=p.postID where p.postID=1

	SELECT COUNT(DISTINCT userID) AS TotalPeople
FROM Files
WHERE postID = 1 AND submissionFileFlag = 1;

GO
CREATE FUNCTION dbo.GetPostsByClassID (@classID INT)
RETURNS TABLE
AS
RETURN
    SELECT p.postID, p.pDateTime, p.title, p.type, u.name
    FROM post p
    INNER JOIN Users u ON p.userID = u.userID
    WHERE p.classID = @classID;
GO
CREATE FUNCTION dbo.GetClassesByUserID (@userID INT)
RETURNS TABLE
AS
RETURN
    SELECT c.classID, c.name, c.code
    FROM class c
    JOIN teaches t ON c.classID = t.classID
    WHERE t.userID = @userID;
GO
CREATE FUNCTION dbo.GetStudentClassDetailsByUserID (@userID INT)
RETURNS TABLE
AS
RETURN
    SELECT class.classID, class.name AS className, Users.name AS userName
    FROM class
    INNER JOIN teaches ON class.classID = teaches.classID
    INNER JOIN Users ON teaches.userID = Users.userID
    INNER JOIN enrolls ON class.classID = enrolls.classID
    WHERE enrolls.userID = @userID;


