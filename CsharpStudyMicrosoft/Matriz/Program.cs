/* string[] fraudulentoOrdersIDs = new string[3]; */
string[] fraudulentOrdersIDs = ["A123", "B456", "C789"];

/* fraudulentoOrdersIDs[0] = "A123";
fraudulentoOrdersIDs[1] = "B456";
fraudulentoOrdersIDs[2] = "C789"; */
/* fraudulentoOrdersIDs[3] = "D000";  */

Console.WriteLine(fraudulentOrdersIDs[0]);
Console.WriteLine(fraudulentOrdersIDs[1]);
Console.WriteLine(fraudulentOrdersIDs[2]);

fraudulentOrdersIDs[0] = "F000";
Console.WriteLine($"Reassigning First: {fraudulentOrdersIDs[0]}");

Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process.");