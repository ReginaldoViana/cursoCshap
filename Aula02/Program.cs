using System;
using System.Collections.Generic;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Arrays
           var nomes = new string[]{
               "Reginaldo",
               "Carlos",
               "Rafael",
               "Erick",
               "Joel",
               "Fernando",
           };

           foreach (var nome in nomes){
               Console.WriteLine(nome);
           }*/


            //List
           var cidades = new List<string>{
               "SP",
               "RP",
               "JB"
           };

           cidades.Add("TQ");

           foreach( var cidade in cidades){
               Console.WriteLine(cidade);
           }
            
        }
    }
}
