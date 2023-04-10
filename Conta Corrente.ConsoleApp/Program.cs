namespace Conta_Corrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta1 = new ContaCorrente(12, 1000, true, 0);
            ContaCorrente conta2 = new ContaCorrente(13, 300, true, 0);
            Console.WriteLine(conta1.RealizarSaque(200));
            Console.WriteLine(conta1.RealizarDeposito(300));
            Console.WriteLine(conta1.RealizarDeposito(500));
            Console.WriteLine(conta1.RealizarSaque(200));
            Console.WriteLine(conta1.RealizarTransferencia(conta2, 400));
            Console.WriteLine(" ______________________ ");
            Console.WriteLine(conta1.ExibirExtrato());
            Console.WriteLine(conta2.ExibirExtrato());
            Console.ReadLine();
        }
    }
}
