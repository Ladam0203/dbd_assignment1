# Introduction
This assignment was created to practice and display skills in regards of database schema migration. 
The repository contains operations for a hypothetical e-commerce store's database. Particularly: creation and migrations.

## Manual Migrations

### Setup
1. Create a Eshop database 
2. Run initial-schema.sql

### Migrate

3. Run add-category.sql
4. Run product-attribute-changes-not-null.sql
5. Run add-ratings.sql

#### For a detailed documentation of the changes made by each migration, examine the comments inside the SQL files.

### Test
Run the scripts in the specified order and manually examine whether the desired changes have taken effect.

### Rollback 
Execute scripts postfixed with '-rollback' in a LIFO manner. Start with the rollback of the last migration script you executed, then continue in reverse order until you reach the desired state. 