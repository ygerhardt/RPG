class Program
{
    static void Main(string[] args)
    {
        //declare variables
        int playerHealth = 20;
        int enemyHealth = 20;

        while (playerHealth > 0 && enemyHealth > 0)
        {
        Console.WriteLine("The player has " + playerHealth + " health left");
        Console.WriteLine("The enemy has " + enemyHealth + " health left");
        Console.WriteLine("Do you want to attack or block?");
        //get the players choice
        string playerChoice = Console.ReadLine();
        //decide enemy damage
        int enemyDamage = new Random().Next(1, 4);

        //process player action
        if (playerChoice == "attack")
        {
            Console.WriteLine("You attacked for 3 damage");
            enemyHealth -= 3;
            Console.WriteLine("The enemy attacked for " + enemyDamage + " damage!");
            playerHealth -= enemyDamage;
        }
        else if (playerChoice == "block")
        {
            Console.WriteLine("You sucessfully blocked the attack");
            Console.WriteLine("You blocked " + enemyDamage + " damage");
        }
        }
        if (playerHealth <= 0)
        {
            Console.WriteLine("You have been killed.");
        }
        if (enemyHealth <= 0)
        {
            Console.WriteLine("You killed the enemy!");
        }
        if (playerHealth == enemyHealth)
        {
            Console.WriteLine("You killed each other!");
        }
        Console.ReadKey();
    }
}