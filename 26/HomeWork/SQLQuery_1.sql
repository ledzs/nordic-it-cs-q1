USE reminder;
GO

CREATE TABLE  DepartureBoard(

    FlightNumber                CHAR(20),
    DepartureCity               VARCHAR(50),
    DepartureCountry            VARCHAR(50),
    ArrivalCity                 VARCHAR(50),
    ArrivalCountry              VARCHAR(50),
    DepartureDateTime           DATETIME2,
    ArrivalDateTime             DATETIME2,
    TimeInFlight                TINYINT,
    Airline                     CHAR(20),
    AirplaneModel               CHAR(20),
    
);

INSERT INTO DepartureBoard 
VALUES  ('Y7-1061', 'Moscow', 'Russia', 'St.Petersburg', 'Russia', '2019-12-17T19:30:00','2019-12-17T21:20:00', 110, 'NordStar', 'Boeing 737-800'),
        ('SU-2356', 'Moscow', 'Russia', 'Vienna', 'Austria', '2019-12-18T14:10:00','2019-12-18T17:05:00', 175, 'Aeroflot', 'Airbus A220-300');

SELECT * FROM DepartureBoard;