
namespace LetterRecognitionNeuralNetwork
{
    class Constantes
    {

        public const double TAXA_APRENDIZADO = 0.1;

        public const int QTD_LETRAS = 26;
        //Representa o código ASCII do caracter 'A'.
        public const int CHAR_BASE = 65;

        public const int VIES = 1;

        public const int TAMANHO_ENTRADA = 49;

        public const int CELULAS_LINHA = 7;

        public const string ARQUIVO_ABERTO = "Arquivo aberto: ";
        public const string AMOSTRAS_ADICIONADAS = "Amostras adicionadas: ";
        public const string SAIDA_OBTIDA = "Saída obtida: ";
        public const string FASES_TREINO = "Fases de treino realizadas: ";
        public const string TREINANDO = "Treinando: ";
        public const string POSITIVO = "SIM";
        public const string NEGATIVO = "NÃO";

        public static char[] LETRAS = new char[QTD_LETRAS]{'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

    }
}
