using System;

namespace Task5
{
    public sealed class StudentView
    {
        public void PrintStudentDetails(Student student)
        {
            Console.WriteLine($"RollNo: {student.RollNo}");
            Console.WriteLine($"Name: {student.Name}");
        }
    }
}
