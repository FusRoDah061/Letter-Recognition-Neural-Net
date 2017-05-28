using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRecognitionNeuralNetwork
{
    class RandomHolder
    {

        private static RandomHolder Instancia;

        private Random Rand;

        private RandomHolder()
        {
            Rand = new Random();
        }

        public static RandomHolder GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new RandomHolder();
            }

            return Instancia;
        }

        public double GetRandomDouble()
        {
            return Rand.NextDouble();
        }

        public int GetRandomInt()
        {
            return Rand.Next();
        }

        public int GetRandomIntRange(int minVal, int maxVal)
        {
            return Rand.Next(minVal, maxVal);
        }

        public int GetRandomIntRange(int maxVal)
        {
            return Rand.Next(maxVal);
        }

        public byte[] GetRandomByte(byte[] buf)
        {
            Rand.NextBytes(buf);
            return buf;
        }

    }
}
