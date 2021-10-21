using System;
using System.Collections.Generic;

namespace TarefaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Codigo responsavel por criar a lista
            List<String>
                list = new List<string>();
            //Adicionando elementos na lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("André");

            //Adiciona um elemento sugerido
            list.Insert(2, "Lucas");

            //Leitura em loop dos elementos inseridos
            foreach (string obj in list)
            {
                //Contando quantos elementos tenho na lista
                Console.WriteLine("Quantidade de elementos na lista: " + list.Count);
                //Encontrar o primeiro da lista que começa com a letra A, usando a função lambda
                string s1 = list.Find(x => x[0] == 'A');
                Console.WriteLine("Primeiro elemento que começa com a letra A: " + s1);
                //Encontrar o ultimo da lista que começa com a letra A, usando a função lambda
                string s2 = list.FindLast(x => x[0] == 'A');
                Console.WriteLine("Último elemento que começa com a letra A: " + s2);
            }
                //Buscar elementos pela posição
                int pos1 = list.FindIndex(x => x[0] == 'A');
                Console.WriteLine("Primeira posição de A: " + pos1);
                int pos2 = list.FindLastIndex(x => x[0] == 'A');
                Console.WriteLine("Última posição de A:" + pos2);
                //Buscar todos os elementos com tamanho igual a 5 caracteres
                List<string> list2 = list.FindAll(x => x.Length == 5);
                Console.WriteLine("------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }


            //Remover elementos da lista
            list.Remove("André");
            Console.WriteLine("=========");       
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //Tira um determinado elemento
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine("++++++++++++++++");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            //Tira elementos da lista a partir da posição e quantos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine("xxxxxxxxxxx");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
