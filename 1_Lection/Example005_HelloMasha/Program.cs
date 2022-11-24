Console.Write("Input your name: ");
string name = Console.ReadLine();
if (name.ToLower() == "Masha")
    Console.WriteLine("Wow, this is Masha");
else
    Console.WriteLine($"Hello, {name}");