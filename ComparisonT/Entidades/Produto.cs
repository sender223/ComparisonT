using System;
using System.Globalization;

namespace ComparisonT.Entidades {
    //usando o Icomparable 
    class Produto : IComparable<Produto> {

        public string Nome { get; set; }
        public double Preco { get; set; }

        //construtor
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //metodo tostring para transformar a classe em string
        public override string ToString() {
            return Nome + ", " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
        //metodo da operação Para comparar.
        public int CompareTo(Produto outro) {
            //aqui se quisermos trocar o metodo de comparação de nome para preco
            //precisamos alterar a linha abaixo. com isso a classe não fica fechada.
            return Nome.ToUpper().CompareTo(outro.Nome.ToUpper());
        }


    }
}
