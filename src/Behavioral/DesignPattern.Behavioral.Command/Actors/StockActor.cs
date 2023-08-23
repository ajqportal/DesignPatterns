namespace DesignPattern.Behavioral.Command.Actors
{
    internal static class StockActor
    {
        internal static void AddStock(this Dictionary<string, int> stocks, string item, int quantity)
        {
            if (stocks.ContainsKey(item))
                stocks[item] += quantity;
            else
                stocks[item] = quantity;

            Console.WriteLine($"Added {quantity} {item} to stock.");
        }

        internal static void UpdateStock(this Dictionary<string, int> stocks, string item, int newQuantity)
        {
            if(stocks.ContainsKey(item))
            {
                stocks[item] = newQuantity;
                Console.WriteLine($"Updated {item} stock to {newQuantity}.");
            }
            else
                Console.WriteLine("Item not found in stock.");
        }

        internal static void RemoveStock(this Dictionary<string, int> stocks, string item, int quantity)
        {
            if(stocks.ContainsKey(item))
            {
                if (stocks[item] >= quantity)
                {
                    stocks[item] -= quantity;
                    if (stocks[item] == 0)
                    {
                        stocks.Remove(item);
                    }
                    Console.WriteLine($"Removed {quantity} {item} from stock.");
                }
                else
                    Console.WriteLine("Not enough stock to remove.");
            }
            else
                Console.WriteLine("Item not found in stock.");
        }
    }
}
