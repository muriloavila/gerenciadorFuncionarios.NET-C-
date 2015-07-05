namespace gerenciadorFuncionarios
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddNome = new System.Windows.Forms.TextBox();
            this.txtAddCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numAddIdade = new System.Windows.Forms.NumericUpDown();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAddIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtAddNome
            // 
            this.txtAddNome.Location = new System.Drawing.Point(108, 37);
            this.txtAddNome.Name = "txtAddNome";
            this.txtAddNome.Size = new System.Drawing.Size(100, 20);
            this.txtAddNome.TabIndex = 1;
            // 
            // txtAddCargo
            // 
            this.txtAddCargo.Location = new System.Drawing.Point(108, 63);
            this.txtAddCargo.Name = "txtAddCargo";
            this.txtAddCargo.Size = new System.Drawing.Size(100, 20);
            this.txtAddCargo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo";
            // 
            // txtAddEnd
            // 
            this.txtAddEnd.Location = new System.Drawing.Point(108, 89);
            this.txtAddEnd.Name = "txtAddEnd";
            this.txtAddEnd.Size = new System.Drawing.Size(100, 20);
            this.txtAddEnd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereco";
            // 
            // txtAddTel
            // 
            this.txtAddTel.Location = new System.Drawing.Point(108, 115);
            this.txtAddTel.Name = "txtAddTel";
            this.txtAddTel.Size = new System.Drawing.Size(100, 20);
            this.txtAddTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Idade";
            // 
            // numAddIdade
            // 
            this.numAddIdade.Location = new System.Drawing.Point(108, 142);
            this.numAddIdade.Name = "numAddIdade";
            this.numAddIdade.Size = new System.Drawing.Size(100, 20);
            this.numAddIdade.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(83, 174);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 209);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.numAddIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmAdd";
            this.Text = "Adicionar";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAddIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddNome;
        private System.Windows.Forms.TextBox txtAddCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numAddIdade;
        private System.Windows.Forms.Button btnAdicionar;
    }
}