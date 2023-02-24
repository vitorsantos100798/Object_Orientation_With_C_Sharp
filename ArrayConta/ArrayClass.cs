namespace ArrayConta
{
     public class Conta
    {
        //declaração de atributos
        public int numero;
        public string titular = "";
        public double saldo;
        //declaração dos métodos/funções
        public bool Transferir(double valorTransfencia,
        Conta objContaATransferir)
        {
            if (saldo >= valorTransfencia)
            {
                saldo -= valorTransfencia;
                objContaATransferir.saldo = objContaATransferir.saldo + valorTransfencia;
                return true;
            }
            return false;
        }
        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\nTitular: " + titular +
            "\nSaldo: " + saldo);
        }
        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
        }
        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }
    }
}