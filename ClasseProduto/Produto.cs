using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração de atributos
        public int codigo;
        public string descricao="";
        public double preco;
        //declaração do método
        public void MostrarAtributos()
        {
            Console.WriteLine("Código: " + codigo +"\tDescrição:"
            + descricao + "\tPreço: " + preco);
        }
    }
}