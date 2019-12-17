GO
CREATE TABLE   Employee(
    ID              INT NOT NULL,
    Fullname        NVARCHAR(250) NOT NULL,
    AdressId        INT NOT NULL,
    PositionId      INT NOT NULL
);

CREATE TABLE   Document(
    ID               INT NOT NULL,
    DocumentTypeId   INT NOT NULL,
    Title            NVARCHAR(250) NOT NULL,
    Pages            INT NOT NULL
);

CREATE TABLE   DocumentType(
    ID                      INT NOT NULL,
    Title                   NVARCHAR(250) NOT NULL,
);

CREATE TABLE   Adress(
    ID                      INT NOT NULL,
    CityName                NVARCHAR(250) NOT NULL,
);

CREATE TABLE   Position(
    ID                      INT NOT NULL,
    Title                   NVARCHAR(250) NOT NULL,
);

CREATE TABLE   DocumentStatus(
    ID                  INT NOT NULL,
    SenderId            INT NOT NULL,
    ReceiverId          NVARCHAR(250) NOT NULL,
    DocumentId          INT NOT NULL,
    [Status]            NVARCHAR(250) NOT NULL,
    [DateTime]          DATETIME2 NOT NULL
);

GO
SELECT * FROM INFORMATION_SCHEMA.TABLES;
SELECT * FROM INFORMATION_SCHEMA.COLUMNS;


alter table Adress
add CONSTRAINT pk_adress PRIMARY KEY CLUSTERED(Id);

alter table Document
add CONSTRAINT pk_document PRIMARY KEY CLUSTERED(Id);

alter table DocumentStatus
add CONSTRAINT pk_document_status PRIMARY KEY CLUSTERED(Id);

alter table DocumentType
add CONSTRAINT pk_document_type PRIMARY KEY CLUSTERED(Id);

alter table Employee
add CONSTRAINT pk_employee PRIMARY KEY CLUSTERED(Id);

alter table Position
add CONSTRAINT pk_position PRIMARY KEY CLUSTERED(Id);



INSERT INTO [Position] 
VALUES  (1, 'Manager');
SELECT * from [Position];

SELECT * from INFORMATION_SCHEMA.TABLE_CONSTRAINTS;


ALTER TABLE Employee
ADD CONSTRAINT FK_AdressId_Adress_ID FOREIGN KEY (AdressId)
REFERENCES Adress (Id)
ON UPDATE CASCADE
ON DELETE NO ACTION



DROP TABLE [e_kotegov_schema].[Adress]

DROP TABLE [e_kotegov_schema].[Document]

DROP TABLE [e_kotegov_schema].[DocumentStatus]

DROP TABLE [e_kotegov_schema].[DocumentType]

DROP TABLE [e_kotegov_schema].[Employee]

DROP TABLE [e_kotegov_schema].[Position]
