using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using BittrexSharp;

using System.Threading.Tasks;
using BittrexSharp.Domain;

namespace BittrexUtilsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<Task<ResponseWrapper<IEnumerable<Market>>>> action = async () =>
            //{
            //    var apiKey = "b6261f5e794f4c5fb0fcd8ede10eaea8";
            //    var apiSecret = "7c8e55b4d0b245779e4d645f7a5bc92f";
            //    var bittrex = new Bittrex(apiKey, apiSecret);
            //    var response = await bittrex.GetMarkets();
            //    await Task.Delay(1000);
            //    return response;
            //};

            TestAsync().Wait();
        }

        static async Task TestAsync()
        {
            var task = await GetBittrixTickerDataAsync();
            //var task = await GetBittrixMarketAsync();
            Console.WriteLine("TestAsync() done..");
        }


        private static async Task<ResponseWrapper<IEnumerable<TickerV2>>> GetBittrixTickerDataAsync()
        {
            Console.WriteLine("before");  // Step Out from here
            var apiKey = "b6261f5e794f4c5fb0fcd8ede10eaea8";
            var apiSecret = "7c8e55b4d0b245779e4d645f7a5bc92f";
            var bittrex = new Bittrex(apiKey, apiSecret);
            

            string DefaultMarketName = "BTC-ETH";
            string tickInterval = "thirtyMin";
            UInt64 timeStamp = 1500915289433;

            var result = await bittrex.GetTicker(DefaultMarketName, tickInterval, timeStamp);
            Console.WriteLine("after");  // Step Out from here        
            return result;
        }

        private static async Task<ResponseWrapper<IEnumerable<Market>>> GetBittrixMarketAsync()
        {
            Console.WriteLine("before");  // Step Out from here
            var apiKey = "b6261f5e794f4c5fb0fcd8ede10eaea8";
            var apiSecret = "7c8e55b4d0b245779e4d645f7a5bc92f";
            var bittrex = new Bittrex(apiKey, apiSecret);
            var result = await bittrex.GetMarkets();
            Console.WriteLine("after");  // Step Out from here        
            return result;
        }
    }
}
