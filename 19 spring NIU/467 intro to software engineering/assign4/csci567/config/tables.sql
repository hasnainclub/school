-- Don't execute this unless its on your database?
-- We have the table created on the master sql server.

USE cs56714;

CREATE TABLE Address 
(
    addressId    int NOT NULL AUTO_INCREMENT,
    addressType  varchar(255),
    street       varchar(255),
    city         varchar(255),
    state        varchar(255),
    zip          int,
    
    PRIMARY KEY (addressId)
);

CREATE TABLE CustomerRep 
(
    custRepId    int NOT NULL AUTO_INCREMENT,
    firstName    varchar(255),
    lastName     varchar(255),
    email        varchar(255),
    phone        varchar(255),
    
    PRIMARY KEY (custRepId)
);

CREATE TABLE Company 
(
    companyId int NOT NULL AUTO_INCREMENT,
    compName  varchar (255),
    shipId    int,
    mailId    int,
    custRepId int,
    
    PRIMARY KEY (companyId),

    FOREIGN KEY (shipId)    REFERENCES Address     (addressId),
    FOREIGN KEY (mailId)    REFERENCES Address     (addressId),
    FOREIGN KEY (custRepId) REFERENCES CustomerRep (custRepId)
);

CREATE TABLE InventoryPart
(
    inventoryId int NOT NULL AUTO_INCREMENT,
    partName    varchar(255),
    barCode     int,
    description varchar(255),
    quantity    int,
    price       float (4,2),
    
    PRIMARY KEY (inventoryId)
);

CREATE TABLE RequestForQuote
(
    rfqId        int NOT NULL AUTO_INCREMENT,
    companyId    int,
    
    expireDate   int,
    deliveryDate int,
    
    PRIMARY KEY (rfqId),
    FOREIGN KEY (companyId) REFERENCES Company (companyId)
);

CREATE TABLE Quote
(
    quoteId     int NOT NULL AUTO_INCREMENT,
    rfqId       int,
    inventoryId int,
    quantity    int,
    
    PRIMARY KEY (quoteId),
    
    FOREIGN KEY (rfqId)       REFERENCES RequestForQuote (rfqId),
    FOREIGN KEY (inventoryId) REFERENCES InventoryPart   (inventoryId)
);

SHOW TABLES;