using System;

namespace Exercicio_Fixacao
{
    class Program
    {
        static float CalcularMedia(float[]numeros){

            float soma = 0;

            for (var i = 0; i < numeros.Length; i++)
            {
                //soma = + numeros[i];
                soma += numeros[i];
            }  

            float cauculo = soma / numeros.Length;        

            return cauculo;


            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            //arrey
            //forech
            //função/metodo
            string[] nome = new string[3];
            float[] notas = new float [3];
            float[] mediaAluno = new float[4];
            //Laço contado
            //O laço For já tem na sua sintase elementos para contar números
            //Opções de incremento:
            //i++
            //i = i = 1
            // - i += i
                for(int i = 0; i < 3; i++){

                    Console.WriteLine("Escreva um nome :");
                    // nome[0]
                    // nome[1]
                    // nome[2]
                    
                    nome[i] = Console.ReadLine();

                    for (var x = 0; x < 3; x++)
                    {
                        //Concatenação
                        Console.WriteLine("Digite a "+(x+1)+"° nota:");
                        notas[x] = float.Parse(Console.ReadLine());
                        // notas[0]
                        // notas[1]
                        // notas[2]
                    }

                   // mediaAluno[i] = (notas[0]+notas[1]+notas[2]+notas[3] ) / 4;

                   mediaAluno[1] = CalcularMedia(notas); 

                }

                Console.ForegroundColor = ConsoleColor.Green;

            //Laço condicionais 
            //WHILE/DO WHILE / FOREACH
            foreach(string nomeAvulso in nome){

                Console.WriteLine(nomeAvulso);
            }

            Console.ForegroundColor = ConsoleColor.Red;

            //Mostrar médias e nomes em laços de repetição
            //arrey.lenght = tamanho do array, caso eu não saiba (dinâmpica)
            for (var i = 0; i < nome.Length; i++)
            {

                //Interpolação
                Console.WriteLine($"Nome : {nome[i]} - Média : {mediaAluno[i]}");
                
            }




        }
    }
}
