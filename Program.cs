using System;

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


        }
    }
}
