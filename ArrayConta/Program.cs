using ArrayConta;

Conta[] vetConta = new Conta[3];

for (int i; i < vetConta.Length; i++)
{
  vetConta[i] = new Conta();
  Console.WriteLine("Digite o Numero:");
  vetConta[i].numero = Convert.ToInt32(Console.ReadLine());

}
foreach (Conta c in vetConta)
{
  c.MostrarAtributos();
}