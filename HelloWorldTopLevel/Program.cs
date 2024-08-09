// See https://aka.ms/new-console-template for more information


Console.WriteLine("Please enter your first name?");
string firstName = Console.ReadLine();

Console.WriteLine("Please enter your last name?");
string lastName = Console.ReadLine();

Console.WriteLine("Please enter your gender?(F: for female | M: For Male)");
string gender = Console.ReadLine();

Console.WriteLine("Please enter your age?");
string ageStr = Console.ReadLine();

int age = int.Parse(ageStr);
//age condion

bool isRegistered = false;

if(age > 18 && gender == "M")
    isRegistered = true;

string yearGroup = default;

if (age >= 0 && age <= 10)
{
    yearGroup = "Koodak";
}
else if( age >= 11 && age <= 19)
{
    yearGroup = "Nojavan";
}
else
{
    yearGroup = "Pir";
}

Console.WriteLine("Your firstName is " + firstName + " And ypur last name is " + lastName);
Console.WriteLine("Your age is " + age + " -> " + yearGroup);

//DataType Name = Default Value;
//string firstName = "";
//string FirstName = null;
//bool isActive = default;
//int num3 = default;

//if (num3 == 0)
//{
//    Console.WriteLine("It is 0");
//}

//Console.WriteLine("Please enter your age?");
//string ageStr = Console.ReadLine();

//var age = int.Parse(ageStr);
//age = age + 1;


//var name = "jashbd";

//float num4 = 1.17F;

//long num1 = 0;
//int num2 = 1;
//num2 = (int)num1;
//num1 = num2;

//int age = ageStr + 1;
