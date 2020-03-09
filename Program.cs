using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_exercises_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise1 = new Exercise("React Intro", "JS");
            Exercise exercise2 = new Exercise("make a loop", "JS");
            Exercise exercise3 = new Exercise("Make a Class", "C#");
            Exercise exercise4 = new Exercise("Make a Dictionary", "C#");

            Cohort cohort1 = new Cohort("C35");
            Cohort cohort2 = new Cohort("C36");
            Cohort cohort3 = new Cohort("C37");

            Student student1 = new Student("Heidi", "Smith", "@heidiSmith", cohort1);
            Student student2 = new Student("Holden", "Parker", "@holdenParker", cohort3);
            Student student3 = new Student("Taylor", "Carroll", "@taylorhcarroll", cohort3);
            Student student4 = new Student("Guy", "Cherkesky", "@guy", cohort2);

            Instructor instructor1 = new Instructor("Brenda", "Long", "@blong", "UX", cohort1);
            Instructor instructor2 = new Instructor("Steve", "Brownlee", "@steve", "Curriculum Writing", cohort2);
            Instructor instructor3 = new Instructor("Adam", "Scheaffer", "@adam", "C#", cohort3);

            instructor1.Assign(cohort1, exercise1);
            instructor2.Assign(cohort2, exercise3);
            instructor3.Assign(cohort3, exercise4);

            List<Student> students = new List<Student>()
            {
                student1,
                student2,
                student3,
                student4,
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                cohort1,
                cohort2,
                cohort3
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                instructor1,
                instructor2,
                instructor3
            };

            List<Exercise> exercises = new List<Exercise>()
            {
                exercise1,
                exercise2,
                exercise3,
                exercise4
            };

            var allJsExercise = exercises.Where(exercise =>
            {
                return exercise.Language == "JS";
            });

            foreach (var exercise in allJsExercise)
            {
                Console.WriteLine(exercise.Name);
            }

            var studentsOrderedByLastName = students.OrderBy(student =>
            {
                return student.LastName;
            });

            foreach (var student in studentsOrderedByLastName)
            {
                Console.Write($"{student.FirstName} {student.LastName}");
            }

            var studentsWithNoExercises = students.Where(student =>
            {
                int exercisesCount = student.Exercises.Count;
                return exercisesCount == 0;
            });

            Console.WriteLine("These students are not working on any exercises.");
            foreach (var student in studentsWithNoExercises)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            var studentsWithMostExercises = students.OrderByDescending(student =>
            {
                return student.Exercises.Count;
            }).FirstOrDefault();

            var groups = students.GroupBy(student => student.Cohort.CohortName);

            foreach (var group in groups)
            {
                Console.WriteLine($"There are {group.Count()} students in {group.Key}");
            }
        }
    }
}
