// var students = new List<Student>();
//             students.Add(new Student)

//             var exercises = new List<Exercise>

// var allJsExercise = exercises.Where(exercises =>
// {
//     return exercises.Language == "JS";
// });

// foreach (var exercise in allJSsExercise)
// {
//     Console.WriteLine(exercise.Name);
// }

// var studentsOrderedByLastName = students.OrderBy(student =>
// {
//     return student.LastName;
// });

// foreach (var student in studentsOrderedByLastName)
// {
//     Console.Write($"{student.FirstName} {student.LastName}");
// }

// var studentsWithNoExercises = students.Where(student =>
// {
//     int exercisesCount = student.Exercises.Count;
//     return exercisesCount == 0;
// });

// Console.WriteLine("These students are not working on any exercises.");
// foreach (var student in studentsWithNoExercises)
// {
//     Console.WriteLine($"{student.FirstName} {student.LastName}");
// }

// var studentsWithMostExercises = students.OrderByDescending(student =>
// {
//     return student.Exercises.Count;
// }).FirstOrDefault();

// var groups = students.GroupBy(student => student.Cohort.Name);

// foreach (var group in groups)
// {
//     Console.WriteLine($"There are {group.Count()} students in {group.Key}");
// }