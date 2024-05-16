using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;

namespace Quizz
{
    class Program
    {
        /// <summary>
        /// Representa uma questão do quizz bem como as respostas possíveis.
        /// </summary>
        public struct Questao
        {
            public string TextoQuestao;
            public string Resposta1;
            public string Resposta2;
            public string Resposta3;
            public int RespostaCorreta;

            public Questao(string textoQuestao, string resposta1, string resposta2, string resposta3, int respostaCorreta)
            {
                TextoQuestao = textoQuestao;
                Resposta1 = resposta1;
                Resposta2 = resposta2;
                Resposta3 = resposta3;
                RespostaCorreta = respostaCorreta;
            }
        }

        // Inserir código aqui: Criar uma struct (Jogador) que armazena os dados do jogador
        public struct Jogador
        {
            public string Nome;
            public int Pontos;

            public Jogador(string nome ,int pontos)
            {
                Nome = nome;
                Pontos = pontos;
            }     
        }
        // Inserir código aqui: Declarar uma lista (list) de questões (ou seja, uma list do tipo Questao)
        // (não esquecer: public static)
        public static List<Questao> questoes = new List<Questao>();

        // Inserir código aqui: Declarar um jogador (ou seja, uma instância da struct Jogador)
        // (não esquecer: public static)
        public static Jogador jogador = new Jogador("Jogador 1" , 0);

        // Inserir código aqui: Criar um método estático para inicializar as questões
        public static void InicializarQuestoes()
        {
            questoes.Add(new Questao("Quanto é 2 + 2?", "0", "2", "4", 3));

            // Inserir código aqui: adicionar mais questões
            questoes.Add(new Questao("Quem é o vocalista da banda \"Queen\"?", "Freddie Mercury", "Kurt Cobain", "Corey Taylor", 1));

            questoes.Add(new Questao("Quem é o melhor programador da turma?", "Rodrigo Pinheiro", "Miguel Silva", "Marcus Cruz", 3));

            questoes.Add(new Questao("Quando o João tinha 2 anos a irmã dele tinha o dobro. O joão tem 20 anos , quantos anos tem a sua irmã?", "35", "22", "40", 2));

        }

        // Inserir código aqui: Criar um método estático para mostrar dados do jogador
        public static void MostrarDadosJogador()
        {
            
        }
        // Inserir código aqui: Criar um método estático para mostrar uma questão
        public static void MostrarQuestao()
        {
            
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = "Super Quizz";

            // Inserir código aqui: Inicializar as questões
            InicializarQuestoes(questoes.);

            // O índice da questão selecionada para mostrar ao jogador
            int indiceQuestao;

            // A resposta do jogador
            string resposta;

            do
            {
                // Mostrar o título do jogo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Super Quizz");
                Console.ForegroundColor = ConsoleColor.Gray;

                // Inserir código aqui: Mostrar os dados do jogador
                jogador.Nome = Console.ReadLine();
                string NomeJogador = jogador.Nome;
                Console.WriteLine($"Nome: {jogador.Nome} - {jogador.Pontos}");
                // Obter uma questão aleatória
                // indiceQuestao = Inserir código aqui: obter o índice de uma questão aleatória;
                indiceQuestao = rnd.Next();
                // Inserir código aqui: Mostrar a questão escolhida (e as respostas possíveis)


                Console.WriteLine(questoes);
                Console.SetCursorPosition(0, 13);
                Console.Write("Qual a resposta correta? (d para desistir)\n> ");
                resposta = Console.ReadLine();

                resposta = resposta.ToLower();

                // Inserir código aqui: Testar se a resposta está correta
                
                // Terminar o jogo
                if (resposta == "d")
                {
                    System.Environment.Exit(0);
                }

                Console.WriteLine("\n(pressione qualquer tecla para passar à próxima pergunta)");
                Console.ReadKey();

                Console.Clear();

            } while (1 == 1);
        }
    }
}
