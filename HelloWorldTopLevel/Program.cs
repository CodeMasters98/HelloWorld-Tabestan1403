// See https://aka.ms/new-console-template for more information

//DataType Name = Default Value;
string firstName;
string FirstName;

int age = 20;
int newAge = 34;
age = newAge * 2 + 1;

Console.WriteLine(age);
Console.WriteLine("Please enter your first name!");
firstName = Console.ReadLine();
//firstName = "Zahra";
Console.WriteLine("You entered: " + firstName);

Console.ReadLine();