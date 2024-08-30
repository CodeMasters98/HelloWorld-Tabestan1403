using UserData.Models;

namespace UserData
{
    //Class:
    //User Define DataType
    //Template For Objects
    //Container for methods and properties


    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Declare Variable
                //DataType NameVaribale = value;

                //User Define DataType
                Student student = new Student();
                student.FirstName = "Parham";
                
                student.GetFullName();
                Console.WriteLine(student.FirstName);

                //FirstName 
                string firstName = string.Empty;
                int counter = 0;
                while (true) 
                {
                    firstName = UserDataHandler(nameof(firstName));
                    if (IsExit(str: firstName))
                    {
                        PrintExit();
                        return;
                    }
                    if (IsValidName(firstName))
                    {
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter++;
                        Console.WriteLine($"You tried : {counter} times");
                    }
                }

                //LastName
                string lastName = string.Empty;
                while (true)
                {
                    lastName = UserDataHandler(nameof(lastName));
                    if (IsExit(str: lastName, exitCharacter: "O"))
                    {
                        PrintExit();
                        break;
                    }
                    if (IsValidName(lastName))
                    {
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter++;
                        Console.WriteLine($"You tried : {counter} times");
                    }
                }
                PrintSeperator();

                //Age
                int age = default(int);
                while (true)
                {
                    Console.WriteLine(GetMessage(nameof(age)));
                    age = GetNumericDataFromUser();
                    if (IsValidAge(age))
                    {
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter++;
                        Console.WriteLine($"You tried : {counter} times");
                    }
                }
               
                PrintSeperator();

                //PhoneNumber
                string phoneNumber = string.Empty;
                while (true)
                {
                    phoneNumber = UserDataHandler(nameof(phoneNumber));
                    if (IsExit(str: phoneNumber))
                    {
                        PrintExit();
                        break;
                    }
                    //Filter, Clean data
                    //+98 -> 0
                    //10 character + 0 start nashode bode -> ye sefr ezafe kone
                    if (IsValidPhoneNumber(phoneNumber))
                    {
                        counter = 0;
                        break;
                    }
                    else
                    {
                        counter++;
                        Console.WriteLine($"You tried : {counter} times");
                    }
                }
                
                PrintSeperator();

                //Show Profile
                PrintProfile(firstName: firstName, lastName: lastName, age: age, phoneNumber: phoneNumber);
            }
        }

        static bool IsExit(string str, string exitCharacter = "E")
        {
            str = str.Trim().ToUpper(); //زنجیره

            //Step 1
            //if (str == exitCharacter)
            //    return true;
            //else
            //    return false;

            //Step 2
            //bool result = (str == exitCharacter) ? true : false;
            //return result;

            //Step 3
            return (str == exitCharacter) ? true : false;
        }

        static void PrintProfile(string firstName, string lastName, int age, string phoneNumber)
        {
            PrintUserOutput("firstName", firstName);
            PrintUserOutput("lastName", lastName);
            PrintUserOutput("age", age.ToString());
            PrintUserOutput("phoneNumber", phoneNumber);
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

        static bool IsValidName(string str)
            => !string.IsNullOrEmpty(str) && str.Length > 1 ? true : false;

        static bool IsValidAge(int age)
            => age > 0 ? true : false;

        static bool IsValidPhoneNumber(string str)//09129564205 -> 11 len
            => !string.IsNullOrEmpty(str) && str.Length == 11 ? true : false;

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
