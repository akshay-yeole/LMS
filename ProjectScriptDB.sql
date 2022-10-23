USE LMS
GO
CREATE TABLE BookCategories (
	Categoryid INT ,
	CategoryName VARCHAR(100),
	CONSTRAINT PK_Books_categories PRIMARY KEY(Categoryid)
);

GO
CREATE TABLE Books(
	BookCode INT , 
	BookName VARCHAR(100) NOT NULL, 
	CopiesAvailable INT, 
	Author VARCHAR(100) NOT NULL, 
	Categoryid int ,
	CONSTRAINT PK_Books PRIMARY KEY (BookCode),
	CONSTRAINT FK_Books FOREIGN KEY (Categoryid) references BookCategories(Categoryid)
);

GO
CREATE TABLE AppUsers(
	AppUserId INT ,
	AppUserName VARCHAR(100), 
	UPassword VARCHAR(100),
	CONSTRAINT PK_AppUsers PRIMARY KEY (AppUserId)
);

INSERT INTO AppUsers VALUES (1,'admin','admin');

GO
CREATE TABLE Students(
	Std INT,
	Div VARCHAR(10), 
	Rollno INT, 
	UName VARCHAR(50), 
	UAddress VARCHAR(100),
	CONSTRAINT PK_Students PRIMARY KEY(Std,Div,RollNo)
);

GO
CREATE TABLE LibraryTransactions(
	LibTransactionNo INT identity(1,1), 
	BookIssueDate varchar(50), 
	ExpectedReturnDate varchar(50), 
	ActualReturnDate varchar(50), 
	Fine money, 
	Std  int ,
	Div  varchar(10) ,
	Rollno int , 
	BookCode int,
	CONSTRAINT PK_LibraryTransactions PRIMARY KEY(LibTransactionNo),
	CONSTRAINT FK_Library_Tran FOREIGN KEY(Std,Div,RollNo) REFERENCES Students(Std,Div,RollNo),
	CONSTRAINT FK_BookCode FOREIGN KEY(BookCode) REFERENCES Books(BookCode)
);


--Procedures
GO 
CREATE PROCEDURE sp_AppUser
(
	@UserName VARCHAR(100),
	@Password VARCHAR(100)
)	
AS
BEGIN
	SELECT count(*) FROM AppUsers WHERE AppUserName=@UserName AND UPassword=@Password; 
END

GO
CREATE PROCEDURE sp_AddBook
(
	@BookCode INT,
	@BookName VARCHAR(100),
	@CopiesAvailable INT, 
	@Author VARCHAR(100), 
	@Categoryid int 
)
AS
BEGIN
	INSERT INTO Books VALUES(@BookCode,@BookName,@CopiesAvailable,@Author,@Categoryid);
END;

EXEC sp_AddBook 111,"C",10,"Yashwant Kanitkar",101;

GO
CREATE PROCEDURE sp_AddCategory
(
	@Categoryid INT ,
	@CategoryName VARCHAR(100)
)
AS
BEGIN
	INSERT INTO BookCategories VALUES(@Categoryid,@CategoryName);
END;

EXEC sp_AddCategory 101,"Programming";

GO
ALTER PROCEDURE sp_AddStudent
(
	@Std INT,
	@Div VARCHAR(10), 
	@Rollno INT, 
	@Name VARCHAR(50), 
	@Address VARCHAR(100)
)
AS
BEGIN
	INSERT INTO Students VALUES (@Std,@Div,@Rollno,@Name,@Address);
END;

EXEC sp_AddStudent 8,b,11,"akshay","malegaon";

GO
CREATE PROCEDURE sp_AllBooks
AS
BEGIN
	SELECT * FROM Books 
END

GO 
CREATE PROCEDURE sp_AddBookCategory
(
	@CategoryID INT,
	@CategoryName VARCHAR(100)
)
AS
BEGIN
	INSERT INTO BookCategories VALUES(@CategoryID,@CategoryName);
END;


GO
CREATE PROCEDURE sp_UpdateStudentDetails
(
	@Std INT,
	@Div VARCHAR(10), 
	@Rollno INT, 
	@Name VARCHAR(50), 
	@Address VARCHAR(100)
)
AS
BEGIN
	Update Students 
	SET Std=@Std,Div=@Div,UName=@Name,UAddress=@Address
	WHERE Rollno=@Rollno;
END;



select * from BookCategories
select * from Books
select * from Students

select * from Books b 
join BookCategories bc ON(Categoryid);