//Stock Control Database
DROP TABLE Products;
DROP TABLE Types;
DROP TABLE Guide;
DROP TABLE Client;


PROMPT CREATING Table Types
PROMPT
/*CREATE TABLE Types
(TypeCode char(2),
 Meaning varchar2(20),
 CONSTRAINT pk_Types PRIMARY KEY (TypeCode));
 
PROMPT CREATING Table Products
PROMPT
CREATE TABLE Products
(ProductID numeric(4),
 Name varchar2(20),
 Description varchar2(20),
 Manufacturer varchar2(25),
 Qty numeric(3),
 Price numeric(5,2),
 TypeCode char(2),
 CONSTRAINT pk_Products PRIMARY KEY (ProductID),
 CONSTRAINT fk_Products_Types FOREIGN KEY (TypeCode) REFERENCES Types);

PROMPT
PROMPT POPULATING Table Types
PROMPT
INSERT INTO Types
VALUES('CH', 'CLOTHING');
INSERT INTO Types
VALUES('HW', 'HARDWARE');
INSERT INTO Types
VALUES('HF', 'HOME FURNISHINGS');

PROMPT
PROMPT POPULATING Table Types
PROMPT

INSERT INTO Products
VALUES(1,'SOFT COUCH THROW','65X85cm Throw','PRIMARK',12,14.99,'HF');
INSERT INTO Products
VALUES(2,'CUSHION','Beige Cushion','BOWENS',44,7.99,'HF');
INSERT INTO Products
VALUES(3,'SOFT COUCH THROW','85X135cm Throw','PRIMARK',6,34.99,'HF');
INSERT INTO Products
VALUES(4,'64pc DENBY','Dinner Set','DENBY',10,140.99,'HW');
INSERT INTO Products
VALUES(5,'MICROFIBRE PILLOW','Standard Pillow','BEDECK',17,35.99,'HF');
INSERT INTO Products
VALUES(6,'CASHMERE SWEATER','SKY BLUE','HILGIGER',5,95.99,'CH');
INSERT INTO Products
VALUES(7,'CROPPED HOODIE','Casual Wear','REEBOCK',30,49.00,'CH');
INSERT INTO Products
VALUES(8,'MATRASS TOPPER','Memory Foam','BEDECK',31,74.99,'HF');

PROMPT
PROMPT POPULATING Table Types
PROMPT

INSERT INTO Client
VALUES('John Doe', 'johndoe@yahoo.com', 0899672533, 'Cork', 'Maine street');
INSERT INTO Client
VALUES('John Doe', 'johndoe@yahoo.com', 0899672533, 'Cork', 'Maine street');
INSERT INTO Client
VALUES('John Doe', 'johndoe@yahoo.com', 0899672533, 'Cork', 'Maine street');
INSERT INTO Client
VALUES('John Doe', 'johndoe@yahoo.com', 0899672533, 'Cork', 'Maine street');
INSERT INTO Client
VALUES('John Doe', 'johndoe@yahoo.com', 0899672533, 'Cork', 'Maine street');


COMMIT;*/