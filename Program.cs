using System;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {

            // Exercises
            Exercise firstOne = new Exercise () {
                ExerciseName = "The first one",
                ExerciseLanguage = "React",
            };
            Exercise secondOne = new Exercise () {
                ExerciseName = "The second one",
                ExerciseLanguage = "Javascript",
            };
            Exercise thirdOne = new Exercise () {
                ExerciseName = "The third one",
                ExerciseLanguage = "C#",
            };
            Exercise forthOne = new Exercise () {
                ExerciseName = "The forth one",
                ExerciseLanguage = "SQL",
            };

            // Cohorts
            Cohort cohort26 = new Cohort () {
                CohortName = "Cohort 26"
            };
            Cohort cohort27 = new Cohort () {
                CohortName = "Cohort 27"
            };
            Cohort cohort28 = new Cohort () {
                CohortName = "Cohort 28"
            };

            // Students
            Student johnSmith = new Student () {
                FirstName = "John",
                LastName = "Smith",
                SlackHandle = "johnnyboi",
                Cohort = cohort27,
            };
            Student johnDoe = new Student () {
                FirstName = "John",
                LastName = "Doe",
                SlackHandle = "doughboi",
                Cohort = cohort26,
            };
            Student bobSmith = new Student () {
                FirstName = "Bob",
                LastName = "Smith",
                SlackHandle = "bobbyman",
                Cohort = cohort28,
            };
            Student bobDoe = new Student () {
                FirstName = "Bob",
                LastName = "Doe",
                SlackHandle = "doughbobby",
                Cohort = cohort27,
            };

            // Instructors
            Instructor fooBar = new Instructor () {
                FirstName = "Foo",
                LastName = "Bar",
                SlackHandle = "foobarboi",
                Cohort = cohort27,
            };
            Instructor melvinSmith = new Instructor () {
                FirstName = "Melvin",
                LastName = "Smith",
                SlackHandle = "smellymelvin",
                Cohort = cohort26,
            };
            Instructor chipAhoy = new Instructor () {
                FirstName = "Chip",
                LastName = "Ahoy",
                SlackHandle = "chipsahoy",
                Cohort = cohort28,
            };
        }
    }
}