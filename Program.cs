using System;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            Exercise firstOne = new Exercise () {
                exerciseName = "The first one",
                exerciseLanguage = "React",
            };
            Exercise secondOne = new Exercise () {
                exerciseName = "The second one",
                exerciseLanguage = "Javascript",
            };
            Exercise thirdOne = new Exercise () {
                exerciseName = "The third one",
                exerciseLanguage = "C#",
            };
            Exercise forthOne = new Exercise () {
                exerciseName = "The forth one",
                exerciseLanguage = "SQL",
            };

            Cohort cohort26 = new Cohort () {
                cohortName = "Cohort 26"
            };
            Cohort cohort27 = new Cohort () {
                cohortName = "Cohort 27"
            };
            Cohort cohort28 = new Cohort () {
                cohortName = "Cohort 28"
            };

            Student johnSmith = new Student () {
                firstName = "John",
                lastName = "Smith",
                slackHandle = "johnnyboi",
                studentCohort = "Cohort 27",
            };
            Student johnDoe = new Student () {
                firstName = "John",
                lastName = "Doe",
                slackHandle = "doughboi",
                studentCohort = "Cohort 26",
            };
            Student bobSmith = new Student () {
                firstName = "Bob",
                lastName = "Smith",
                slackHandle = "bobbyman",
                studentCohort = "Cohort 28",
            };
            Student bobDoe = new Student () {
                firstName = "Bob",
                lastName = "Doe",
                slackHandle = "doughbobby",
                studentCohort = "Cohort 27",
            };

            Instructor fooBar = new Instructor () {
                firstName = "Foo",
                lastName = "Bar",
                slackHandle = "foobarboi",
                instructorCohort = "Cohort 27",
            };
            Instructor melvinSmith = new Instructor () {
                firstName = "Melvin",
                lastName = "Smith",
                slackHandle = "smellymelvin",
                instructorCohort = "Cohort 26",
            };
            Instructor chipAhoy = new Instructor () {
                firstName = "Chip",
                lastName = "Ahoy",
                slackHandle = "chipsahoy",
                instructorCohort = "Cohort 28",
            };
        }
    }
}