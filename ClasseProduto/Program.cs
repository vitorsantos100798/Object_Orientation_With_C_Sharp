// função Main()
using ClasseProduto;

//insciando objetos
Produto p1 = new Produto();
Produto p2 = new Produto();
//Cadastro de Produtos
Console.WriteLine("***CADASTRO DE PRODUTOS***\n");
Console.Write("Digite o código: ");
p1.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a descrição: ");
p1.descricao = Console.ReadLine();
Console.Write("Digite o preço: ");
p1.preco = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o código: ");
p2.codigo = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite a descrição: ");
p2.descricao = Console.ReadLine();
Console.Write("Digite o preço: ");
p2.preco = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\n***APRESENTAÇÃO DOS PRODUTOS***\n");
p1.MostrarAtributos();
p2.MostrarAtributos();
double soma = p1.preco + p2.preco;
Console.WriteLine($"\n***Soma dos preços R$ {soma:N}");