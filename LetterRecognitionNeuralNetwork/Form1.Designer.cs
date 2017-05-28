namespace LetterRecognitionNeuralNetwork
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btReset = new System.Windows.Forms.Button();
            this.btAddSample = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numQtdFasesTreino = new System.Windows.Forms.NumericUpDown();
            this.btTreinar = new System.Windows.Forms.Button();
            this.lblEstaTreinando = new System.Windows.Forms.Label();
            this.lblContaTreinos = new System.Windows.Forms.Label();
            this.lblContaAmostrasAdd = new System.Windows.Forms.Label();
            this.txtSaidaEsperada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSaidaObtida = new System.Windows.Forms.Label();
            this.btIdentificaPadrao = new System.Windows.Forms.Button();
            this.btSalvarAmostras = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCarregaArquivo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblArquivoAberto = new System.Windows.Forms.Label();
            this.btGeraLog = new System.Windows.Forms.Button();
            this.tlpAreaDesenho = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdFasesTreino)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btReset.Location = new System.Drawing.Point(365, 369);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(166, 23);
            this.btReset.TabIndex = 3;
            this.btReset.Text = "Resetar a tela";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btAddSample
            // 
            this.btAddSample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddSample.Location = new System.Drawing.Point(6, 60);
            this.btAddSample.Name = "btAddSample";
            this.btAddSample.Size = new System.Drawing.Size(154, 23);
            this.btAddSample.TabIndex = 2;
            this.btAddSample.Text = "Adicionar amostra";
            this.btAddSample.UseVisualStyleBackColor = true;
            this.btAddSample.Click += new System.EventHandler(this.btAddSample_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numQtdFasesTreino);
            this.groupBox1.Controls.Add(this.btTreinar);
            this.groupBox1.Controls.Add(this.lblEstaTreinando);
            this.groupBox1.Controls.Add(this.lblContaTreinos);
            this.groupBox1.Controls.Add(this.lblContaAmostrasAdd);
            this.groupBox1.Controls.Add(this.txtSaidaEsperada);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btAddSample);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treinamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantidade de ciclos de treino:";
            // 
            // numQtdFasesTreino
            // 
            this.numQtdFasesTreino.Location = new System.Drawing.Point(7, 122);
            this.numQtdFasesTreino.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQtdFasesTreino.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQtdFasesTreino.Name = "numQtdFasesTreino";
            this.numQtdFasesTreino.Size = new System.Drawing.Size(155, 20);
            this.numQtdFasesTreino.TabIndex = 10;
            this.numQtdFasesTreino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btTreinar
            // 
            this.btTreinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTreinar.Location = new System.Drawing.Point(7, 148);
            this.btTreinar.Name = "btTreinar";
            this.btTreinar.Size = new System.Drawing.Size(155, 23);
            this.btTreinar.TabIndex = 3;
            this.btTreinar.Text = "Treinar";
            this.btTreinar.UseVisualStyleBackColor = true;
            this.btTreinar.Click += new System.EventHandler(this.btTreinar_Click);
            // 
            // lblEstaTreinando
            // 
            this.lblEstaTreinando.AutoSize = true;
            this.lblEstaTreinando.Location = new System.Drawing.Point(6, 194);
            this.lblEstaTreinando.Name = "lblEstaTreinando";
            this.lblEstaTreinando.Size = new System.Drawing.Size(84, 13);
            this.lblEstaTreinando.TabIndex = 9;
            this.lblEstaTreinando.Text = "Treinando: NÃO";
            // 
            // lblContaTreinos
            // 
            this.lblContaTreinos.AutoSize = true;
            this.lblContaTreinos.Location = new System.Drawing.Point(6, 178);
            this.lblContaTreinos.Name = "lblContaTreinos";
            this.lblContaTreinos.Size = new System.Drawing.Size(141, 13);
            this.lblContaTreinos.TabIndex = 8;
            this.lblContaTreinos.Text = "Fases de treino realizadas: 0";
            // 
            // lblContaAmostrasAdd
            // 
            this.lblContaAmostrasAdd.AutoSize = true;
            this.lblContaAmostrasAdd.Location = new System.Drawing.Point(6, 86);
            this.lblContaAmostrasAdd.Name = "lblContaAmostrasAdd";
            this.lblContaAmostrasAdd.Size = new System.Drawing.Size(122, 13);
            this.lblContaAmostrasAdd.TabIndex = 7;
            this.lblContaAmostrasAdd.Text = "Amostras adicionadas: 0";
            // 
            // txtSaidaEsperada
            // 
            this.txtSaidaEsperada.Location = new System.Drawing.Point(6, 34);
            this.txtSaidaEsperada.Name = "txtSaidaEsperada";
            this.txtSaidaEsperada.Size = new System.Drawing.Size(154, 20);
            this.txtSaidaEsperada.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saída esperada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSaidaObtida);
            this.groupBox2.Controls.Add(this.btIdentificaPadrao);
            this.groupBox2.Location = new System.Drawing.Point(2, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 75);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operação";
            // 
            // lblSaidaObtida
            // 
            this.lblSaidaObtida.AutoSize = true;
            this.lblSaidaObtida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaidaObtida.Location = new System.Drawing.Point(8, 46);
            this.lblSaidaObtida.Name = "lblSaidaObtida";
            this.lblSaidaObtida.Size = new System.Drawing.Size(102, 20);
            this.lblSaidaObtida.TabIndex = 1;
            this.lblSaidaObtida.Text = "Saída obtida:";
            // 
            // btIdentificaPadrao
            // 
            this.btIdentificaPadrao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIdentificaPadrao.Location = new System.Drawing.Point(7, 20);
            this.btIdentificaPadrao.Name = "btIdentificaPadrao";
            this.btIdentificaPadrao.Size = new System.Drawing.Size(153, 23);
            this.btIdentificaPadrao.TabIndex = 1;
            this.btIdentificaPadrao.Text = "Identificar padrão";
            this.btIdentificaPadrao.UseVisualStyleBackColor = true;
            this.btIdentificaPadrao.Click += new System.EventHandler(this.btIdentificaPadrao_Click);
            // 
            // btSalvarAmostras
            // 
            this.btSalvarAmostras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvarAmostras.Location = new System.Drawing.Point(8, 70);
            this.btSalvarAmostras.Name = "btSalvarAmostras";
            this.btSalvarAmostras.Size = new System.Drawing.Size(151, 23);
            this.btSalvarAmostras.TabIndex = 12;
            this.btSalvarAmostras.Text = "Salvar arquivo";
            this.btSalvarAmostras.UseVisualStyleBackColor = true;
            this.btSalvarAmostras.Click += new System.EventHandler(this.btSalvarAmostras_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "conj";
            this.saveFileDialog1.Filter = "Conjuntos Treino|*.conj|Arquivos de log|*.log|Todos os arquivos|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "conj";
            this.openFileDialog1.Filter = "Conjuntos Treino|*.conj|Arquivos de log|*.log|Todos os arquivos|*.*";
            // 
            // btCarregaArquivo
            // 
            this.btCarregaArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCarregaArquivo.Location = new System.Drawing.Point(8, 41);
            this.btCarregaArquivo.Name = "btCarregaArquivo";
            this.btCarregaArquivo.Size = new System.Drawing.Size(151, 23);
            this.btCarregaArquivo.TabIndex = 4;
            this.btCarregaArquivo.Text = "Carregar arquivo";
            this.btCarregaArquivo.UseVisualStyleBackColor = true;
            this.btCarregaArquivo.Click += new System.EventHandler(this.btCarregaArquivo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblArquivoAberto);
            this.groupBox3.Controls.Add(this.btGeraLog);
            this.groupBox3.Controls.Add(this.btSalvarAmostras);
            this.groupBox3.Controls.Add(this.btCarregaArquivo);
            this.groupBox3.Location = new System.Drawing.Point(2, 300);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 131);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arquivos";
            // 
            // lblArquivoAberto
            // 
            this.lblArquivoAberto.AutoSize = true;
            this.lblArquivoAberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblArquivoAberto.Location = new System.Drawing.Point(8, 13);
            this.lblArquivoAberto.Name = "lblArquivoAberto";
            this.lblArquivoAberto.Size = new System.Drawing.Size(79, 26);
            this.lblArquivoAberto.TabIndex = 14;
            this.lblArquivoAberto.Text = "Arquivo aberto:\r\nnenhum";
            // 
            // btGeraLog
            // 
            this.btGeraLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGeraLog.Location = new System.Drawing.Point(9, 100);
            this.btGeraLog.Name = "btGeraLog";
            this.btGeraLog.Size = new System.Drawing.Size(150, 23);
            this.btGeraLog.TabIndex = 13;
            this.btGeraLog.Text = "Gerar arquivo log";
            this.btGeraLog.UseVisualStyleBackColor = true;
            this.btGeraLog.Click += new System.EventHandler(this.btGeraLog_Click);
            // 
            // tlpAreaDesenho
            // 
            this.tlpAreaDesenho.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tlpAreaDesenho.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpAreaDesenho.ColumnCount = 7;
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAreaDesenho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAreaDesenho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpAreaDesenho.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpAreaDesenho.Location = new System.Drawing.Point(174, 9);
            this.tlpAreaDesenho.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAreaDesenho.Name = "tlpAreaDesenho";
            this.tlpAreaDesenho.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpAreaDesenho.RowCount = 7;
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpAreaDesenho.Size = new System.Drawing.Size(357, 357);
            this.tlpAreaDesenho.TabIndex = 14;
            this.tlpAreaDesenho.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tlpAreaDesenho_CellPaint);
            this.tlpAreaDesenho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpAreaDesenho_MouseDown);
            this.tlpAreaDesenho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpAreaDesenho_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(536, 435);
            this.Controls.Add(this.tlpAreaDesenho);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reconhecimento de caracteres";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQtdFasesTreino)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btAddSample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstaTreinando;
        private System.Windows.Forms.Label lblContaTreinos;
        private System.Windows.Forms.Label lblContaAmostrasAdd;
        private System.Windows.Forms.TextBox txtSaidaEsperada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSaidaObtida;
        private System.Windows.Forms.Button btIdentificaPadrao;
        private System.Windows.Forms.Button btTreinar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQtdFasesTreino;
        private System.Windows.Forms.Button btSalvarAmostras;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCarregaArquivo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btGeraLog;
        private System.Windows.Forms.Label lblArquivoAberto;
        private System.Windows.Forms.TableLayoutPanel tlpAreaDesenho;
    }
}

