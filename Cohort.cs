using System;
using System.Collections.Generic;

namespace csharp_exercises_1
{
    public class Cohort
    {
        public string CohortName { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Instructor> Instructors = new List<Instructor>();

        public Cohort(string cohortName)
        {
            CohortName = cohortName;
            // Student = student;
            // Instructor = instructor;

        }
    }
}