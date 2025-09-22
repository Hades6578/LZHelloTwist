// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Tap, tap");
Console.WriteLine("Is this thing on?");
string yes = "yes";
if (Console.ReadLine() == yes)
{
    Console.WriteLine("Oh great! ");
}
else
{
    Console.WriteLine("How did you respond to me if it wasn't on?");
}
Console.WriteLine ("Well that's odd. It seems the pull request was never approved... or something else happened. :/");
Console.WriteLine("Anyways, now that we've taken care of that, who's using me today?");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"{name}, here is the current UTC time");
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"Current UTC Time: {utcNow}");
Console.WriteLine($"I could continue pretending to be helpful, {name}");
Console.WriteLine("But I think we both know that I'm just burning electrcity right now.");

Console.WriteLine("Tally ho, old chum!");
