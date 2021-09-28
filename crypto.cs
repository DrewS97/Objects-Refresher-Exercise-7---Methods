using System;
using System.Collections.Generic;

namespace GlobalCrypto{
  class Crypto {
    public string Name {get; set;}
    public string TokenName {get; set;}
    public double CurrentPrice {get; set;}
    public double AmountOwned {get; set;}
    public double Value {get; set;}
    public static List<Crypto> CryptoList = new List<Crypto>();

    public Crypto()
    {
      Name = "";
      TokenName = "";
      CurrentPrice = 0;
      AmountOwned = 0;
      Value = 0;
    }

    public Crypto(string name, string tname, double price, double owned)
    {
      Name = name;
      TokenName = tname;
      CurrentPrice = price;
      AmountOwned = owned;
      Value = price * owned;
    }

    public static void PrintAll()
    {
      foreach(Crypto c in CryptoList)
      {
        Console.WriteLine(c.ToString());
      }
    }

    public static double TotalValue()
    {
      double result = 0;
      foreach(Crypto c in CryptoList)
      {
        result = result + c.Value;
      }
      return result;
    }
    
    public override string ToString()
    {
      string s = String.Format($"Name: {Name, -18} ({TokenName}) | Current Price: {CurrentPrice, -10:C2} | Amount Owned: {AmountOwned, -20:N8} | Value: {Value, -10:C2} |");
      s += "\n---------------------------------------------------------------------------------------------------------------------";
      return s;
    }
  }
}