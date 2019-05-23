-- CinemaSYS.sql
-- Kieran Stack      22/01/2019

-- DROP ALL TABLES
DROP TABLE Sale;
DROP TABLE Rate;
DROP TABLE Screening_Times;
DROP TABLE Screening;
DROP TABLE Screen;
DROP Table Movie;
DROP TABLE ScreenTypes;
DROP TABLE ScreenStatus;
DROP TABLE AgeRating;

-- CREATE TABLE SCREENSTATUS
CREATE TABLE ScreenStatus
(Screen_Status_ID NUMERIC(2) NOT NULL,
 Screen_Status CHAR(1) NOT NULL, 
 Description CHAR(9) NOT NULL,
CONSTRAINT pk_ScreenStatus PRIMARY KEY (Screen_Status_ID));

-- POPULATE TABLE SCREENSTATUS
INSERT INTO ScreenStatus
VALUES(1,'A','Available');
INSERT INTO ScreenStatus
VALUES(2,'R','Removed');

-- CREATE TABLE SCREENTYPES
CREATE TABLE ScreenTypes
(Screen_Type_ID NUMERIC(1) NOT NULL,
 Screen_Type VARCHAR2(10) NOT NULL,
CONSTRAINT pk_ScreenTypes PRIMARY KEY (Screen_Type_ID));

-- POPULATE TABLE SCREENTYPES
INSERT INTO ScreenTypes
VALUES(1,'Standard');
INSERT INTO ScreenTypes
VALUES(2,'IMAX');
INSERT INTO ScreenTypes
VALUES(3,'3D');

-- CREATE TABLE SCREEN
CREATE TABLE Screen
(Screen_No Numeric(2) NOT NULL,
 Number_Of_Seats Numeric(3) NOT NULL,
 Screen_Type_ID Numeric(2)  NOT NULL,
 Screen_Status_ID Numeric(1) NOT NULL,
CONSTRAINT fk_ScreenTypes FOREIGN KEY (Screen_Type_ID) REFERENCES ScreenTypes(Screen_Type_ID),
CONSTRAINT pk_Screen PRIMARY KEY (Screen_No));

-- POPULATING TABLE SCREEN

INSERT INTO Screen
VALUES(01,200,1,1);
INSERT INTO Screen
VALUES(02,150,2,1);
INSERT INTO Screen
VALUES(03,120,3,1);
INSERT INTO Screen
VALUES(04,130,3,2);

-- CREATE TABLE AGERATING
CREATE TABLE AgeRating
(Age_Rating_ID NUMERIC(1) NOT NULL,
 Age_Rating CHAR(3) NOT NULL,
CONSTRAINT pk_AgeRating PRIMARY KEY (Age_Rating_ID));

-- POPULATING TABLE AGERATING

INSERT INTO AgeRating
VALUES(1,'U');
INSERT INTO AgeRating
VALUES(2,'PG');
INSERT INTO AgeRating
VALUES(3,'12A');
INSERT INTO AgeRating
VALUES(4,'15');
INSERT INTO AgeRating
VALUES(5,'18');

-- CREATE TABLE MOVIE
CREATE TABLE Movie
(Movie_ID Numeric(4) NOT NULL,
 Name Varchar2(50) NOT NULL,
 Running_Time Numeric(3) NOT NULL,
 Description Varchar2(300) NOT NULL,
 Age_Rating_ID NUMERIC(2) NOT NULL,
CONSTRAINT fk_AgeRating FOREIGN KEY (Age_Rating_ID) REFERENCES AgeRating(Age_Rating_ID),
CONSTRAINT pk_Movie_ID PRIMARY KEY (Movie_ID));

-- POPULATING TABLE Movie

INSERT INTO Movie
VALUES(1,'JAWS',130,'In the film, a giant man-eating great white shark attacks beachgoers on Amity Island, a fictional New England summer resort town, prompting police chief Martin Brody (Roy Scheider) to hunt it with the help of a marine biologist (Richard Dreyfuss) and a professional shark hunter (Robert Shaw).',5);
INSERT INTO Movie
VALUES(2,'THE GRINCH',92,'A grumpy Grinch plots to ruin Christmas for the village of Whoville.',1);
INSERT INTO Movie
VALUES(3,'SPIDER-MAN: INTO THE SPIDER-VERSE',116,'Teen Miles Morales becomes Spider-Man of his reality, crossing his path with five counterparts from another dimensions to stop a threat for all realities.',2);

-- CREATE TABLE SCREENING TIMES
CREATE TABLE SCREENING_TIMES
(Screening_Time_Id Numeric(1) NOT NULL,
 Screening_Time VARCHAR2(8),
CONSTRAINT pk_Screening_Time_Id PRIMARY KEY (Screening_Time_Id));
 
-- POPULATING TABLE Screening
INSERT INTO SCREENING_TIMES
VALUES(1, '12:00');
INSERT INTO SCREENING_TIMES
VALUES(2, '14:00');
INSERT INTO SCREENING_TIMES
VALUES(3, '18:00');
INSERT INTO SCREENING_TIMES
VALUES(4, '21:00');
INSERT INTO SCREENING_TIMES
VALUES(5, '23:00');

-- CREATE TABLE SCREENING
CREATE TABLE SCREENING
(Screening_Number Numeric(2) NOT NULL,
 --Date_From DATE NOT NULL,
 --Date_To DATE NOT NULL,
 --Time_Of_Screening DATE NOT NULL,
 Date_From VARCHAR2(24 BYTE) NOT NULL,
 Date_To VARCHAR2(24 BYTE) NOT NULL,
 Screening_Time_Id Numeric(1) NOT NULL,
 Max_Seats Numeric(3) NOT NULL,
 Seats_Available Numeric(3) NOT NULL,
 Screen_No Numeric(2) NOT NULL,
 Movie_Id Numeric(4) NOT NULL,
CONSTRAINT fk_Screen_No FOREIGN KEY (Screen_No) REFERENCES Screen(Screen_No),
CONSTRAINT fk_Movie_Id FOREIGN KEY (Movie_Id) REFERENCES Movie(Movie_Id),
CONSTRAINT pk_Screening_Number PRIMARY KEY (Screening_Number));

-- POPULATING TABLE Screening
--ALTER SESSION SET NLS_DATE_FORMAT = 'dd-MM-yy HH:MI:SS';

INSERT INTO Screening
VALUES(1,'22/05/2019','28/05/2019', 1, 200, 200, 1, 1);
INSERT INTO Screening
VALUES(2,'22/05/2019','28/05/2019', 2, 150, 150, 2, 2);
INSERT INTO Screening
VALUES(3,'22/05/2019','28/05/2019', 3, 120, 120, 3, 3);
INSERT INTO Screening
VALUES(4,'22/05/2019','28/05/2019', 4, 120, 120, 3, 3);

CREATE TABLE Rate
(Rate_ID NUMERIC(1) NOT NULL,
 Rate_Name Varchar2(20) NOT NULL,
 Rate_Price Varchar2(20) NOT NULL,
 Description Varchar2(200) NOT NULL,
CONSTRAINT pk_Rate_ID PRIMARY KEY (Rate_ID));

INSERT INTO Rate
VALUES(1,'Standard Rate','10.00','For customers which no other rates apply');
INSERT INTO Rate
VALUES(2,'Childrens Rate','5.00','For children i.e anyone under 14 years of age');
INSERT INTO Rate
VALUES(3,'Student Rate','8.00','For anyone who can provide a student card');
INSERT INTO Rate
VALUES(4,'Senior Rate','6.00','For anyone over the age of 60');

CREATE TABLE Sale
(Sale_ID NUMERIC(5) NOT NULL,
 Rate_ID NUMERIC(1) NOT NULL,
 Screening_Number Numeric(2) NOT NULL,
CONSTRAINT fk_Rate_ID FOREIGN KEY (Rate_ID) REFERENCES Rate(Rate_ID),
CONSTRAINT fk_Screening_Number FOREIGN KEY (Screening_Number) REFERENCES Screening(Screening_Number),
CONSTRAINT pk_Sale_Id PRIMARY KEY (Sale_Id));



COMMIT;

--SELECT  *  FROM    V$NLS_PARAMETERS;
--SELECT  Time_Of_Screening FROM SCREENING;

--SELECT Screening_Number, 'String.Format({0:dd-MM-yy},Date_From)', 'String.Format({0:dd-MM-yy},Date_To)', 'String.Format({0:HH-mm},Time_OF_Screening)', Max_Seats, Seats_Available, Movie_Id, Screen_No FROM Screening WHERE Screening_Number = 4;

--SELECT * 
--FROM Screen 
--FULL OUTER JOIN SCREENTYPES 
--ON Screen.SCREEN_TYPE_ID = SCREENTYPES.SCREEN_TYPE_ID;

--SELECT * 
--FROM Screening 
--FULL OUTER JOIN Movie
--ON Screening.movie_Id = Movie.MOVIE_ID;

--SELECT Screening.SCREENING_NUMBER, MOVIE.NAME
--FROM Screening 
--INNER JOIN MOVIE
--ON Screening.movie_Id = Movie.MOVIE_ID
--ORDER BY Screening.SCREENING_NUMBER;


--SELECT Screening.Date_From, Screening.DATE_TO 
--FROM Screening
--FULL OUTER JOIN Movie
--ON Screening.movie_Id = Movie.MOVIE_ID
--WHERE Name = 'THE GRINCH'; 

--SELECT * 
--FROM Screening
--FULL OUTER JOIN Movie
--ON Screening.movie_Id = Movie.MOVIE_ID;

--SELECT * 
--FROM Screening INNER JOIN Screening_TIMES 
--ON Screening.SCREENING_TIME_ID = Screening_TIMES.SCREENING_TIME_ID 
--ORDER BY Screening.SCREENING_NUMBER;

--SELECT MIN(Date_From) 
--FROM Screening 
--Where movie_Id = 2;

-- current query problem
--SELECT * FROM Screening WHERE screening_Time_Id = 1AND screen_No = 01 AND ('22/05/2019' < date_From AND date_From < date_To) 
--OR ('23/05/2019' < date_From AND date_From <= date_To) 
--OR (date_From < '22/05/2019' AND '23/05/2019' > date_To)

--"SELECT * FROM Screening WHERE screening_Time_Id = " + screening_Time_Id + "AND screen_No = " + screening_Number
            --                + " AND " +
           --                 "('" + dateFrom + "' < date_From AND date_From < date_To)"
           --                 + " OR " +
           --                 "('" + dateTo + "' < date_From AND date_From <= date_To)"
           --                 + " OR " +
           --                 "(date_From < '" + dateFrom + "' AND '" + dateTo + "' > date_To)";
           
           
--SELECT COUNT(*)FROM Screening WHERE screening_Time_Id = 1AND screen_No = 01 AND ('22/05/2019' < date_From AND date_From < date_To)
--OR ('29/05/2019' < date_From AND date_From <= date_To) OR (date_From < '22/05/2019' AND '29/05/2019' > date_To);

--SELECT *
--FROM Screening screen INNER JOIN SCREENING_TIMES times 
--ON screen.SCREENING_TIME_ID = times.SCREENING_TIME_ID 
--WHERE '23/05/2019' BETWEEN to_date('23/05/2019','DD/MM/YYYY') AND to_date('24/05/2019','DD/MM/YYYY') AND screen_no = 01;
--count(*)
