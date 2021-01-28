namespace QuizDoMilhao
{
    partial class FormJogo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.btnAlternativa1 = new System.Windows.Forms.Button();
            this.btnAlternativa2 = new System.Windows.Forms.Button();
            this.btnAlternativa3 = new System.Windows.Forms.Button();
            this.btnAlternativa4 = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblErrar = new System.Windows.Forms.Label();
            this.lblAcertar = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPergunta);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 114);
            this.panel1.TabIndex = 1;
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPergunta.Location = new System.Drawing.Point(3, 7);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(123, 24);
            this.lblPergunta.TabIndex = 0;
            this.lblPergunta.Text = "PERGUNTA";
            // 
            // btnAlternativa1
            // 
            this.btnAlternativa1.BackColor = System.Drawing.Color.Red;
            this.btnAlternativa1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativa1.Location = new System.Drawing.Point(16, 171);
            this.btnAlternativa1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlternativa1.Name = "btnAlternativa1";
            this.btnAlternativa1.Size = new System.Drawing.Size(326, 33);
            this.btnAlternativa1.TabIndex = 50;
            this.btnAlternativa1.TabStop = false;
            this.btnAlternativa1.Text = "Alternativa1";
            this.btnAlternativa1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlternativa1.UseVisualStyleBackColor = false;
            this.btnAlternativa1.Click += new System.EventHandler(this.btnAlternativa1_Click);
            // 
            // btnAlternativa2
            // 
            this.btnAlternativa2.BackColor = System.Drawing.Color.Red;
            this.btnAlternativa2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativa2.Location = new System.Drawing.Point(16, 213);
            this.btnAlternativa2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlternativa2.Name = "btnAlternativa2";
            this.btnAlternativa2.Size = new System.Drawing.Size(326, 33);
            this.btnAlternativa2.TabIndex = 55;
            this.btnAlternativa2.Text = "Alternativa2";
            this.btnAlternativa2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlternativa2.UseVisualStyleBackColor = false;
            this.btnAlternativa2.Click += new System.EventHandler(this.btnAlternativa2_Click);
            // 
            // btnAlternativa3
            // 
            this.btnAlternativa3.BackColor = System.Drawing.Color.Red;
            this.btnAlternativa3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativa3.Location = new System.Drawing.Point(16, 254);
            this.btnAlternativa3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlternativa3.Name = "btnAlternativa3";
            this.btnAlternativa3.Size = new System.Drawing.Size(326, 33);
            this.btnAlternativa3.TabIndex = 56;
            this.btnAlternativa3.Text = "Alternativa3";
            this.btnAlternativa3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlternativa3.UseVisualStyleBackColor = false;
            this.btnAlternativa3.Click += new System.EventHandler(this.btnAlternativa3_Click);
            // 
            // btnAlternativa4
            // 
            this.btnAlternativa4.BackColor = System.Drawing.Color.Red;
            this.btnAlternativa4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternativa4.Location = new System.Drawing.Point(16, 295);
            this.btnAlternativa4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAlternativa4.Name = "btnAlternativa4";
            this.btnAlternativa4.Size = new System.Drawing.Size(326, 33);
            this.btnAlternativa4.TabIndex = 59;
            this.btnAlternativa4.Text = "Alternativa4";
            this.btnAlternativa4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlternativa4.UseVisualStyleBackColor = false;
            this.btnAlternativa4.Click += new System.EventHandler(this.btnAlternativa4_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Yellow;
            this.lblTimer.Location = new System.Drawing.Point(530, 171);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(104, 75);
            this.lblTimer.TabIndex = 5;
            this.lblTimer.Text = "60";
            // 
            // lblErrar
            // 
            this.lblErrar.AutoSize = true;
            this.lblErrar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrar.ForeColor = System.Drawing.Color.Yellow;
            this.lblErrar.Location = new System.Drawing.Point(11, 361);
            this.lblErrar.Name = "lblErrar";
            this.lblErrar.Size = new System.Drawing.Size(81, 29);
            this.lblErrar.TabIndex = 24;
            this.lblErrar.Text = "label1";
            // 
            // lblAcertar
            // 
            this.lblAcertar.AutoSize = true;
            this.lblAcertar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertar.ForeColor = System.Drawing.Color.Yellow;
            this.lblAcertar.Location = new System.Drawing.Point(215, 361);
            this.lblAcertar.Name = "lblAcertar";
            this.lblAcertar.Size = new System.Drawing.Size(81, 29);
            this.lblAcertar.TabIndex = 26;
            this.lblAcertar.Text = "label3";
            // 
            // btnParar
            // 
            this.btnParar.BackColor = System.Drawing.Color.Red;
            this.btnParar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar.Location = new System.Drawing.Point(498, 348);
            this.btnParar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(136, 33);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "PARAR";
            this.btnParar.UseVisualStyleBackColor = false;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(498, 390);
            this.btnSair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 34);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "ERRAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 29);
            this.label2.TabIndex = 61;
            this.label2.Text = "ACERTAR";
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.Red;
            this.btnAjuda.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.Location = new System.Drawing.Point(498, 307);
            this.btnAjuda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(136, 33);
            this.btnAjuda.TabIndex = 62;
            this.btnAjuda.Text = "AJUDA";
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(646, 455);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblAcertar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnAlternativa4);
            this.Controls.Add(this.btnAlternativa3);
            this.Controls.Add(this.btnAlternativa2);
            this.Controls.Add(this.btnAlternativa1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormJogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUIZ DO MILHÃO";
            this.Load += new System.EventHandler(this.FormJogo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAlternativa1;
        private System.Windows.Forms.Button btnAlternativa2;
        private System.Windows.Forms.Button btnAlternativa3;
        private System.Windows.Forms.Button btnAlternativa4;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblErrar;
        private System.Windows.Forms.Label lblAcertar;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label lblPergunta;
        private System.Windows.Forms.Timer timer1;
    }
}