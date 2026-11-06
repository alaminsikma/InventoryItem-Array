// Console.WriteLine("Hello, World!");

// string[] inventory = {"Healt Potion", "Sword", "Shield", "Bread", "Key"};

// Console.WriteLine(inventory[0]); // Healt Potion
// Console.WriteLine(inventory[1]); // Sword
// Console.WriteLine(inventory[2]); // Shiel
// Console.WriteLine(inventory[3]); // Bread
// Console.WriteLine(inventory[4]); // Key


// Console.WriteLine($"\nTotal items: {inventory.Length}");


// string[] inventory = {"al", "ade", "aaron", "babari"};

// foreach(var item in inventory)
// {
//     Console.WriteLine(item);
// }

int[] Score= {90,70,80,100,50};
int noPlayer =1;
int highestScore = 0;

foreach(var item in Score)
{
    Console.WriteLine($"Player {noPlayer}: {item}");
    noPlayer++;

    
 
if (item>highestScore);
    {
        highestScore=item;
    }

}

Console.WriteLine($"Avarage scores : {Score.Average()}");





int[] scores = {75,90,60,100,80};

float total = 0, avarage;

for(int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Player {i+1} : {scores[i]}");
    total += scores[i];
}
avarage = total / scores.Length;
Console.WriteLine($"avarage score : {avarage}");