int quantity = 3;

int age;
string? name;

// int ages = [];
int[] ages = new int[quantity];
string[] names = new string[quantity];

for (int i = 0; i < quantity; i++)
{
    Console.Clear();
    Console.WriteLine($"Cadastrando Registro Nº {i + 1}");

    Console.Write("Nome : ");
    name = Console.ReadLine();

    Console.Write("Age : ");
    age = int.Parse(Console.ReadLine());

    names[i] = name ?? "No name";
    ages[i] = age;
}

Console.Clear();
Console.WriteLine("Students List");
Console.WriteLine("-------------");

for (int i = 0; i < quantity; i++)
{
    Console.WriteLine($"Showing Register Number {i + 1}:");
    Console.WriteLine($"{names[i]} \t {ages[i]}");

}

Console.WriteLine("Press any button to continue");
Console.ReadKey();