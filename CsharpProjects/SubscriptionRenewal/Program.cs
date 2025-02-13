 Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        
        daysUntilExpiration = 10; 

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }
        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 5)
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine($"Your subscription will expire soon. Renew now!");
        }




/* Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercenteage = 0;

daysUntilExpiration = 0;

if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now!");
    discountPercenteage = 10;
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercenteage = 20;
}
else
{
    Console.WriteLine("Your subscription is expired.");
}

if (discountPercenteage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercenteage}%.");
} */

/* if (daysUntilExpiration <= 10);
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}  
if (daysUntilExpiration <= 5) 
{
    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days. Renew now!");
    Console.WriteLine($"Renew now and save {discountPercenteage = 10}%.");
}
if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save  {discountPercenteage = 20}%.");
}
else {
    Console.WriteLine("Your subscription is expired.");
} */