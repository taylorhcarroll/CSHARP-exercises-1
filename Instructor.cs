using System;
using System.Collections.Generic;

namespace csharp_exercises_1
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string SlackHandle { get; set; }
        public Cohort Cohort { get; set; }

        //Method
        public void Assign(Cohort cohort, Exercise exercise)
        {
            foreach (var student in cohort.Students)
            {
                student.Exercises.Add(exercise);
            }
        }
        //constructor method
        public Instructor(string first, string last, string slack, string specialty, Cohort cohort)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            Specialty = specialty;
            Cohort = cohort;
        }
    }
}