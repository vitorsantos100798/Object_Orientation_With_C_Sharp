using System;
namespace ConstrutorConta
{
  public class Conta
  {
    public int Numero { get; set; }
    public string Titular { get; set; }
    public double Saldo { get; set; }
    public static int Contador { get; set; }

    static Conta()
    {
      Contador = -500;
    }
    public Conta()
    {
      Contador += 1;
    }
    public Conta(int numero)
    {
      this.Numero = numero;
      Contador += 1;
    }
    public Conta(int numero, string titular)
    {
      numero = Numero;
      Contador += 1;
      Titular = titular;
    }
    public void Mostrar()
    {

      Console.WriteLine("Número:" + " " + Numero + " " + "titular:" + " " + Titular + " " + "Saldo:" + " " + Saldo);


    }


  }
}