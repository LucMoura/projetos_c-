using System;

class Program
{
    static void Main()
    {
        int qst;

        Console.WriteLine("Digite a questão que deseja ver:\n");
        qst = int.Parse(Console.ReadLine());

        switch (qst)
        {
            case 1:
                double num1, num2, num3, pi = 3.141519;

                Console.WriteLine("Digite os números:");
                num1 = double.Parse(Console.ReadLine());
                num2 = double.Parse(Console.ReadLine());
                num3 = double.Parse(Console.ReadLine());

                Console.WriteLine($"A área do triângulo é {(num1 * num3) / 2}");
                Console.WriteLine($"A área do círculo é {pi * Math.Pow(num3, 2)}");
                Console.WriteLine($"A área do trapézio é {(num1 + num2) * num3 / 2}");
                Console.WriteLine($"A área do quadrado é {Math.Pow(num2, 2)}");
                Console.WriteLine($"A área do retângulo é {num1 * num2}");
                break;

            case 2:
                int n1, n2, n3, n4;
                Console.WriteLine("Digite os números que deseja:");
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                n4 = int.Parse(Console.ReadLine());

                Console.WriteLine($"A diferença é: {n1 * n2 - n3 * n4}");
                break;

            case 3:
                Console.WriteLine("Digite a quantidade de números:");
                int quant_num = int.Parse(Console.ReadLine());

                double[] numeros = new double[quant_num];

                Console.WriteLine("Digite os números:");
                for (int i = 0; i < quant_num; i++)
                {
                    numeros[i] = double.Parse(Console.ReadLine());
                }

                double maior = numeros[0];
                int posicao = 0;

                for (int i = 1; i < quant_num; i++)
                {
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                        posicao = i;
                    }
                }

                Console.WriteLine($"Maior valor = {maior}");
                Console.WriteLine($"Posição do maior valor = {posicao}");
                break;

            case 4:
                Console.WriteLine("Digite a quantidade de pessoas:");
                int quant_pessoas = int.Parse(Console.ReadLine());

                string[] nomes = new string[quant_pessoas];
                int[] idades = new int[quant_pessoas];

                for (int i = 0; i < quant_pessoas; i++)
                {
                    Console.WriteLine($"Digite o nome da pessoa {i + 1}:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Digite a idade de {nomes[i]}:");
                    idades[i] = int.Parse(Console.ReadLine());
                }

                int idadeMaisVelha = idades[0];
                int indiceMaisVelho = 0;

                for (int i = 1; i < quant_pessoas; i++)
                {
                    if (idades[i] > idadeMaisVelha)
                    {
                        idadeMaisVelha = idades[i];
                        indiceMaisVelho = i;
                    }
                }

                Console.WriteLine($"Pessoa mais velha: {nomes[indiceMaisVelho]} com {idadeMaisVelha} anos");
                break;

            case 5:
                int[,] matriz = new int[3, 3];

                Console.WriteLine("Digite os 9 números para preencher a matriz 3x3:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Elemento [{i},{j}]: ");
                        matriz[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                int soma_referencia = 0;
                for (int j = 0; j < 3; j++)
                {
                    soma_referencia += matriz[0, j];
                }

                bool quadrado_magico = true;
                for (int i = 1; i < 3; i++)
                {
                    int soma_linha = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        soma_linha += matriz[i, j];
                    }
                    if (soma_linha != soma_referencia)
                    {
                        quadrado_magico = false;
                        break;
                    }
                }

                if (quadrado_magico)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int soma_coluna = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            soma_coluna += matriz[i, j];
                        }
                        if (soma_coluna != soma_referencia)
                        {
                            quadrado_magico = false;
                            break;
                        }
                    }
                }

                if (quadrado_magico)
                {
                    int sum_diag_pri = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        sum_diag_pri += matriz[i, i];
                    }
                    if (sum_diag_pri != soma_referencia)
                    {
                        quadrado_magico = false;
                    }
                }

                if (quadrado_magico)
                {
                    int sum_diag_sec = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        sum_diag_sec += matriz[i, 2 - i];
                    }
                    if (sum_diag_sec != soma_referencia)
                    {
                        quadrado_magico = false;
                    }
                }

                if (quadrado_magico)
                {
                    Console.WriteLine("A matriz é um quadrado mágico!");
                }
                else
                {
                    Console.WriteLine("A matriz não é um quadrado mágico.");
                }
                break;

            default:
                Console.WriteLine("Questão inválida!");
                break;
        }
    }
}
