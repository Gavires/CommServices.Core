/****** Script for SelectTopNRows command from SSMS  ******/
CREATE TABLE UserRegistrationHistory (
  id bigint IDENTITY(1,1) PRIMARY KEY,
  UserId bigint NOT NULL,
  LoginName VARCHAR(45) NOT NULL,
  RegistrationDate DATETIME NOT NULL,
  RegistrationIp VARCHAR(45) NULL,
  RegistrationCountry VARCHAR(50) NULL,
  RegistrationDevice VARCHAR(100) NULL,
  ReferralCode VARCHAR(20) NULL,
  ActionUserId bigint NOT NULL
  FOREIGN KEY (UserId) REFERENCES [PCS].[dbo].[Users](id),
  FOREIGN KEY (ActionUserId) REFERENCES [PCS].[dbo].[ActionUser](id),
);
  
  
