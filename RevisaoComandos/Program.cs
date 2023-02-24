// função Main()

// Console.WriteLine("Bom dia!!!");
// //exemplo de entrada processamento e saída
// Console.Write("Digite seu ano de nascimento: ");
// int ano_nasc = Convert.ToInt32(Console.ReadLine());
// int idade = 2023 - ano_nasc;
// Console.WriteLine("Sua idade é " + idade + " anos.");

// //exemplo de estrutura de decisão
// Console.Write("Digite a primeira nota: ");
// double p1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Digite a segunda nota: ");
// double p2 = Convert.ToDouble(Console.ReadLine());
// if ( (p1 + p2) / 2 >= 6 )
//     Console.WriteLine("Aluno aprovado");
// else
//     Console.WriteLine("Aluno reprovado");
// char estacoes = '1';
// switch (estacoes)
// {
//     case '1': Console.WriteLine("Verão");
//             break;
//     case '2': Console.WriteLine("Outono");
//             break;
//     default: Console.WriteLine("Estação inexistente");
//              break;
// }
// int a= 10, b=15;
// int max = ( a > b ) ? a : b;
// Console.WriteLine("O maior valor é: " + max);

//exemplo de estrurura de repetição
int contador = 1;
while (contador < 5)
{
    Console.WriteLine(contador);
    //contador = contador + 1;
    //contador += 1;
    contador++;
}
while (contador >= 0)
{
    Console.WriteLine(contador);
    //contador = contador - 1;
    //contador -= 1;
    contador--;
}
System.Console.WriteLine();
int x;
for (x = 0; x <= 5; x++)
    Console.WriteLine(x);

System.Console.WriteLine("Exemplo do do .. while");
//estrurura de repetição -> repita até
do
{
    Console.WriteLine(x);
    x++;
} while (x < 10);

Console.WriteLine("\n");