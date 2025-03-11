/*DROP TABLE Client;

DROP TABLE Booking;

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
*/
--DROP TABLE Sitter;
--SITTERS TABLE
--PROMPT
CREATE TABLE SITTER
(SitterID numeric(4),
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
ExperienceYears VARCHAR CHECK (ExperienceYears >= 0), 
HourlyRate DECIMAL(5, 2) CHECK (HourlyRate > 0), 
Certified char(1),
CONSTRAINT pk_Sitter PRIMARY KEY (SitterID));
/*
--BOOKING TABLE
--PROMPT
CREATE TABLE BOOKING
(BookingID numeric(4),
BookingDate DATE NOT NULL, 
ClientID INT, 
SitterID INT,
BookingTime TIME NOT NULL, 
Status VARCHAR(20) CHECK (Status IN ('Confirmed', 'Cancelled')), 
PaymentAmount DECIMAL(10, 2) CHECK (PaymentAmount >= 0), 
CommissionFee DECIMAL(10, 2) CHECK (CommissionFee >= 0), 
CONSTRAINT pk_Booking PRIMARY KEY (BookingID),
CONSTRAINT fk_Booking_Client FOREIGN KEY (ClientID) REFERENCES Client,
CONSTRAINT fk_Booking_Sitter FOREIGN KEY (SitterID) REFERENCES Sitter);*/

--Input data in Client
--Prompt
/*
INSERT INTO Client
*/

--Input data in Sitter
--Prompt
/*
INSERT INTO Sitter
*/

--Input data in Booking
--Prompt
/*
INSERT INTO Booking
*/

