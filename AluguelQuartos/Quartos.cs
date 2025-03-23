using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelQuartos {
    internal class Quartos {
        public string Nome { get; set; }
        public double Aluguel { get; set; }
        public int Numero { get; set; }

        public Quartos(string nome, double aluguel) {
            Nome = nome;
            Aluguel = aluguel;  
        }

        public void DadosQuarto() {
            Console.Write($"\nO nome do estudante é: {Nome}\nAluguel: R${Aluguel.ToString("F2")}\n");
        }
    }
}
