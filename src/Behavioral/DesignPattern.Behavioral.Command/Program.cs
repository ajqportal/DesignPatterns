// See https://aka.ms/new-console-template for more information
using DesignPattern.Behavioral.Command.Commands;
using DesignPattern.Behavioral.Command.Enums;

WarehouseCommand warehouse = new WarehouseCommand();

warehouse.ExecuteCommand(CommandType.Add, "Item A", 10);
warehouse.ExecuteCommand(CommandType.Add, "Item B", 5);
warehouse.ExecuteCommand(CommandType.Delete, "Item A", 3);
warehouse.ExecuteCommand(CommandType.Update, "Item B", 8);
warehouse.ExecuteCommand(CommandType.Delete, "Item C", 2);

Console.WriteLine("Current stock:");
warehouse.DisplayStocks();