CREATE TABLE USERS (
  id INT NOT NULL,
  UserName VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Name VARCHAR(100) NOT NULL,
  LastName VARCHAR(100) NULL,
  Password VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Email VARCHAR(100) NULL,
  IsAdmin BIT NOT NULL,
  PRIMARY KEY (id),
  UNIQUE (UserName, Name, Password, Email)
);