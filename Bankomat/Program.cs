using Bankomat.BancomatServise;
using System;
using System.Transactions;
namespace Bankomat
{
    public class Program
    {
        static void Main(string[] args)
        {
            BancomatService serviselar = new BancomatService();
            serviselar.UsingBancomat();
        }
    }
}
