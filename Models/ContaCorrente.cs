namespace ProjetoBanco.Models
{
    public class ContaCorrente : ContaBancaria
    {
        public double LimiteCredito { get; set; }

        public void SetLimiteCredito(double limiteCredito){
            LimiteCredito = limiteCredito;
        }

        public double GetLimiteCredito(){
            return LimiteCredito;
        }
    }
}