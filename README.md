# Introduction
This assignment was created to practice and display skills in regards of database schema migration.
The repository contains operations for a hypothetical e-commerce store's database. Particularly: creation and migrations.

## Manual Migrations

The main branch of the manual migrations is **main-manual**. All the branches concerning manual migrations are prefixed with **manual/**. Use these branches to discover and and execute our work with manual migrations.

### Setup
1. Create an SQL database with your chosen database management software (recommended: [SQL Server Management Studio](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16))
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

## Entity Framework Migrations

The main branch of the manual migrations is **main-ef**. All the branches concerning manual migrations are prefixed with **ef/**. Use these branches to discover and and execute our work with EF migrations.

### Dependencies
- [Install EF Core tools](https://learn.microsoft.com/en-us/ef/core/cli/dotnet) (globally)

### Setup
1. Run the InitialCreate at EFMigrations/Migrations
```
dotnet ef database update InitialCreate
```
### Migrations
2. Run AddCategoryToProduct
