using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForm
{
    class Student
    {
        private string name;
        private string surname;
        private string city;
        private string faculty;
        private int course;
        private double averageScore;

        public Student(string name, string surname, string city, string faculty, int course, double averageScore)
        {
            this.name = name;
            this.surname = surname;
            this.city = city;
            this.faculty = faculty;
            this.course = course;
            this.averageScore = averageScore;
        }
        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Faculty { get { return faculty; } set { faculty = value; } }
        public int Course { get { return course; } set { course = value; } }
        public double AverageScore { get { return averageScore; } set { averageScore = value; } }
    }
}
