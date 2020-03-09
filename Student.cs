using System;
using System.Collections.Generic;

namespace csharp_exercises_1
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        //reference to class Cohort
        public Cohort Cohort { get; set; }

        //references class, Exercise, will be marked as an error until Exercise has been made
        public List<Exercise> Exercises = new List<Exercise>();

        //constructor method
        public Student(string first, string last, string slack, Cohort cohort)
        {
            FirstName = first;
            LastName = last;
            SlackHandle = slack;
            Cohort = cohort;
        }
    }
}