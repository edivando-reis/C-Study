/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random random = new Random();
string[] ordersIDs= new string[5];
for (int i = 0; i < ordersIDs.Length; i++)
{
   
    int prefixValue = random.Next(65, 70);
   
    string prefix = Convert.ToChar(prefixValue).toString();
  
    string suffix = random.Next(1, 1000).ToString("000");
   
    ordersIDs[i] = prefix + suffix;
}


foreach (var orderID in ordersIDs)
{
    Console.WriteLine(orderID);
}

/* string firstName = "Bob";
int widgetPurchased =7;

Testing a chance to the message.
int WidgetsSold = 7;
Console.WriteLine($"{firstName} sold {WidgetsSold} widgets.");

Console.WriteLine($"{firstName} purchased {widgetPurchased} widgets.");  */
