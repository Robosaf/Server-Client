using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    class Student
    {
        public string fullName;
        public int History { get; set; }
        public int Math { get; set; }
        public int English { get; set; }
        public int Physics { get; set; }
        public int Biology { get; set; }

        public Student(string fullName, int history, int math, int english, int physics, int biology)
        {
            this.fullName = fullName;
            History = history;
            Math = math;
            English = english;
            Physics = physics;
            Biology = biology;
        }

        public override string ToString()
        {
            return $"Full name: {fullName}." +
                   $" Grades: History - {History}, Math - {Math}, English - {English}, Physics - {Physics}, Biology - {Biology}.";
        }
    }
}
