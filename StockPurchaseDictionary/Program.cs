using System;
using System.Collections.Generic;
using System.Linq;

namespace StockPurchaseDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("TSLA", "Tesla");
            stocks.Add("AAPL", "Apple");
            stocks.Add("AMZN", "Amazon");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            purchases.Add((ticker: "GE", shares: 170, price: 21.41));
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 32, price: 17.87));
            purchases.Add((ticker: "CAT", shares: 5, price: 17.87));
            purchases.Add((ticker: "TSLA", shares: 80, price: 19.02));
            purchases.Add((ticker: "AAPL", shares: 120, price: 39.32));
            purchases.Add((ticker: "AMZN", shares: 67, price: 49.04));

            //Create a total ownership report that computes the total value of each stock that you have purchased.
            var ownershipReport = "Here is a breakdown of the total valuation of each stock you've purchased:";
            Console.WriteLine(ownershipReport);
            foreach (var purchase in purchases)
            {
                var totalValue = purchase.shares * purchase.price;
                var roundedTotalValue = Math.Round(totalValue, 2).ToString("$#.00");
                Console.WriteLine($"{roundedTotalValue} worth of {purchase.ticker}");
            }
            //var groupedStocks = purchases.GroupBy(x => x.ticker);
            //foreach (var groupedStock in groupedStocks)
            //{
            //    //var ticker = groupedStock.Key;
            //    //Console.WriteLine($"{groupedStock.Key}");
            //    var shares = groupedStock.ToList();
            //    foreach (var stock in groupedStock)
            //    {
            //        var totalValue = stock.shares * stock.price;
            //        var roundedTotalValue = Math.Round(totalValue, 2).ToString("$#.00");
            //        Console.WriteLine($"{roundedTotalValue} worth of {stock.ticker}");
            //    }
            //}

            //This is the basic relational database join algorithm between two tables.

            /*
             * Define a new Dictionary to hold the aggregated purchase information. - The key should be a string that is the full company name.
             * The value will be the valuation of each stock (price*amount) { "General Electric": 35900, "AAPL": 8445, ... }
            */
            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                // If it does, update the total valuation
                // If not, add the new key and set its value
            }
        }
    }
}