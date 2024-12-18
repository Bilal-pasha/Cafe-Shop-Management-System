IF OBJECT_ID('users', 'U') IS NOT NULL
    DROP TABLE users;

CREATE TABLE users
(
    id INT PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(255) NULL,
    password VARCHAR(255) NULL,
    profile_image VARCHAR(255) NULL,
    role VARCHAR(50) NULL,
    status VARCHAR(50) NULL,
    date_reg DATE NULL
);

INSERT INTO users (username, password, profile_image, role, status, date_reg)
VALUES ('admin', 'admin123', '', 'Admin', 'Active', '2023-11-01');

SELECT * FROM users;

IF OBJECT_ID('products', 'U') IS NOT NULL
    DROP TABLE products;

CREATE TABLE products
(
    id INT PRIMARY KEY IDENTITY(1,1),
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    prod_type VARCHAR(MAX) NULL,
    prod_stock INT NULL,
    prod_price FLOAT NULL,
    prod_status VARCHAR(MAX) NULL,
    prod_image VARCHAR(MAX) NULL,
    date_insert DATE NULL,
    date_update DATE NULL,
    date_delete DATE NULL
);

SELECT * FROM products;
SELECT * FROM products WHERE date_delete IS NULL;

DELETE FROM products WHERE id = 2;

IF OBJECT_ID('customers', 'U') IS NOT NULL
    DROP TABLE customers;

CREATE TABLE customers
(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    total_price FLOAT NULL,
    date DATE NULL
);

ALTER TABLE customers
ADD change FLOAT NULL;

ALTER TABLE customers
ADD users VARCHAR(MAX) NULL;

-- Add amount column
ALTER TABLE customers
ADD amount FLOAT NULL;

IF OBJECT_ID('orders', 'U') IS NOT NULL
    DROP TABLE orders;

CREATE TABLE orders
(
    id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT NULL,
    prod_id VARCHAR(MAX) NULL,
    prod_name VARCHAR(MAX) NULL,
    prod_type VARCHAR(MAX) NULL,
    prod_price FLOAT NULL,
    order_date DATE NULL,
    delete_order DATE NULL
);

ALTER TABLE orders 
ADD qty INT NULL;

SELECT * FROM products;
SELECT MAX(customer_id) FROM orders;
SELECT SUM(prod_price) FROM orders WHERE customer_id = 1;
SELECT * FROM customers;
SELECT * FROM users;
SELECT SUM(total_price) FROM customers;
SELECT SUM(total_price) FROM customers WHERE date = '2023-12-07';
