using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    Console.WriteLine("Bola em Jogo");
                }

                return _instance;
            }
        }

        public void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}