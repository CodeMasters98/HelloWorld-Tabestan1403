// See https://aka.ms/new-console-template for more information


//مدیریت حلقه
//متد
//سورس کد




int count = 0;
while (count < 5)
{
    var j = count * 2;
    if (count == 3)
    {
        Console.WriteLine("You successfully reach number 3");
        break;
    }
    Console.WriteLine(j);
}

// i = i + 1 => i++
for (int i = 0; i < 5; i++)
{
    var j = i * 2;
    if (i == 3)
    {
        Console.WriteLine("You successfully reach number 3");
        //break;
        continue;
    }   
    Console.WriteLine(j);
}

for (int i = 5; i > 0; i--)
{
    Console.WriteLine(i);
}


Console.WriteLine("Please enter your first name?");
string firstName = Console.ReadLine() ?? string.Empty; //null handle
firstName = firstName.Trim();

if (string.IsNullOrEmpty(firstName))
{
    Console.WriteLine("Invalid FirstName!");
    Console.ReadLine();
    return;
}

//به دست آوردن تعداد کاراکتر یک رشته
int lenFirstName = firstName.Length;
//تبدیل به کاراکترهای بزرگ
firstName = firstName.ToUpper();
//تبدیل بخ کارکاتر های کوچک
firstName = firstName.ToLower();
//حذف فاصله ها
firstName = firstName.Trim();
//بخشی از یک رشته را جدا کنم.
var subFirstName = firstName.Substring(0,3);
//startwith
//endwith
//array
//show string $""
//Next Line into string
//replace
//Get Type in C#

Console.WriteLine("Please enter your last name?");
string lastName = Console.ReadLine() ?? string.Empty;
lastName = lastName.Trim();

Console.WriteLine("Please enter your phone?"); //09129564205
string phone = Console.ReadLine() ?? string.Empty;
phone = phone.Trim();
if (phone.StartsWith("+98"))
{
    phone = phone.Replace("+98", "0");//11
}
if (phone.StartsWith("098"))
{
    phone = phone.Replace("098", "0");
}
if(phone.Length == 10 && !phone.StartsWith("0"))
{
    phone = "0" + phone;
}

var item = phone.ToArray();
Console.WriteLine(item.GetType());

//One way
//string subPhone = phone.Substring(0, 2);
//if (subPhone != "09")
//{
//    Console.WriteLine("You entered invalid phone");
//}
//another way
if (!phone.StartsWith("09"))
{
    Console.WriteLine("You entered invalid phone");
}

int lenPhone = phone.Length;
if (lenPhone != 11)
{
    Console.WriteLine("You entered invalid phone");
}


Console.WriteLine("Please enter your gender?(F: for female | M: For Male | N: Not say)"); //"M    "    "m" -> "M", "parham" -> "PARHAM"
string gender = Console.ReadLine() ?? string.Empty;
gender = gender.ToUpper();

bool isRegistered = false;

switch (gender)
{
    case "M":
        Console.WriteLine("You are Male");
        isRegistered = true;
        break;
    case "F":
        Console.WriteLine("You are FeMale");
        isRegistered = true;
        break;
    case "N":
        Console.WriteLine("You did not say your gender");
        isRegistered = false;
        break;
    default:
        Console.WriteLine("Please enter valid option");
        isRegistered = false;
        break;
}

Console.WriteLine("Please enter your age?");
string ageStr = Console.ReadLine() ?? string.Empty; //"25 "
ageStr = ageStr.Trim();

int age = int.Parse(ageStr); // "25" + 1 -> 25 + 1
//age condion

//bool isRegistered = false;

//if(age > 18 && gender == "M")
//    isRegistered = true;

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
//string description = "Your firstName is " + firstName + " And ypur last name is " + lastName;
string description = $"Your firstName is {firstName} And your last name is {lastName}";
Console.WriteLine(description);
Console.WriteLine($"Your age is {age} -> {yearGroup}");

string description4 = $"Your firstName is  And your last name is \n" +
    $"This test";
Console.WriteLine(description4);


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
