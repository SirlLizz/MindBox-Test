CREATE TABLE IF NOT EXISTS 'products' (
'id_product' INT NOT NULL,
'product_name' VARCHAR(45) NULL,
  PRIMARY KEY ('id_product'));

CREATE TABLE IF NOT EXISTS 'categories' (
  'id_category' INT NOT NULL,
'category_name' VARCHAR(45) NULL,
  PRIMARY KEY ('id_category'));

CREATE TABLE IF NOT EXISTS 'product_to_category'(
  'product_id' INT NOT NULL,
  'category_id' INT NOT NULL,
  PRIMARY KEY ('product_id',  'category_id'));

SELECT product_name, category_name FROM products p
left join
(SELECT * from categories c 
 LEFT JOIN product_to_category pc 
 on c.id_category = pc.category_id) a
 on p.id_product = a.product_id;