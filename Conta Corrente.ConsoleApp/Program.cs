namespace Conta_Corrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta1 = new ContaCorrente();
            //conta1.saldo = 1000;
            //conta1.numero = 12;
            //conta1.limite = 0;
            //conta1.ehEspecial = true;
            //conta1.movimentacoes = new Movimentacao[10];

            //conta1.Sacar(200);
            //conta1.Depositar(300);
            //conta1.Depositar(500);
            //conta1.Sacar(200);

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.saldo = 300;
            //conta2.numero = 13;
            //conta2.limite = 0;
            //conta2.ehEspecial = true;
            //conta2.movimentacoes = new Movimentacao[10];

            //conta1.TranferirPara(conta2, 400);

            //conta1.ExibirExtrato();
            Conta contaComum = new Conta(230, 100, false, 100);
            Conta contaEspecial = new Conta(231, 100, true, 100);
            contaComum.RealizarTransferencia(contaEspecial, 50);
            Console.WriteLine(contaComum.RealizarSaque(150));
            Console.WriteLine(contaEspecial.RealizarDeposito(50));
            Console.WriteLine(contaComum.ExibirExtrato());
            Console.WriteLine(contaEspecial.ExibirExtrato());
            Console.ReadLine();
        }
    }
}