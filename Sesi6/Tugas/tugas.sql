CREATE TABLE customers (
    customerNumber int NOT NULL PRIMARY KEY IDENTITY(1, 1),
    customerName varchar(100) NOT NULL,
    contactLastName varchar(100) NOT NULL,
    contactFirstName varchar(100) NOT NULL,
    phone char(10) NOT NULL,
    addressLine1 text NOT NULL,
    addressLine2 text NOT NULL,
    city varchar(50) NOT NULL,
    [state] varchar(50) NOT NULL,
    postalCode char(10) NOT NULL,
    country varchar(50) NOT NULL,
    creditLimit varchar(50) NOT NULL,
    salesRepEmployeeNumber int NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table employees
--
CREATE TABLE employees (
    employeeNumber int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    lastName varchar(100) NOT NULL,
    firstName varchar(100) NOT NULL,
    extension varchar(50) NOT NULL,
    email varchar(50) NOT NULL,
    officeCode int DEFAULT NULL,
    reportsTo varchar(50) NOT NULL,
    jobTitle varchar(50) NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table offices
--
CREATE TABLE offices (
    officeCode int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    city varchar(50) NOT NULL,
    phone char(10) NOT NULL,
    addressLine1 text NOT NULL,
    addressLine2 text NOT NULL,
    state varchar(50) NOT NULL,
    country varchar(50) NOT NULL,
    postalCode char(10) NOT NULL,
    territoty varchar(50) NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table orderdetails
--
CREATE TABLE orderdetails (
    orderNumber int DEFAULT NULL,
    productCode int NOT NULL,
    quantityOrdered int NOT NULL,
    priceEach varchar(50) NOT NULL,
    orderLineNumber int NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table orders
--
CREATE TABLE orders (
    orderNumber int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    orderDate date NOT NULL,
    requiredDate int NOT NULL,
    shippedData int NOT NULL,
    status varchar(50) NOT NULL,
    comments text NOT NULL,
    customerNumber int NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table payments
--
CREATE TABLE payments (
    customerNumber int NOT NULL,
    checkNumber int NOT NULL,
    paymentDate date NOT NULL,
    amount varchar(50) NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table productlines
--
CREATE TABLE productlines (
    productLine int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    textDescription text NOT NULL,
    htmlDescription text NOT NULL,
    image varbinary(8000) NOT NULL
) -- --------------------------------------------------------
--
-- Table structure for table products
--
CREATE TABLE products (
    productCode int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    productName varchar(100) NOT NULL,
    productLine int NOT NULL,
    productScale int NOT NULL,
    productVendor varchar(100) NOT NULL,
    productDescription text NOT NULL,
    quantityInStock int NOT NULL,
    buyPrice varchar(50) NOT NULL,
    MSRP varchar(50) NOT NULL
) -- FOREIGN KEY EMPLOYEES
ALTER TABLE
    employees
ADD
    FOREIGN KEY (officeCode) REFERENCES offices (officeCode);

-- FOREIGN KEY ORDER DETAILS
ALTER TABLE
    orderdetails
ADD
    FOREIGN KEY (productCode) REFERENCES products (productCode);

-- FOREIGN KEY PAYMENTS
ALTER TABLE
    payments
ADD
    FOREIGN KEY (customerNumber) REFERENCES customers (customerNumber);

-- FOREIGN KEY PRODUCTS
ALTER TABLE
    products
ADD
    FOREIGN KEY (productLine) REFERENCES productlines (productLine);