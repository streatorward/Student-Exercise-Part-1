CREATE TABLE Cohort (
	Id INTEGER NOT NULL PRIMARY KEY Autoincrement,
	CohortName Text NOT NULL
);

CREATE TABLE Instructor (
	Id INTEGER NOT NULL PRIMARY KEY Autoincrement,
	FirstName TEXT NOT NULL,
	LastName TEXT NOT NULL,
	CohortId INTEGER NOT NULL,
		FOREIGN KEY(CohortId) REFERENCES Cohort(Id)
);

CREATE TABLE Student (
	Id INTEGER NOT NULL PRIMARY KEY Autoincrement,
	FirstName Text NOT NULL,
	LastName Text NOT NULL,
	CohortId INTEGER NOT NULL,
		FOREIGN KEY(CohortId)  REFERENCES Cohort(Id)
);

CREATE TABLE Exercise (
	Id INTEGER NOT NULL PRIMARY KEY Autoincrement,
	ExerciseName Text NOT NULL,
	ExerciseLanguage Text NOT NULL
	);
	
CREATE TABLE StudentExercise(
	Id INTEGER NOT NULL PRIMARY KEY Autoincrement,
	StudentId INTEGER NOT NULL,
	ExerciseId INTEGER NOT NULL,
		FOREIGN KEY(StudentId)  REFERENCES Student(Id),
		FOREIGN KEY(ExerciseId)  REFERENCES Exercise(Id)
);

INSERT INTO Cohort (CohortName) VALUES ("TwentyFive");
INSERT INTO Cohort (CohortName) VALUES ("TwentySix");
INSERT INTO Cohort (CohortName) VALUES ("TwentySeven");


INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ("Objects", "Javascript");
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ("Loops", "Javascript");
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ("Lists", "C#");
INSERT INTO Exercise(ExerciseName, ExerciseLanguage) VALUES ("Dictionaries", "C#");


INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Streator", "Ward", 3);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Kristyn", "Whaley", 3);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Miller", "Whaley", 3);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Bogey", "Ward", 1);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Aaron", "Keen", 2);
INSERT INTO Student(FirstName, LastName, CohortId) VALUES ("Mike", "Perrish", 2);


INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ("Steve", "Brownlee", 1);
INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ("Meg", "Ducharme", 2);
INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ("Jenna", "Solis", 2);
INSERT INTO Instructor(FirstName, LastName, CohortId) VALUES ("Joe", "Shepard", 3);


INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (1, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (1, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (2, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (2, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (2, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (2, 1);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (3, 2);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (3, 2);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (3, 2);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 3);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (5, 3);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (6, 4);
INSERT INTO StudentExercise(StudentId, ExerciseId) VALUES (6, 4);


SELECT * FROM Cohort co
JOIN Student stu ON stu.CohortId = co.Id
JOIN Instructor inst ON inst.CohortId = co.Id;


SELECT * FROM StudentExercise se
JOIN Student stu ON stu.Id = se.StudentId
JOIN Exercise ex ON ex.Id = se.ExerciseId
;