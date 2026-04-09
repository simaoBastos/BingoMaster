namespace BingoMaster
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumeroGrande = new Label();
            lblHistSorteio = new Label();
            lstHistorico = new ListBox();
            btnReiniciar = new Button();
            btnSortear = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNumeroGrande
            // 
            lblNumeroGrande.FlatStyle = FlatStyle.System;
            lblNumeroGrande.Font = new Font("Calibri", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumeroGrande.Location = new Point(475, 110);
            lblNumeroGrande.Name = "lblNumeroGrande";
            lblNumeroGrande.Size = new Size(248, 193);
            lblNumeroGrande.TabIndex = 0;
            lblNumeroGrande.Text = "00";
            lblNumeroGrande.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHistSorteio
            // 
            lblHistSorteio.Font = new Font("Calibri", 15F, FontStyle.Bold);
            lblHistSorteio.Location = new Point(48, 82);
            lblHistSorteio.Name = "lblHistSorteio";
            lblHistSorteio.Size = new Size(400, 37);
            lblHistSorteio.TabIndex = 1;
            lblHistSorteio.Text = "Histórico de Sorteio";
            lblHistSorteio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstHistorico
            // 
            lstHistorico.BackColor = SystemColors.ControlLightLight;
            lstHistorico.BorderStyle = BorderStyle.None;
            lstHistorico.Font = new Font("Calibri", 10F, FontStyle.Bold);
            lstHistorico.FormattingEnabled = true;
            lstHistorico.Location = new Point(48, 122);
            lstHistorico.MultiColumn = true;
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(400, 288);
            lstHistorico.Sorted = true;
            lstHistorico.TabIndex = 2;
            // 
            // btnReiniciar
            // 
            btnReiniciar.FlatAppearance.BorderSize = 0;
            btnReiniciar.Font = new Font("Calibri", 12F);
            btnReiniciar.Location = new Point(475, 350);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(246, 40);
            btnReiniciar.TabIndex = 3;
            btnReiniciar.Text = "REINICIAR JOGO";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnSortear
            // 
            btnSortear.FlatAppearance.BorderSize = 0;
            btnSortear.Font = new Font("Calibri", 12F);
            btnSortear.Location = new Point(475, 304);
            btnSortear.Name = "btnSortear";
            btnSortear.Size = new Size(246, 40);
            btnSortear.TabIndex = 4;
            btnSortear.Text = "SORTEAR PRÓXIMO";
            btnSortear.UseVisualStyleBackColor = true;
            btnSortear.Click += btnSortear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F, FontStyle.Bold);
            label1.Location = new Point(234, 33);
            label1.Name = "label1";
            label1.Size = new Size(341, 49);
            label1.TabIndex = 5;
            label1.Text = "Sorteador de Bingo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSortear);
            Controls.Add(btnReiniciar);
            Controls.Add(lstHistorico);
            Controls.Add(lblHistSorteio);
            Controls.Add(lblNumeroGrande);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeroGrande;
        private Label lblHistSorteio;
        private ListBox lstHistorico;
        private Button btnReiniciar;
        private Button btnSortear;
        private Label label1;
    }
}
