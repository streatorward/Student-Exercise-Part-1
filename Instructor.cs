namespace StudentExercises {
    public class Instructor {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }

        public Cohort Cohort { get; set; }


        // Example of a Constructor to crate Instructor
        // public Instructor (string firstName, string lastName, string slackHandle, Cohort cohort)
        // {
        //     FirstName = firstName;
        //     LastName = lastName;
        //     SlackHandle = slackHandle;
        //     Cohort = cohort;
        // }

        public void AddExercise (Exercise exercise, Student student) 
        {
            student.Exercise.Add (exercise);
        }
    }
}