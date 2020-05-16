using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton player_1 = Singleton.GetInstance;
            player_1.Message("Jogador 1: A bola está comigo no meio do campo");
            
            Singleton player_2 = Singleton.GetInstance;
            player_2.Message("Jogador 2: recebeu a bola");
            
            Singleton player_3 = Singleton.GetInstance;
            player_3.Message("Jogador 3: Recebeu o lançamento na linha de fundo");

            Console.ReadKey();
        }
    }
}