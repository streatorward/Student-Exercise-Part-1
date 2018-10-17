using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises {
    class Program {
        static void Main (string[] args) {
            // Create 4, or more, exercises.
            Exercise objects = new Exercise ("objects", "Javascript");
            Exercise loops = new Exercise ("loops", "Javascript");
            Exercise lists = new Exercise ("lists", "C#");
            Exercise dictionaries = new Exercise ("dictionaries", "C#");

            // Create 3, or more, cohorts.
            Cohort twentyFive = new Cohort ("Day 25");
            Cohort twentySix = new Cohort ("Day 26");
            Cohort twentySeven = new Cohort ("Day 27");

            // Create 4, or more, students and assign them to one of the cohorts.
            Student Streator = new Student ("Streator", "Ward", "skw1", twentySeven);
            Student Kristyn = new Student ("Kristyn", "Whaley", "kmw1", twentySeven);
            Student Miller = new Student ("Miller", "Whaley", "pupboi1", twentySeven);
            Student Bogey = new Student ("Bogey", "Ward", "pupper1", twentyFive);
            Student Aaron = new Student ("Aaron", "Keen", "ak1", twentySix);
            Student Mike = new Student ("Mike", "Perrish", "mp1", twentySix);

            // Create 3, or more, instructors and assign them to one of the cohorts.
            Instructor Steve = new Instructor ("Steve", "Brownlee", "coach", twentyFive);
            Instructor Meg = new Instructor ("Meg", "Ducharme", "meg1", twentySix);
            Instructor Jenna = new Instructor ("Jenna", "Solis", "jenna1", twentySix);
            Instructor Joe = new Instructor ("Joe", "Shepard", "joe1", twentySeven);

            // Have each instructor assign 2 exercises to each of the students.
            Steve.AssignExercise (loops, Streator);
            Steve.AssignExercise (objects, Streator);
            Steve.AssignExercise (loops, Kristyn);
            Steve.AssignExercise (objects, Kristyn);
            Steve.AssignExercise (dictionaries, Kristyn);
            Steve.AssignExercise (lists, Kristyn);
            Meg.AssignExercise (dictionaries, Miller);
            Meg.AssignExercise (lists, Miller);
            Meg.AssignExercise (loops, Miller);
            Jenna.AssignExercise (lists, Aaron);
            Jenna.AssignExercise (dictionaries, Aaron);
            Joe.AssignExercise (lists, Mike);
            Joe.AssignExercise (dictionaries, Mike);

            // Create a list of students. Add all of the student instances to it.
            List<Student> students = new List<Student> ()
            {
                Streator,
                Kristyn,
                Miller,
                Aaron,
                Mike,
                Bogey,
            };

            List<Exercise> exercises = new List<Exercise> () 
            {
                loops,
                objects,
                dictionaries,
                lists
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                Steve,
                Meg,
                Jenna,
                Joe
            };

            List<Cohort> cohorts = new List<Cohort>() {
                twentyFive,
                twentySix,
                twentySeven
            };

            // 1. List exercises for the JavaScript language by using the Where() LINQ method.
            IEnumerable<Exercise> JSEx = exercises.Where(ex => ex.Language == "Javascript");
            foreach (var ex in JSEx)
            {
                Console.WriteLine($"Javascript exercises: {ex.Name}");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // 2. List students in a particular cohort by using the Where() LINQ method.
            IEnumerable<Student> studentsIn27 = students.Where(stu => stu.Cohort == twentySeven);
            foreach (var stu in studentsIn27)
            {
                Console.WriteLine($"Students in Cohort 27: {stu.FirstName} {stu.LastName}");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // 3. List instructors in a particular cohort by using the Where() LINQ method.
            IEnumerable<Instructor> instructorsIn26 = instructors.Where(ins => ins.Cohort == twentySix);
            foreach (var i in instructorsIn26)
            {
                Console.WriteLine($"Instructors in Cohort 26: {i.FirstName} {i.LastName}");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // 4. Sort the students by their last name.
            IEnumerable<Student> sortedStudents = students.OrderBy(stu => stu.LastName);
            foreach (var stu in sortedStudents)
            {
                Console.WriteLine($"Sorted students by last name: {stu.LastName}, {stu.FirstName}");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // 5. Display any students that aren't working on any exercises 
            List<Student> studentsWithNoExercises = students.Where(stu => stu.Exercises.Count == 0).ToList();
            foreach (var stu in studentsWithNoExercises)
            {
                Console.WriteLine($"Students who aren't working on exercises: {stu.FirstName} {stu.LastName}");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // 6. Which student is working on the most exercises?
            var studentWithMostExercises = (from s in students
                select new {
                    FirstName = s.FirstName,
                    Exercises = s.Exercises.Count()
                })
                .OrderByDescending(s => s.Exercises)
                .Take(1).ToList()[0];
                Console.WriteLine($"Student working on most exercises: {studentWithMostExercises.FirstName} {studentWithMostExercises.Exercises}");
                Console.WriteLine ("--------------------------------------------------------------------------------");

            // 7. How many students in each cohort?
            var numberOfStudentsInEachCohort = students.GroupBy(c => c.Cohort.Name);
            foreach (var studentGroup in numberOfStudentsInEachCohort)
            {
                Console.WriteLine($"{studentGroup.Key} has {studentGroup.Count()} students");
                Console.WriteLine ("--------------------------------------------------------------------------------");
            }

            // SQL/QUERY WAY
            // var totalStudents = from student in students
            //     group student by student.Cohort into sorted
            //     select new {
            //         Cohort = sorted.Key,
            //         Students = sorted.ToList()
            //     };
            //     foreach (var total in totalStudents)
            //     {
            //         Console.WriteLine($"Cohort {total.Cohort.Name} has {total.Students.Count()} students");
            //         Console.WriteLine ("--------------------------------------------------------------------------------");
            //     }
    
            // Generate a report that displays which students are working on which exercises.
            foreach (Exercise ex in exercises) {
                List<string> assignedStudents = new List<string> ();

                foreach (Student stu in students) {
                    if (stu.Exercises.Contains (ex)) {
                        assignedStudents.Add (stu.FirstName);
                    }
                }
                Console.WriteLine ($"{ex.Name} is being worked on by {String.Join(", ", assignedStudents)}");
            }
        }
    }
}