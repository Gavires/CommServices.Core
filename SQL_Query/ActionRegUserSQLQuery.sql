CREATE TABLE ActionUser (
  id bigint IDENTITY(1,1) PRIMARY KEY,
  ActionName VARCHAR(50) NOT NULL,
  ActionCode VARCHAR(50) NOT NULL,
  UNIQUE (ActionName, ActionCode)
);

INSERT INTO ActionUser (ActionName, ActionCode)
VALUES
  ('Создание', 'Create'),
  ('Редактирование', 'Edit'),
  ('Удаление', 'Delete');