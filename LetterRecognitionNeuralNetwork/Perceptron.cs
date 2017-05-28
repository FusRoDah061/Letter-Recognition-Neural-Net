using System;
using System.Collections.Generic;

namespace LetterRecognitionNeuralNetwork
{
    class Perceptron
    {

        private List<Neuronio> Neuronios;

        private List<ConjuntoTreinamento> ConjuntosTreino;

        public Perceptron()
        {
            Neuronios = new List<Neuronio>();
            ConjuntosTreino = new List<ConjuntoTreinamento>();

            GerarNeuronios();
        }

        public void Treinar(int fases)
        {

            RandomHolder rand = RandomHolder.GetInstance();

            for (int i = 0; i < fases; i++)
            {
                int index = (int)(rand.GetRandomDouble() * ConjuntosTreino.Count);

                ConjuntoTreinamento conj = ConjuntosTreino[index];

                SetEntradas(conj.GetEntradas());
                AjustarPesos(conj.GetSaidas());
            }

        }

        public void GerarNeuronios()
        {
            for(int i = 0; i < Constantes.QTD_LETRAS; i++)
            {
                Neuronios.Add(new Neuronio());
            }
        }

        public void AddConjuntoTreino(int[] entrada, int letra)
        {
            ConjuntosTreino.Add( new ConjuntoTreinamento(entrada, letra) );
        }

        public double[] GetSaidas()
        {
            double[] saidas = new double[Constantes.QTD_LETRAS];

            for(int i = 0; i < Neuronios.Count; i++)
            {
                saidas[i] = Neuronios[i].GetSaida();
            }

            return saidas;
        }

        public void SetEntradas(int[] entradas)
        {
            foreach(Neuronio n in Neuronios)
            {
                n.SetAmostra(entradas);
            }

        }

        private void AjustarPesos(double[] saidas)
        {
            for(int i = 0; i < Neuronios.Count; i++)
            {
                double y = saidas[i] - Neuronios[i].GetSaida();
                Neuronios[i].AjustaPesos(y);
            }
        }

        public List<ConjuntoTreinamento> GetConjuntosTreino()
        {
            return ConjuntosTreino;
        }

        public bool GeraLog(string diretorio)
        {
            return GerenciaArquivosTreino.EscreveLog(diretorio, Neuronios, ConjuntosTreino);
        }

    }

    class ConjuntoTreinamento
    {
        private int[] Entradas;
        private double[] Saidas;
        private int Letra;

        private SaidasLetras SaidasEsperadas;

        public ConjuntoTreinamento(int[] entradas, int letra)
        {
            
            Entradas = entradas;

            SaidasEsperadas = SaidasLetras.GetInstancia();

            Letra = letra;
            Saidas = SaidasEsperadas.GetLetra(letra);
        }

        public int[] GetEntradas()
        {
            return Entradas;
        }

        public double[] GetSaidas()
        {
            return Saidas;
        }

        public int GetLetra()
        {
            return Letra;
        }
    }

    class SaidasLetras
    {

        private double[][] SaidasDefinidas;

        private static SaidasLetras Instancia = null;

        private SaidasLetras()
        {
            SaidasDefinidas = new double[Constantes.QTD_LETRAS][];

            GerarSaidas();
        }

        public static SaidasLetras GetInstancia()
        {
            if(Instancia == null)
            {
                Instancia = new SaidasLetras();
            }

            return Instancia;
        }

        private void GerarSaidas()
        {
            //A
            SaidasDefinidas[0] = new double[Constantes.QTD_LETRAS] { 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //B
            SaidasDefinidas[1] = new double[Constantes.QTD_LETRAS] { 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //C
            SaidasDefinidas[2] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //D
            SaidasDefinidas[3] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //E
            SaidasDefinidas[4] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //F
            SaidasDefinidas[5] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //G
            SaidasDefinidas[6] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //H
            SaidasDefinidas[7] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //I
            SaidasDefinidas[8] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //J
            SaidasDefinidas[9] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //K
            SaidasDefinidas[10] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //L
            SaidasDefinidas[11] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //M
            SaidasDefinidas[12] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //N
            SaidasDefinidas[13] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //O
            SaidasDefinidas[14] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //P
            SaidasDefinidas[15] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //Q
            SaidasDefinidas[16] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //R
            SaidasDefinidas[17] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //S
            SaidasDefinidas[18] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //T
            SaidasDefinidas[19] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //U
            SaidasDefinidas[20] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0, 0.0 };

            //V
            SaidasDefinidas[21] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0, 0.0 };

            //W
            SaidasDefinidas[22] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0, 0.0 };

            //X
            SaidasDefinidas[23] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0, 0.0 };

            //Y
            SaidasDefinidas[24] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0, 0.0 };

            //Z
            SaidasDefinidas[25] = new double[Constantes.QTD_LETRAS] { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 1.0 };

        }

        public double[] GetLetra(int letra)
        {
            int index = letra - Constantes.CHAR_BASE;
            return SaidasDefinidas[index];
        }

    }
}
