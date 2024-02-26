-- Setting Product table name and price to NOT NULL

ALTER TABLE Product(
    MODIFY COLUMN name VARCHAR(100) NOT NULL,
    MODIFY COLUMN price DECIMAL(10, 2) NOT NULL
);