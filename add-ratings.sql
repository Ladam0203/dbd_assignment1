-- Add the ratings table to the database that will store the ratings for each product.
CREATE TABLE ProductRating (
    id INT PRIMARY KEY,
    rating INT NOT NULL,
    product_id INT NOT NULL,
    FOREIGN KEY (product_id) REFERENCES Product(id)
);
