using System.Security.AccessControl;

namespace JogoDeAdvinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int valorNumeroAleatorio = numeroAleatorio.Next(1, 20);

            Console.WriteLine("Bem-vindo(a) ao Jogo da Advinhação");
            Console.WriteLine();
            Console.WriteLine("Escolha o nível de dificuldade:");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.Write("Escolha: ");
            int nivelDificuldade = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int pontuacao = 1000;

            NivelFacil(valorNumeroAleatorio, nivelDificuldade, pontuacao);

            NivelMedio(valorNumeroAleatorio, nivelDificuldade, pontuacao);

            NivelDificil(valorNumeroAleatorio, nivelDificuldade, pontuacao);

        }
        private static int NivelFacil(int valorNumeroAleatorio, int nivelDificuldade, int pontuacao)
        {
            if (nivelDificuldade == 1)
            {
                for (int i = 1; i <= 15; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 15");
                    Console.WriteLine();
                    Console.Write($"Qual o seu {i}º chute? ");
                    int numeroChutado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Clear();

                    pontuacao -= Math.Abs((numeroChutado - valorNumeroAleatorio) / 2);

                    if (numeroChutado < valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi menor que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else if (numeroChutado > valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi maior que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine();
                        break;
                    }
                }
                Console.WriteLine("O jogo acabou!");
            }
            return pontuacao;
        }
        private static int NivelMedio(int valorNumeroAleatorio, int nivelDificuldade, int pontuacao)
        {
            if (nivelDificuldade == 2)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 10");
                    Console.WriteLine();
                    Console.Write($"Qual o seu {i}º chute? ");
                    int numeroChutado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Clear();

                    pontuacao -= Math.Abs((numeroChutado - valorNumeroAleatorio) / 2);

                    if (numeroChutado < valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi menor que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else if (numeroChutado > valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi maior que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine();
                        break;
                    }
                }
                Console.WriteLine("O jogo acabou!");
            }
            return pontuacao;
        }
        private static int NivelDificil(int valorNumeroAleatorio, int nivelDificuldade, int pontuacao)
        {
            if (nivelDificuldade == 3)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Tentativa {i} de 5");
                    Console.WriteLine();
                    Console.Write($"Qual o seu {i}º chute? ");
                    int numeroChutado = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    Console.Clear();

                    pontuacao -= Math.Abs((numeroChutado - valorNumeroAleatorio) / 2);

                    if (numeroChutado < valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi menor que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else if (numeroChutado > valorNumeroAleatorio)
                    {
                        Console.WriteLine($"Seu chute foi maior que o número secreto! Você fez {pontuacao} pontos!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine();
                        break;
                    }
                }
                Console.WriteLine("O jogo acabou!");
            }
            return pontuacao;
        }
    }
}
