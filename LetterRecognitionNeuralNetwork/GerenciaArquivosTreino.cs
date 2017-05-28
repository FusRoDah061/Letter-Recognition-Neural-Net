using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LetterRecognitionNeuralNetwork
{
    class GerenciaArquivosTreino
    {

        public static bool SalvaArquivo(List<ConjuntoTreinamento> conjs, string diretorio)
        {
            bool retorno = true;

            try
            {

                Directory.CreateDirectory(diretorio.Substring(0, diretorio.LastIndexOfAny(new char[2] { '/', '\\' })));

                StreamWriter stream = new StreamWriter(diretorio, false, Encoding.ASCII);

                foreach (ConjuntoTreinamento conj in conjs)
                {
                    string conteudo = "";

                    char letra = (char)conj.GetLetra();

                    int[] entradas = conj.GetEntradas();

                    conteudo += letra + "\n";
                    conteudo += GetStringVetor(entradas) + "\n";

                    stream.Write(conteudo);
                }

                stream.Dispose();
                stream.Close();

            }
            catch { retorno = false; }
            
            return retorno;
        }

        public static List<ConjuntoTreinamento> CarregaArquivo(string diretorio)
        {
            List<ConjuntoTreinamento> Conjuntos = new List<ConjuntoTreinamento>();

            StreamReader stream = new StreamReader(diretorio, Encoding.ASCII);

            string linha;
            int contaLinha = 1;

            char letra = ' ';
            int[] entradas = new int[Constantes.TAMANHO_ENTRADA];

            do
            {
                linha = stream.ReadLine();

                if(linha != null)
                {
                   
                    if (contaLinha % 2 != 0)
                    {
                        letra = linha.ToCharArray()[0];
                    }
                    else
                    {
                        string[] e = linha.Split(' ');
                        for(int i = 0; i < e.Length; i++)
                        {
                            entradas[i] = int.Parse(e[i]);
                        }
                    }

                    if(contaLinha % 2 == 0)
                    {
                        Conjuntos.Add(new ConjuntoTreinamento(entradas, letra));
                        letra = ' ';
                        entradas = new int[Constantes.TAMANHO_ENTRADA];
                    }

                    contaLinha++;
                }
            } while (linha != null);

            stream.Dispose();
            stream.Close();

            return Conjuntos;
        }

        public static bool EscreveLog(string diretorio, List<Neuronio> neuronios, List<ConjuntoTreinamento> conjuntos)
        {

            bool retorno = true;

            try
            {

                Directory.CreateDirectory(diretorio.Substring(0, diretorio.LastIndexOfAny(new char[2] { '/', '\\' })));

                StreamWriter stream = new StreamWriter(diretorio, false, Encoding.ASCII);

                stream.WriteLine("[NEURONIOS]");

                for(int i = 0; i < neuronios.Count; i++)
                {
                    string linha = "N_" + i + ":\nSaida: " + neuronios[i].GetSaida() + "\nEntradas\tPesos\n";

                    double[] pesos = neuronios[i].GetPesos();
                    int[] entradas = neuronios[i].GetEntrada();

                    for (int j = 0; j < entradas.Length; j++)
                    {
                        linha += entradas[j] + " 	        " + pesos[j] + "\n";
                    }

                    stream.WriteLine(linha);
                }

                stream.WriteLine("\n[CONJUNTOS_TREINAMENTO]");

                for (int i = 0; i < conjuntos.Count; i++)
                {
                    string linha = "C_" + i + ":\nLetra\tEntradas\n";

                    char letra = (char)conjuntos[i].GetLetra();

                    int[] entradas = conjuntos[i].GetEntradas();

                    linha += letra + " 	    ";
                    linha += GetStringVetor(entradas) + "\n";

                    stream.WriteLine(linha);
                }

            }
            catch { retorno = false; }
            
            return retorno;

        }

        private static string GetStringVetor(int[] vetor)
        {
            string vetorS = "";

            for(int i = 0; i < vetor.Length; i++)
            {
                vetorS += vetor[i].ToString() + " ";
            }
            return vetorS.Trim();
        }

        private static string GetStringVetor(double[] vetor)
        {
            string vetorS = "";

            for (int i = 0; i < vetor.Length; i++)
            {
                vetorS += vetor[i].ToString() + " ";
            }
            return vetorS.Trim();
        }

    }
}
