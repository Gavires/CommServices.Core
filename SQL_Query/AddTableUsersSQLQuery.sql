CREATE TABLE Users (
  id bigint IDENTITY(1,1) PRIMARY KEY,
  UserName VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Name VARCHAR(100) NOT NULL,
  LastName VARCHAR(100) NULL,
  Password VARCHAR(100) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
  Email VARCHAR(100) NULL,
  IsAdmin BIT NOT NULL,
  UserRegistrationHistoriesId bigint NOT NULL,
  UNIQUE (UserName, Name, Password, Email),
  --FOREIGN KEY (UserRegistrationHistoriesId) REFERENCES [PCS].[dbo].UserRegistrationHistories(id),
);