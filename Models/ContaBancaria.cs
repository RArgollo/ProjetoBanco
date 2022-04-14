namespace ProjetoBanco.Models
{
    public class ContaBancaria
    {
        public double Saldo { get; set; }
        public Titular Titular { get; set; }
        public int Agencia { get; set; }
        public string NumeroConta { get; set; }

        public void SetSaldo(double saldo){
            Saldo = saldo;
        }
        
        public double GetSaldo(){
            return Saldo;
        }

        public void SetTitular(Titular titular){
            Titular = titular;
        }
        public Titular GetTitular(){
            return Titular;
        }

        public void SetAgencia(int agencia){
            Agencia = agencia;
        }
        public int GetAgencia(){
            return Agencia;
        }
        public void SetNumeroConta(string numeroDaConta){
            NumeroConta = numeroDaConta;
        }
        public string GetNumeroConta(){
            return NumeroConta;
        }
        public void Sacar(double valor){

        }
        public void Depositar(double valor){
            
        }
    }
}