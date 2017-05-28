using System;

namespace LetterRecognitionNeuralNetwork
{
    class Neuronio
    {
        
        private int[] Entradas;
        private double[] Pesos;
        private double PesoVies;

        public Neuronio()
        {
            Pesos = new double[Constantes.TAMANHO_ENTRADA];

            RandomHolder rand = RandomHolder.GetInstance();
            PesoVies = 1 / ((rand.GetRandomDouble() * 100) + 1);
        }

        public void SetAmostra(int[] entrada)
        {
            if(Entradas == null)
            {
                Entradas = entrada;
                GerarPesos();
            }

            Entradas = entrada;
            
        }

        private void GerarPesos()
        {
            RandomHolder rand = RandomHolder.GetInstance();

            for (int i = 0; i < Pesos.Length; i++)
            {
               Pesos[i] = 1 / ((rand.GetRandomDouble() * 100) + 1);
            }

        }

        public double GetSaida()
        {
            double net = 0.0;

            for(int i = 0; i < Entradas.Length; i++)
            {
                net += Pesos[i] * Entradas[i];
            }

            net += Constantes.VIES * PesoVies;

            return FuncaoSigmoid(net);
        }

        public void AjustaPesos(double aprendizado)
        {
            for(int i = 0; i < Entradas.Length; i++)
            {
                double d = Pesos[i];
                d += Constantes.TAXA_APRENDIZADO * aprendizado * Entradas[i];
                Pesos.SetValue(d, i);
            }

            PesoVies += Constantes.TAXA_APRENDIZADO * aprendizado * Constantes.VIES;
        }

        private double FuncaoSigmoid(double x)
        {
            return ( 1 / (1 + Math.Pow(Math.E, -x)) );
        }

        public int[] GetEntrada()
        {
            return Entradas;
        }

        public double[] GetPesos()
        {
            return Pesos;
        }

    }
}
