using ProjetoBanco.Models;
namespace ProjetoBanco
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contaCorrente = new ContaCorrente();
            var contaPoupanca = new ContaPoupanca();
            contaCorrente.Depositar(100);
            contaCorrente.Sacar(20);
            contaCorrente.ExibirSaldo();
            contaPoupanca.Depositar(200);
            contaPoupanca.Sacar(80);
            contaPoupanca.ExibirSaldo();
           
        }
    }
}
