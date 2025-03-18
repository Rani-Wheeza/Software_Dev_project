DROP TABLE Client;
DROP TABLE Sitter;
--DROP TABLE Booking;

set define off
--CLIENT TABLE
--PROMPT
CREATE TABLE CLIENT
(ClientID numeric(4),
FirstName varchar2(20),
LastName varchar2(20),
PhoneNo VARCHAR(15), 
Email VARCHAR(100) UNIQUE, 
Street VARCHAR(100), 
Town VARCHAR(50), 
Eircode VARCHAR(10), 
NoOfChildren INT CHECK (NoOfChildren >= 0),
CONSTRAINT pk_Client PRIMARY KEY (ClientID));


--SITTERS TABLE
--PROMPT
CREATE TABLE SITTER(
  SitterID numeric(4),
  FirstName varchar2(20),
  LastName varchar2(20),
  PhoneNo VARCHAR(15), 
  DOB DATE,
  Email VARCHAR(100) UNIQUE, 
  Street VARCHAR(100), 
  Town VARCHAR(50), 
  Eircode VARCHAR(10),
  Bio VARCHAR(100), 
  Skills VARCHAR(100), 
  ExperienceYears VARCHAR(1), 
  HourlyRate DECIMAL(5, 2), 
  Certified char(1),
  CONSTRAINT pk_Sitter PRIMARY KEY (SitterID));

--BOOKING TABLE
--PROMPT
/*CREATE TABLE BOOKING
(BookingID numeric(4),
BookingDate DATE NOT NULL, 
ClientID NUMERIC, 
SitterID NUMERIC,
BookingTime TIME NOT NULL, 
Status VARCHAR(20), 
PaymentAmount DECIMAL(10, 2), 
CommissionFee DECIMAL(10, 2), 
CONSTRAINT pk_Booking PRIMARY KEY (BookingID),
CONSTRAINT fk_Booking_Client FOREIGN KEY (ClientID) REFERENCES Client,
CONSTRAINT fk_Booking_Sitter FOREIGN KEY (SitterID) REFERENCES Sitter);*/

--Input data in Client
--Prompt

INSERT INTO Client
VALUES(1001,'John','Doe','0899672533','johndoe@yahoo.com','Maine street','Cork', 'V12 JK74',3);
INSERT INTO Client
VALUES(1002,'Jane','Williams','0830372513','janewillams@yahoo.com','Michael Street','Killerney', 'V24 MW83',1);
INSERT INTO Client
VALUES(1003,'Hannah','Baker','0875303693','hannahbaker@gmail.com','Abbey Street','Dublin', 'V67 KX03',4);


--Input data in Sitter
--Prompt

INSERT INTO Sitter
VALUES(3001,'Aoife','Smith','0837462513','11-DEC-98','aoifesmith@gmail.com','Main street','Mallow', 'V97 AC52','Reliable babysitter with experience in fun, safe, and educational care. CPR & First Aid certified','CPR & First Aid certified',3,15.30,'Y');
INSERT INTO Sitter
VALUES(3002,'Aidan ','Murphy','0830303772','27-MAY-90','aidenmurphy@gmail.com','James street','Galway', 'V12 RT74','Trusted babysitter with experience in fun, safe care. CPR & First Aid certified, reliable','First Aid certified',9,18.50,'Y');
INSERT INTO Sitter
VALUES(3003,'Niall','Connor','0880392604','05-JAN-02','niallconner@gmail.com','Peter street','Tralee', 'V82 QE74','Friendly babysitter with experience in fun, safe care. CPR & First Aid certified, dependable.','CPR certified',1,14.80,'Y');

--Input data in Booking
--Prompt
/*
INSERT INTO Booking
VALUES();
*/

