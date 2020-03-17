using System;
using ComparisonT.Entidades;
using System.Collections.Generic;

namespace ComparisonT {
    class Program {
        static void Main(string[] args) {
            

            List<Produto> lista = new List<Produto>();

            lista.Add(new Produto("TV", 900.00));
            lista.Add(new Produto("Notebook", 1200.00));
            lista.Add(new Produto("Tablet", 450.00));
            //agora iremos usar a versão que utiliza a comparison<T>
            //colocando como argumento a função CompareProdutos.
            //isso é uma Delagate, é uma referencia para função com TaipSafet
            lista.Sort(CompareProdutos);

            //SEGUNDO EXEMPLO
            Comparison<Produto> comp = CompareProdutos;
            lista.Sort(comp);

            //TERCEIRO EXEMPLO USANDO A EXPRESSÃO LAMBDA
            //com essa linha, não precisamos declarar o metodo CompareProdutos
            //isso é uma declaração de função anônima.
            Comparison<Produto> comp2 = (p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
            lista.Sort(comp2);

            //QUARTO EXEMPLO É QUE PODEMOS COLOCAR DIRETAMENTE DENTRO DO SORT
            lista.Sort((p1, p2) => p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper()));

            foreach (Produto p in lista) {
                Console.WriteLine(p);
            }            
        }

        //criamos um outro metodo statico para comparar.
        //retorna -1 se o p1 for < que p2
        //retorna 0 se o p1 for = p2
        //retorna 1 se o p1 for > p2
        static int CompareProdutos(Produto p1, Produto p2) {
            //retorna p1.nome em maiusculo comparado com o p2
            return p1.Nome.ToUpper().CompareTo(p2.Nome.ToUpper());
        }
        //exemplo de Comparison<T> (System)
        public delegate int Comparison<in T>(T x, T y);
    }
}
