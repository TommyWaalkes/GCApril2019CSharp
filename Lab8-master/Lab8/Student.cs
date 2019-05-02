using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    class Student
    {
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string FavoriteFood { get; set; }

        public Student(string name, string hometown, string favoritefood)
        {
            Name = name;
            HomeTown = hometown;
            FavoriteFood = favoritefood;
        }
    }
}
