// Exercise 3


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };


for (int i = 0; i < myStrings.Length; i++)
{   string myString = myStrings[i];
      
    int periodLocation = myString.IndexOf(".");
      
    while (periodLocation != -1)
    {
        string sentence = myString.Substring(0, periodLocation).TrimStart();
        
        Console.WriteLine(sentence);
        
        myString = myString.Remove(0, periodLocation + 1).TrimStart();
               
        periodLocation = myString.IndexOf(".");
    }
    
    if (!string.IsNullOrEmpty(myString))
    {
        Console.WriteLine(myString.TrimStart());
    }
}



//Exercise 2

/* string? readResult;
bool validRole = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User) ");
    readResult = Console.ReadLine()?.Trim().ToLower();

    if (readResult == "administrator" || readResult == "manager" || readResult == "user")
    {
        validRole = true;
        Console.WriteLine($"You entered a valid role: {readResult}");
    }
    else
    {
        validRole = false;
        Console.WriteLine($"The role name that you entered, {readResult} is not valid. Enter your role name (Administrator, Manager, or User");
    }
} while (validRole == false); */


// Exercise 1

/* string? readResult;

Console.WriteLine("Enter an integer value between 5 and 10: ");

int number = 0;
bool validNumber = false;

do 
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        validNumber = int.TryParse(readResult, out number);
        if (validNumber && number >= 5 && number <= 10)
        {
            validNumber = true;
            Console.WriteLine($"You input value ({number}) has been accepted.");
        }
        else
        {
            validNumber = false;
            Console.WriteLine("Sorry you entered an invalid number, please try again.");
        }
    }
} while (validNumber == false); */