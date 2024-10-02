CREATE TABLE users
(
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(MAX) NULL,
    password VARCHAR(MAX) NULL,
    date_register DATE NULL
);

SELECT * FROM users

CREATE TABLE students
(
  id INT PRIMARY KEY IDENTITY(1,1),
  student_id VARCHAR(MAX) NULL,
  full_name VARCHAR(MAX) NULL,
  gender VARCHAR(MAX) NULL,
  contact_number VARCHAR(MAX) NULL,
  uid INT NULL,
  insert_date DATE NULL,
  update_date DATE NULL,
  delete_date DATE NULL
)

SELECT * FROM students

ALTER TABLE students
ADD status VARCHAR(MAX) NULL