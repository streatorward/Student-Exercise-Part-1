using System.Collections.Generic;

namespace StudentExercises {
    public class Student {

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string slackHandle { get; set; }

        public string studentCohort { get; set; }

        public List<Exercise> exercise = new List<Exercise> ();

    }
}