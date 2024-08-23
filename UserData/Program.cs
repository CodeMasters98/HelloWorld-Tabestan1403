using System.Xml.Linq;

namespace UserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //FirstName
                string firstName = string.Empty;
                firstName = UserDataHandler(nameof(firstName));
                if (IsExit(firstName))
                {
                    PrintExit();
                    break;
                }

                //LastName
                string lastName = string.Empty;
                lastName = UserDataHandler(nameof(lastName));
                if (IsExit(lastName))
                {
                    PrintExit();
                    break;
                }
                PrintSeperator();

                //Age
                int age = default(int);
                Console.WriteLine(GetMessage(nameof(age)));
                age = GetNumericDataFromUser();
                PrintSeperator();

                //PhoneNumber
                string phoneNumber = string.Empty;
                phoneNumber = UserDataHandler(nameof(phoneNumber));
                if (IsExit(phoneNumber))
                {
                    PrintExit();
                    break;
                }
                PrintSeperator();

                //Show Profile
                PrintProfile(firstName: firstName, lastName: lastName, age: age, phoneNumber: phoneNumber);
            }
        }

        static void PrintProfile(string firstName, string lastName, int age, string phoneNumber)
        {
            PrintUserOutput("firstName", firstName);
            PrintUserOutput("lastName", lastName);
            PrintUserOutput("age", age.ToString());
            PrintUserOutput("phoneNumber", phoneNumber);
        }

        static bool IsExit(string str)
        {
            if (str == "E" || str == "e")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Single line method;
        static string GetMessage(string property)
            => $"Please enter your {property}?(If you want to exit please enter -> **E**)";

        static void PrintUserOutput(string property, string str)
        {
            Console.WriteLine($"You enter {property}: {str} !!");
        }

        static string UserDataHandler(string property)
        {
            Console.WriteLine(GetMessage(property));
            string userData = GetStringDataFromUser();
            return userData;
        }

        static void PrintSeperator()
        {
            Console.WriteLine($"****************Thank you*******************");
        }

        static void PrintExit()
        {
            Console.WriteLine("You exits from app!");
        }

        static string GetStringDataFromUser()
        {
            string userInput = Console.ReadLine() ?? "";
            return userInput.Trim();
        }

        static int GetNumericDataFromUser()
        {
            string userInput = GetStringDataFromUser();
            return Convert.ToInt32(userInput);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void PrintSum(int num1, int num2)
        {
            Console.WriteLine($"{Sum(num1, num2)}");
        }

        static int Sum2(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
