// Genera 3 numeros aleatorios
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

roll1 = 6;
roll2 = 6;
roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Doce roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        
        total += 6;
        
        
    }
    else
    {
        Console.WriteLine("You rolled double! +2 bonus to total!");
        total += 2;
    }

}


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
    Console.WriteLine(total);
}
else if(total >= 10)
{
    Console.WriteLine("You win a new laptop!");
    Console.WriteLine(total);
}
else if(total >= 7)
{
     Console.WriteLine("You win a trip for two!");
     Console.WriteLine(total);
}
else
{
    Console.WriteLine("You win a kitten!");
}


// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }