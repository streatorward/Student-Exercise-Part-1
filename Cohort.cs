using System.Collections.Generic;

namespace StudentExercises {
    public class Cohort {

        public string CohortName { get; set; }

        List<Student> Students = new List<Student> ();

        List<Instructor> Instructors = new List<Instructor> ();

    }
}
