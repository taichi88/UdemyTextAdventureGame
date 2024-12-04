// See https://aka.ms/new-console-template for more information




Console.WriteLine("Welcome To the Adventure Game");
Console.WriteLine("Enter your charactere's name: ");
string playerName = Console.ReadLine();

Console.WriteLine("Choose your character type(Warrior, Wizard, Archer");
string characterType = Console.ReadLine();

Console.WriteLine($"You, {playerName} the {characterType} find yourself at the ");
Console.WriteLine("Do you enter the forest or camp oustide? (Enter/Camp)");

string choice1 = Console.ReadLine();    

if (choice1.ToLower() == "enter")
{
    Console.WriteLine("You bravely Enter the forest");

}
else
{
    Console.WriteLine("You decide to camp out and wait for daylight");

}
bool gameContinues = true;

while (gameContinues)
{
    Console.WriteLine("You come to a fork in the road. Go left or right");
    string direction = Console.ReadLine();


    if (direction.ToLower() == "left")
    {
        Console.WriteLine("You find a treasure chest!");
        gameContinues = false;
    }
    else
    {
        Console.WriteLine("You encountered a wild beast!");
        Console.WriteLine("Fight or flee? (fight/flee");
        string fightchoice = Console.ReadLine();
        if (fightchoice.ToLower() == "fight")
        {
            Random random = new Random();
            int luck = random.Next(1, 11);
            if (luck > 5)
            {
                Console.WriteLine("you beat the wild beast!");
                if(luck > 8)
                {
                    Console.WriteLine("The wild beast dropped a treasure");
                }
            else
                {
                    Console.WriteLine("The beast attackede you where did't except it");
                    Console.WriteLine("it Beats you and you lost");
                    gameContinues = false;

                }

            }
        }
    }
}
Console.ReadLine();