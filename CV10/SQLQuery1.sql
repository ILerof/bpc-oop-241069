--Tabulky
CREATE TABLE Predmety(subjectID int IDENTITY(0,1) PRIMARY KEY,
zkratka VARCHAR(8),
nazev_predmetu VARCHAR(50))

CREATE TABLE Studenty(studentID int IDENTITY(0,1) PRIMARY KEY,
jmeno VARCHAR(20),
prijmeni VARCHAR(50),
datum_narozeni DATE)

CREATE TABLE Hodnoceni(studentID int FOREIGN KEY REFERENCES Studenty(studentID),
subjectId int FOREIGN KEY REFERENCES Predmety(subjectID),
datum DATE,
znamka int check(znamka >= 0 and znamka <= 5),
PRIMARY KEY (studentID , subjectId))


--insert Studenty
INSERT INTO Studenty VALUES ('Ivan', 'Lohunkov', '2004-01-09')
INSERT INTO Studenty VALUES ('Pavlo', 'Balan', '1998-08-24')
INSERT INTO Studenty VALUES ('Petr', 'Pavel', '1971-06-15')
INSERT INTO Studenty VALUES ('Karel', 'Pavel', '2000-04-25')
INSERT INTO Studenty VALUES ('Krystina', 'Novakova', '2002-11-25')
INSERT INTO Studenty VALUES ('Pavel', 'Pavel', '2005-10-09')
SELECT * FROM Studenty
--insert Predmety
INSERT INTO Predmety VALUES ('BPC-OOP', 'Objektove orientovane programovani')
INSERT INTO Predmety VALUES ('BPC-SOS', 'Sitove operacni systemy')
INSERT INTO Predmety VALUES ('BPC-KKR', 'Kyberkriminalita')
SELECT * FROM Predmety
--insert BPC-SOS
INSERT INTO Hodnoceni VALUES (0,1, '2024-04-10', 4)
INSERT INTO Hodnoceni VALUES (1,1, '2024-04-09', 1)
INSERT INTO Hodnoceni VALUES (3,1, '2024-03-31', 0)
--insert BPC-KKR
INSERT INTO Hodnoceni VALUES (2,2, '2024-01-12', 5)
INSERT INTO Hodnoceni VALUES (3,2, '2024-01-19', 3)
INSERT INTO Hodnoceni VALUES (4,2, '2024-01-26', 2)
INSERT INTO Hodnoceni VALUES (5,2, '2024-02-04', 1)
--insert BPC-OOP
INSERT INTO Hodnoceni VALUES (4,0, '2024-05-26', 4)
INSERT INTO Hodnoceni VALUES (5,0, '2024-05-21', 1)

SELECT * FROM Hodnoceni




--8
SELECT jmeno as [Jmeno], prijmeni as [Prijmeni], datum_narozeni as [Narozeni], zkratka, 
nazev_predmetu as [Nazev Predmetu] FROM Studenty st LEFT JOIN
Hodnoceni ss ON st.studentID = ss.studentID LEFT JOIN Predmety sb ON sb.subjectID = ss.subjectId

--9
SELECT prijmeni as [Prijmeni] , count(prijmeni) as [Pocet setkani prijmeni] FROM Studenty GROUP BY prijmeni ORDER BY [Pocet setkani prijmeni] DESC

--10
SELECT nazev_predmetu as [Nazev Predmetu], count(Hodnoceni.subjectId) as [Pocet zapsanych studentu] FROM Hodnoceni 
LEFT JOIN Predmety st ON Hodnoceni.subjectId = st.subjectID 
GROUP BY nazev_predmetu HAVING COUNT(Hodnoceni.subjectId) < 3

--11
SELECT nazev_predmetu as [Nazev Predmetu], MIN(NULLIF(znamka,0)) as [Nejlepsi Znamka], MAX(znamka) as [Nejhorsi znamka], 
CAST(AVG(CAST(NULLIF(znamka,0) AS DECIMAL(10,2))) AS DECIMAL(10,2)) as [AVG znamka],
count(NULLIF(znamka,0)) as [Pocet hodnocenych studentu], count(znamka) as [Pocet studentu]
FROM Hodnoceni
LEFT JOIN Predmety st ON Hodnoceni.subjectId = st.subjectID
GROUP BY nazev_predmetu




-----------------------
--DELETE FROM Hodnoceni
--DELETE FROM Studenty
--DELETE FROM Predmety
--DROP TABLE Hodnoceni
--DROP TABLE Studenty
--DROP TABLE Predmety