/****** Script for SelectTopNRows command from SSMS  ******/
CREATE TABLE UserRegistrationHistory (
  id INT PRIMARY KEY,
  userId INT NOT NULL,
  LoginName VARCHAR(45) NOT NULL,
  registrationDate DATETIME NOT NULL,
  registrationIp VARCHAR(45) NULL,
  registrationCountry VARCHAR(50) NULL,
  registrationDevice VARCHAR(100) NULL,
  referralCode VARCHAR(20) NULL,
  ActionID INT NOT NULL
  FOREIGN KEY (userId) REFERENCES [PCS].[dbo].[Users](id)
);
  
  
