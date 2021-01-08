using System;

namespace Exercicio_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrey
            //forech
            //função/metodo
            string[] nome = new string[10];
            float[] mediaAluno = {2, 4, 6, 9, 7, 4, 6, 5,0 , 5};

            //Laço contado
            //O laço For já tem na sua sintase elementos para contar números
            //Opções de incremento:
            //i++
            //i = i = 1
            // - i += i
                for(int i = 0; i < 10; i++){

                    Console.WriteLine("Escreva um nome :");
                    nome[i] = Console.ReadLine();
                }

                Console.ForegroundColor = ConsoleColor.Green;

            //Laço condicionais 
            //WHILE/DO WHILE / FOREACH
            foreach(string nomeAvulso in nome){

                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            //Mostrar médias e nomes em laços de repetição
            for (var i = 0; i < nome.Length; i++)
            {
                Console.WriteLine($"Nome : {nome[i]} - Média : {mediaAluno[i]}");
                
            }




        }
    }
}
