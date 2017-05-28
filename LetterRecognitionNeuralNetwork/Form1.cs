using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LetterRecognitionNeuralNetwork
{
    public partial class Form1 : Form
    {
        Perceptron RNA;

        int TreinosRealizados = 0;
        int AmostrasAdicionadas = 0;
        int LetraAtual = 0;

        bool EstaTreinando = false;

        Color[,] bgColors = new Color[7, 7] {
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
            {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control}
        };

        public Form1()
        {
            InitializeComponent();
            
            RNA = new Perceptron();

            tlpAreaDesenho.ColumnCount = Constantes.CELULAS_LINHA;
            tlpAreaDesenho.RowCount = Constantes.CELULAS_LINHA;

            txtSaidaEsperada.Text = Constantes.LETRAS[LetraAtual].ToString();
        }

        private void tlpAreaDesenho_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Point p = GetIndex(tlpAreaDesenho, e.Location);

                if (e.Button.Equals(MouseButtons.Left))
                {
                    bgColors[p.X, p.Y] = Color.Red;
                    tlpAreaDesenho.Refresh();
                }
                else if (e.Button.Equals(MouseButtons.Right))
                {
                    bgColors[p.X, p.Y] = Color.WhiteSmoke;
                    tlpAreaDesenho.Refresh();
                }
            }
            catch { }
        }

        private void tlpAreaDesenho_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            using (var b = new SolidBrush(bgColors[e.Column, e.Row]))
            {
                e.Graphics.FillRectangle(b, e.CellBounds);
            }
        }

        private void tlpAreaDesenho_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = GetIndex(tlpAreaDesenho, e.Location);

            if (bgColors[p.X, p.Y].Equals(Color.Red))
            {
                bgColors[p.X, p.Y] = Color.WhiteSmoke;
                tlpAreaDesenho.Refresh();
            }
            else
            {
                bgColors[p.X, p.Y] = Color.Red;
                tlpAreaDesenho.Refresh();
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            bgColors = new Color[7, 7] {
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control},
                {SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control, SystemColors.Control}
            };

            tlpAreaDesenho.Refresh();
        }

        private void btAddSample_Click(object sender, EventArgs e)
        {
            int letra = txtSaidaEsperada.Text.ToUpper().ToCharArray()[0];

            RNA.AddConjuntoTreino(GetEntrada(), letra);

            AmostrasAdicionadas++;
            lblContaAmostrasAdd.Text = Constantes.AMOSTRAS_ADICIONADAS + AmostrasAdicionadas.ToString();
            
            if(LetraAtual >= 26)
            {
                LetraAtual = 0;
            }

            txtSaidaEsperada.Text = Constantes.LETRAS[LetraAtual].ToString();
            LetraAtual++;
            
        }

        private void btTreinar_Click(object sender, EventArgs e)
        {
            if (!EstaTreinando)
            {
                Thread treino = new Thread(new ThreadStart(ComecaTreino));
                treino.IsBackground = true;
                treino.Start();

                lblEstaTreinando.Text = Constantes.TREINANDO + Constantes.POSITIVO;
                EstaTreinando = true;
            }
            else
            {
                MessageBox.Show("Já há um treinamento em andamento.");
            }

        }

        private void btIdentificaPadrao_Click(object sender, EventArgs e)
        {
            RNA.SetEntradas(GetEntrada());

            double[] saidas = RNA.GetSaidas();
            int index = 0;

            for(int i = 0; i < saidas.Length; i++)
            {
                if(saidas[i] > saidas[index])
                {
                    index = i;
                }
            }

            char letraObtida = (char)(Constantes.CHAR_BASE + index);
            lblSaidaObtida.Text = Constantes.SAIDA_OBTIDA + letraObtida;
        }

        private void btSalvarAmostras_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if(!GerenciaArquivosTreino.SalvaArquivo(RNA.GetConjuntosTreino(), saveFileDialog1.FileName))
            {
                MessageBox.Show("Não foi possível salvar o arquivo.");
            }
        }

        private void btCarregaArquivo_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if(openFileDialog1.FileName != "")
            {
                List<ConjuntoTreinamento> Conjuntos = GerenciaArquivosTreino.CarregaArquivo(openFileDialog1.FileName);

                if (Conjuntos != null)
                {
                    int contaAmostras = 0;

                    foreach (ConjuntoTreinamento conj in Conjuntos)
                    {
                        RNA.AddConjuntoTreino(conj.GetEntradas(), conj.GetLetra());
                        contaAmostras++;
                    }

                    lblContaAmostrasAdd.Text = Constantes.AMOSTRAS_ADICIONADAS + contaAmostras;
                    lblArquivoAberto.Text = Constantes.ARQUIVO_ABERTO + "\n" + openFileDialog1.SafeFileName;
                }
                else
                {
                    MessageBox.Show("Não foi possível ler o arquivo.");
                }
            }

        }

        private void btGeraLog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();

            if (!RNA.GeraLog(saveFileDialog1.FileName))
            {
                MessageBox.Show("Não foi possível salvar o arquivo de log.");
            }
        }

        /*
         * 
         * 
         * METODOS
         * 
         * 
         */

        public Point GetIndex(TableLayoutPanel tlp, Point point)
        {

            int w = 0, h = 0;
            int[] widths = tlp.GetColumnWidths(), heights = tlp.GetRowHeights();

            int i;
            for (i = 0; i < widths.Length && point.X > w; i++)
            {
                w += widths[i];
            }
            int col = i - 1;

            for (i = 0; i < heights.Length && point.Y + tlp.VerticalScroll.Value > h; i++)
            {
                h += heights[i];
            }
            int row = i - 1;

            return new Point(col, row);
        }

        private int[] GetEntrada()
        {
            int i = 0;
            int[] entrada = new int[Constantes.TAMANHO_ENTRADA];

            for (int j = 0; j < Constantes.CELULAS_LINHA; j++)
            {
                for (int k = 0; k < Constantes.CELULAS_LINHA; k++)
                {
                    if (bgColors[j, k].Equals(Color.Red))
                    {
                        entrada[i] = 1;
                    }
                    else
                    {
                        entrada[i] = 0;
                    }

                    i++;
                }
            }

            return entrada;
        }

        private void ComecaTreino()
        {

            RNA.Treinar((int)numQtdFasesTreino.Value);

            Func<int> update = delegate () {
                TreinosRealizados++;
                lblEstaTreinando.Text = Constantes.TREINANDO + Constantes.NEGATIVO;
                lblContaTreinos.Text = Constantes.FASES_TREINO + TreinosRealizados.ToString();
                EstaTreinando = false;
                return 0;
            };

            Invoke(update);

        }

    }
}

