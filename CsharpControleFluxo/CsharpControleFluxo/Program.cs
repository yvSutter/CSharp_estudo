using System;

namespace ControleDeFluxo
{

    public class Principal
    {

        static void Main(string[] args)
        {

            ExecutarCase();
            Console.WriteLine("_____________________________________");
            ExecutarDoWhile();
            Console.WriteLine("_____________________________________");
            ExecutarFor();
            Console.WriteLine("_____________________________________");
            ExecutarForeach();
            Console.WriteLine("_____________________________________");
            ExecutarWhile();
        }

        public static void ExecutarCase()
        {
            Console.WriteLine("Digite um valor de 1 a 3");
            int n1 = int.Parse(Console.ReadLine());
            switch (n1)
            {
                case 1:
                    Console.WriteLine("Voce digitou o numero 1");
                    break;
                case 2:
                    Console.WriteLine("Voce digitou o numero 2");
                    break;
                case 3:
                    Console.WriteLine("Voce digitou o numero 3");
                    break;
                default:
                    Console.WriteLine("Numero digitado fora do intervalo (1 a 3).");
                    break;
            }
        }
        public static void ExecutarDoWhile()
        {
            int n2;

            do
            {
                Console.WriteLine("Digite um numero maior que 5.");
                n2 = int.Parse(Console.ReadLine());
                if (n2 <= 5)
                {
                    Console.WriteLine("Numero invalido, tente novamente.");
                }


            } while (n2 <= 5);
            Console.WriteLine($"Voce digitou {n2}, que é maior que 5. Parabens! ");

        }
        public static void ExecutarElse()
        {
            Console.WriteLine("Digite um numero de 1 a 3: ");
            int n3 = int.Parse(Console.ReadLine());
            if (n3 == 1)
            {
                Console.WriteLine("Voce digitou o numero 1.");
            }
            else if (n3 == 2)
            {
                Console.WriteLine("Voce digitou o numero 2.");
            }
            else if (n3 == 3)
            {
                Console.WriteLine("Voce digitou o numero 3.");
            }
            else { Console.WriteLine("Numero fora do intervalo de 1 a 3."); }
        }
        public static void ExecutarFor()
        {
            Console.WriteLine("Incremento: ");
            for (int i = 0; i < 10; i++) //Incremento 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Decremento: ");
            for (int i = 10; i >= 0; i--) //Decremento 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Contagem de 0 a 50 em passo de 5");
            for (int i = 0; i <= 50; i += 5) //Decremento 
            {
                Console.WriteLine(i);
            }
        }
        public static void ExecutarForeach()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Números na lista:");

            // Usando foreach para percorrer a lista e exibir os números
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Usando foreach para percorrer um dicionario 
            Dictionary<string, int> idadePorNome = new Dictionary<string, int>
                {
                    { "Alice", 25 },
                    { "Bob", 30 },
                    { "Charlie", 22 }
                };

            foreach (var entrada in idadePorNome)
            {
                Console.WriteLine($"Nome: {entrada.Key}, Idade: {entrada.Value}");
            }

            // percorrendo caracteres de uma string
            string texto = "Exemplo de Foreach No Csharp";

            foreach (char caractere in texto)
            {
                if (char.IsUpper(caractere))
                {
                    Console.WriteLine(caractere);
                }
            }
        }

        public static void ExecutarWhile()
        {
            int pontuacao = 0;
            bool jogadorGanhou = false;

            Console.WriteLine("Bem-vindo ao jogo!");

            while (!jogadorGanhou)
            {
                Console.WriteLine($"Sua pontuação atual é {pontuacao}");
                Console.Write("Você ganhou? (Sim/Não): ");
                string resposta = Console.ReadLine();

                // Verifica se a resposta do jogador é "Sim" (case-insensitive)
                //A linha seguinte verifica se a resposta do jogador é "Sim"
                //(independentemente de ser maiúscula ou minúscula).
                //Isso é feito usando o método Equals com StringComparison.OrdinalIgnoreCase.
                //Se a resposta for "Sim", o programa faz o seguinte
                if (resposta.Equals("Sim", StringComparison.OrdinalIgnoreCase))
                {
                    jogadorGanhou = true;
                    Console.WriteLine("Parabéns! Você ganhou o jogo.");
                }
                else
                {
                    Console.WriteLine("Continue jogando...");
                    pontuacao++;
                }
            }
        }
    }
}