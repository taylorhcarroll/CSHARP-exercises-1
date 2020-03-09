using System;
using System.Collections.Generic;

namespace csharp_exercises_1
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Language { get; set; }

        //constructor method
        public Exercise(string name, string language)
        {
            Name = name;
            Language = language;
        }
    }
}