using System;

namespace FixMe
{
    class Program
    {
        public static void Main(string[] args) {
        int numStudents;
        int NumberOfTeachersInTheSchool;
        double average_gpa;

        string n;
        string CityInWhichTheSchoolResides;
        bool IS_PUBLIC;

        numStudents = 403;
        string city = "Atlanta, GA";
        NumberOfTeachersInTheSchool = 62;
        average_gpa = 2.98;
        string name = "Grady High School";
        IS_PUBLIC = true;

        Console.WriteLine("School: " + name);
        Console.WriteLine("Teachers: " + NumberOfTeachersInTheSchool);

        function(average_gpa, city);
        {
            Console.WriteLine($"The average GPA of {city} is {average_gpa}.");
        }
        int var;

        if (numStudents >= 10) 
        {
            Console.WriteLine("We have at least 10 students");
        }
        if (NumberOfTeachersInTheSchool >= 5) 
        {
            Console.WriteLine("We have at least 5 teachers");
        }
        void function (double x, string y) => Console.WriteLine($"{x} , {y}");
    }

        
            
    }
}

