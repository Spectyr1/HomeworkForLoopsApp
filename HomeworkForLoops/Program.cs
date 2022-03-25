

Console.WriteLine("Please enter a list of first names. seperate each name with a comma(,) and do not use any spaces( ):");

string listEntry = Console.ReadLine();

string[] names = listEntry.Split('\u002C');

for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Hello {names[i]}");
}