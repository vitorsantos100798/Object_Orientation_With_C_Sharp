namespace ConstructorFuncionario
{
  public class Funcionario
  {
    public int Codigo { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }
    public int Contador { get; set; }

    public Funcionario(int codigo)
    {
      this.Codigo = codigo;
    }

    public Funcionario(int codigo, string nome)
    {
      this.Codigo = codigo;
      this.Nome = nome;
    }

    public Funcionario(int codigo, string nome, double salario)
    {
      this.Codigo = codigo;
      this.Nome = nome;
      this.Salario = salario;

    }

    public void Mostrar()
    {
      Console.WriteLine("id: " + Codigo + " " + "nome " + Nome + " " + Salario);
    }
  }
}