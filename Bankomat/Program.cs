using Bankomat.BancomatServise;
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
    abstract class Loger
    {
        internal abstract void LogInformation();
    }
}
