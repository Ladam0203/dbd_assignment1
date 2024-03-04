-- Add a new category table and a foreign key to the product table

CREATE TABLE Category (
    id INT PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

ALTER TABLE Product
ADD category_id INT;

ALTER TABLE Product
ADD CONSTRAINT FK_ProductCategory
FOREIGN KEY (category_id) REFERENCES Category(id);