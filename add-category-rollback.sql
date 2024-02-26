--- Deleting the category_id foreign key from the 
--- product table before deleting the category table
ALTER TABLE Product
    DROP CONSTRAINT FK_ProductCategory;
ALTER TABLE Product DROP COLUMN category_id;
--- Deleting the category table
DROP TABLE Category;

