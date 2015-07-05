namespace gerenciadorFuncionarios
{
    partial class frmUpdate
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.numUptIdade = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUptTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUptEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUptCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUptNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUptIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(87, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // numUptIdade
            // 
            this.numUptIdade.Location = new System.Drawing.Point(112, 142);
            this.numUptIdade.Name = "numUptIdade";
            this.numUptIdade.Size = new System.Drawing.Size(100, 20);
            this.numUptIdade.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Idade";
            // 
            // txtUptTel
            // 
            this.txtUptTel.Location = new System.Drawing.Point(112, 115);
            this.txtUptTel.Name = "txtUptTel";
            this.txtUptTel.Size = new System.Drawing.Size(100, 20);
            this.txtUptTel.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Telefone";
            // 
            // txtUptEnd
            // 
            this.txtUptEnd.Location = new System.Drawing.Point(112, 89);
            this.txtUptEnd.Name = "txtUptEnd";
            this.txtUptEnd.Size = new System.Drawing.Size(100, 20);
            this.txtUptEnd.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Endereco";
            // 
            // txtUptCargo
            // 
            this.txtUptCargo.Location = new System.Drawing.Point(112, 63);
            this.txtUptCargo.Name = "txtUptCargo";
            this.txtUptCargo.Size = new System.Drawing.Size(100, 20);
            this.txtUptCargo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cargo";
            // 
            // txtUptNome
            // 
            this.txtUptNome.Location = new System.Drawing.Point(112, 37);
            this.txtUptNome.Name = "txtUptNome";
            this.txtUptNome.Size = new System.Drawing.Size(100, 20);
            this.txtUptNome.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(109, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(15, 13);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "id";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 206);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.numUptIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUptTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUptEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUptCargo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUptNome);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmUpdate";
            this.Text = "Atualizar";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUptIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.NumericUpDown numUptIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUptTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUptEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUptCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUptNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblID;
    }
}