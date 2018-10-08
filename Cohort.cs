using System.Collections.Generic;

namespace StudentExercises {
    public class Cohort {

        public string cohortName { get; set; }
        List<Student> students = new List<Student> ();

        List<Instructor> instructors = new List<Instructor> ();

    }
}