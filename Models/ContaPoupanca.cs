namespace ProjetoBanco.Models
{
    public class ContaPoupanca : ContaBancaria
    {
        public double TaxaJuros { get; set; }
    
        public void SetTaxaJuros(double taxaJuros){
            TaxaJuros = taxaJuros;
        }

        public double GetTaxaJuros(){
            return TaxaJuros;
        }

        public void AtualizarSaldo(){
            Saldo = Saldo + (Saldo*(TaxaJuros/100));
        }
    }
}