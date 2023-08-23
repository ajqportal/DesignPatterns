using DesignPattern.Behavioral.Command.Actors;
using DesignPattern.Behavioral.Command.Enums;

namespace DesignPattern.Behavioral.Command.Commands
{
    internal class WarehouseCommand
    {
        private Dictionary<string, int> stocks = new Dictionary<string, int>();
        internal void ExecuteCommand(CommandType commandType, string item, int quantity)
        {
            switch(commandType)
            {
                case CommandType.Add:
                    stocks.AddStock(item, quantity);
                    break;
                case CommandType.Update:
                    stocks.UpdateStock(item, quantity);
                    break;
                case CommandType.Delete:
                    stocks.RemoveStock(item, quantity);
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }

        internal void DisplayStocks()
        {
            foreach (var kvp in stocks)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
