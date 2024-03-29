CREATE TABLE Admins (
  id bigint IDENTITY(1,1) PRIMARY KEY,
  LoginName VARCHAR(50) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Password VARCHAR(50) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Email VARCHAR(100) NULL,
  UNIQUE (LoginName, Password, Email)
);