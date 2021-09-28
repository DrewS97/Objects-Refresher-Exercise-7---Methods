using System;

namespace GlobalCrypto{
  class Program {
    public static void Main (string[] args) {

      Crypto.CryptoList.Add(new Crypto("Ethereum", "ETH", 2840.81, 3.004005));
      Crypto.CryptoList.Add(new Crypto("GravitX", "GRX", 1.69, 10000.5431));
      Crypto.CryptoList.Add(new Crypto("Binance Coin", "BNB", 334.21, 45.1576));
      
      Console.WriteLine("\n------------------------------------------------------My Cryptos-----------------------------------------------------\n");
      Crypto.PrintAll();

      Console.WriteLine($"\nTotal Value: {Crypto.TotalValue(), -15:C2}");
      
    }
  }
}