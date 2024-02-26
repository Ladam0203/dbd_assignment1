-- Add a new category table and a foreign key to the product table

CREATE TABLE Category (
    id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

ALTER TABLE Product(
    ADD COLUMN category_id INT,
    ADD FOREIGN KEY (category_id) REFERENCES Category(id)
);