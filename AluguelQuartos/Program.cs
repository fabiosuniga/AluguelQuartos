namespace AluguelQuartos {
    internal class Program {
        static void Main(string[] args) {

            Quartos[] quartos = new Quartos[10];
            

            Console.Write("Quantos estudantes serão adicionados: ");
            int estudante = int.Parse(Console.ReadLine());
            Console.WriteLine( );

            for(int i = 0 ; i < estudante; i++) {
                Console.Write($"Qual o nome do estudante {i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write($"Qual quarto {nome} vai ficar: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write($"Qual o aluguel do(a) {nome}: ");
                double aluguel = double.Parse(Console.ReadLine());

                quartos[numero] = new Quartos(nome, aluguel);

                Console.WriteLine();
            }

            for(int i = 0; i < 10; i++) {
                if (quartos[i] != null) {
                    Console.Write($"Numero do quarto: {i}");
                    quartos[i].DadosQuarto();
                    Console.WriteLine();
                }
            }

        }
    }
}
