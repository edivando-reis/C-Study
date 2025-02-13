/* string fruit = "banana";

switch (fruit)
{
    case "apple":
        Console.WriteLine("Apple is red.");
        break;
    case "banana":
        Console.WriteLine("Banana is yellow.");
        break;
    case "cherry":
        Console.WriteLine("Cherry is red.");
        break;
} */




int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");