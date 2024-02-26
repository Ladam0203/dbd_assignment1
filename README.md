Assignment : EShop  Database schema migration

Manual Migration:

Setting up: 
1. Create a Eshop database 
2. Run initial-schema.sql

Migrations (See details of changes made in the scripts):
3. Run add-category.sql
4. Run product-attribute-changes-not-null.sql
5. Run add-ratings.sql

Testing:
Run the scripts in the order discussed under migrations and validate manually that they have taken effect.

Rollback: 
If you want to rollback to a previous version of the schema, be sure to start from the sql file corresponding to the last migration script you used  and continue in reverse order. 