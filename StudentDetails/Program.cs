using System;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", 2, "08021345689", "Abeokuta Ogun State");
            Student student2 = new Student("Sam", 1,"07021345768", "Lekki, Lagos State");

            Console.WriteLine($"Name of the first student: {student1.Name}");
            Console.WriteLine($"Roll Number of the first student: {student1.RollNumber}");
            Console.WriteLine($"Phone Number of the first student: {student1.PhoneNumber}");
            Console.WriteLine($"Address of the first student: {student1.Address}");
            Console.WriteLine();
            Console.WriteLine($"Name of the second student: {student2.Name}");
            Console.WriteLine($"Roll Number of the second student: {student2.RollNumber}");
            Console.WriteLine($"Phone Number of the second student: {student2.PhoneNumber}");
            Console.WriteLine($"Address of the second student: {student2.Address}");
        }
    }
}
