namespace DiceGame
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.LblClose = new System.Windows.Forms.Label();
            this.LblMinimize = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NudAmountDices = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnPlayDices = new System.Windows.Forms.Button();
            this.CkBoxAmountDices = new System.Windows.Forms.CheckBox();
            this.PnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountDices)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(101, 6);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(89, 20);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Dice Game";
            // 
            // PnlTop
            // 
            this.PnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTop.Controls.Add(this.LblClose);
            this.PnlTop.Controls.Add(this.LblMinimize);
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(0, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(286, 28);
            this.PnlTop.TabIndex = 2;
            // 
            // LblClose
            // 
            this.LblClose.AutoSize = true;
            this.LblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClose.Location = new System.Drawing.Point(261, 3);
            this.LblClose.Name = "LblClose";
            this.LblClose.Size = new System.Drawing.Size(20, 20);
            this.LblClose.TabIndex = 3;
            this.LblClose.Text = "X";
            // 
            // LblMinimize
            // 
            this.LblMinimize.AutoSize = true;
            this.LblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinimize.Location = new System.Drawing.Point(236, 3);
            this.LblMinimize.Name = "LblMinimize";
            this.LblMinimize.Size = new System.Drawing.Size(21, 20);
            this.LblMinimize.TabIndex = 3;
            this.LblMinimize.Text = "   ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade dados:";
            // 
            // NudAmountDices
            // 
            this.NudAmountDices.Location = new System.Drawing.Point(115, 43);
            this.NudAmountDices.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudAmountDices.Name = "NudAmountDices";
            this.NudAmountDices.Size = new System.Drawing.Size(61, 20);
            this.NudAmountDices.TabIndex = 4;
            this.NudAmountDices.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NudAmountDices.ValueChanged += new System.EventHandler(this.NudAmountDices_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(76, 141);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(13, 13);
            this.LblResult.TabIndex = 6;
            this.LblResult.Text = "--";
            // 
            // BtnPlayDices
            // 
            this.BtnPlayDices.Location = new System.Drawing.Point(62, 90);
            this.BtnPlayDices.Name = "BtnPlayDices";
            this.BtnPlayDices.Size = new System.Drawing.Size(155, 23);
            this.BtnPlayDices.TabIndex = 7;
            this.BtnPlayDices.Text = "Jogar dados";
            this.BtnPlayDices.UseVisualStyleBackColor = true;
            this.BtnPlayDices.Click += new System.EventHandler(this.BtnPlayDices_Click);
            // 
            // CkBoxAmountDices
            // 
            this.CkBoxAmountDices.AutoSize = true;
            this.CkBoxAmountDices.Checked = true;
            this.CkBoxAmountDices.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkBoxAmountDices.Location = new System.Drawing.Point(142, 46);
            this.CkBoxAmountDices.Name = "CkBoxAmountDices";
            this.CkBoxAmountDices.Size = new System.Drawing.Size(15, 14);
            this.CkBoxAmountDices.TabIndex = 8;
            this.CkBoxAmountDices.UseVisualStyleBackColor = true;
            this.CkBoxAmountDices.CheckedChanged += new System.EventHandler(this.CkBoxAmountDices_CheckedChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 176);
            this.Controls.Add(this.CkBoxAmountDices);
            this.Controls.Add(this.BtnPlayDices);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudAmountDices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PnlTop.ResumeLayout(false);
            this.PnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountDices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel PnlTop;
        private System.Windows.Forms.Label LblClose;
        private System.Windows.Forms.Label LblMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudAmountDices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnPlayDices;
        private System.Windows.Forms.CheckBox CkBoxAmountDices;
    }
}

