CREATE TABLE ActionUser (
  id INT PRIMARY KEY,
  ActionName VARCHAR(50) NOT NULL,
  ActionCode VARCHAR(50) NOT NULL,
  UNIQUE (ActionName, ActionCode)
);