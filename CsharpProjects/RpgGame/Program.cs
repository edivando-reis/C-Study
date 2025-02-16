int heroLife = 10;
int villainLife = 10;

Random random = new Random();

int heroAttack = random.Next(1, 10);
int villainAttack = random.Next(1, 10);

do
{
    villainLife -= heroAttack;
    heroLife -= villainAttack;

    Console.WriteLine($"Monster was damage and lost {heroAttack} health and now has {villainLife} health.");
    Console.WriteLine($"Hero was damage and lost {villainAttack} health and now has {heroLife} health.");


} while ( heroLife > 0 && villainLife > 0);

/* while (heroLife > 0 && villainLife > 0)
{
    villainLife -= heroAttack;
    heroLife -= villainAttack;

    Console.WriteLine($"Monster was damage and lost {heroAttack} health and now has {villainLife} health.");
    Console.WriteLine($"Hero was damage and lost {villainAttack} health and now has {heroLife} health.");

    
} */

   if (villainLife == 0)
   {
    Console.WriteLine("Hero Wins!");
   } else
   {
    Console.WriteLine("Villain Wins!");
   } 