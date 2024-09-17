
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<CatFood>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            System.Console.WriteLine("Enter the Name: ");
            var catFood = new CatFood();

            Console.WriteLine("Enter the value for ");
            catFood.Name = Console.ReadLine();

            System.Console.WriteLine("Enter the Price: ");
            catFood.Price = decimal.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the Quantity: ");
            
            catFood.Quantity = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the Description: ");
            catFood.Description =Console.ReadLine();

            System.Console.WriteLine("Is this Food for kitten? (true/false): ");
            catFood.KittenFood = bool.Parse(Console.ReadLine());

            recordList.Add(catFood);
        }
        //Print out the list of records
        foreach (var record in recordList)
        {
            System.Console.WriteLine(record.ToString());
        }
    }
}

internal class CatFood
{
    public string? Name { get; internal set; }
    public object Price { get; internal set; }
    public int Quantity { get; internal set; }
    public string? Description { get; internal set; }
    public bool KittenFood { get; internal set; }
}

// Print out the list of records using Console.WriteLine()