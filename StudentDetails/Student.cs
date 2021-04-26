namespace StudentDetails
{
    public class Student
    {
        public string Name;
        public int RollNumber;

        public string PhoneNumber;
        public string Address;

        public Student(string name, int rollNumber, string phoneNumber, string address)
        {
            Name = name;
            RollNumber = rollNumber;
            PhoneNumber = phoneNumber;
            Address = address;
        }


    }
}