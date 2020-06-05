using System;

namespace Aula11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1ª opção, sem argumentos
            Calculo infoPlayer = new Calculo();
            System.Console.WriteLine( infoPlayer.Calcular());

            //2ª opção, com 1 argumento int
            System.Console.WriteLine(infoPlayer.Calcular(100));

             //3ª opção, com 2 argumentos int
            System.Console.WriteLine(infoPlayer.Calcular(100, 40));

              //4ª opção, com 2 argumentos string~
            System.Console.WriteLine(infoPlayer.Calcular("Bruce","Banner"));
        }
    }
}
