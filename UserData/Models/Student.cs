namespace UserData.Models
{
    internal class Student
    {

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public int Score { get; set; }

        //Methods
        public string GetFullName()
            => $"{FirstName} {LastName}";

        public static string GetTime() => $"Get time from : {DateTime.Now}";
    }
}
