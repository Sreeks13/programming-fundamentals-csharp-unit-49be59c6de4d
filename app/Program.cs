Console.Write("Enter books: ");

string? input = Console.ReadLine();

Console.WriteLine(InventoryChecker.CheckInventory(input ?? ""));