namespace Secao_02.View
{
    partial class TelaCadastro
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radAUTONOMO = new System.Windows.Forms.RadioButton();
            this.radCLT = new System.Windows.Forms.RadioButton();
            this.radPJ = new System.Windows.Forms.RadioButton();
            this.gbSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(201, 360);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(95, 40);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Salario";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Red;
            this.lblErro.Location = new System.Drawing.Point(0, 443);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(16, 17);
            this.lblErro.TabIndex = 6;
            this.lblErro.Text = "0";
            this.lblErro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErro.UseWaitCursor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 53);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(216, 53);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(420, 53);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(101, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(7, 26);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(89, 21);
            this.radMasculino.TabIndex = 11;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            this.radMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(7, 53);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(83, 21);
            this.radFeminino.TabIndex = 12;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            this.radFeminino.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.radMasculino);
            this.gbSexo.Controls.Add(this.radFeminino);
            this.gbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.Location = new System.Drawing.Point(317, 142);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(137, 122);
            this.gbSexo.TabIndex = 16;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radAUTONOMO);
            this.groupBox1.Controls.Add(this.radCLT);
            this.groupBox1.Controls.Add(this.radPJ);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 122);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Contrato";
            // 
            // radAUTONOMO
            // 
            this.radAUTONOMO.AutoSize = true;
            this.radAUTONOMO.Location = new System.Drawing.Point(7, 76);
            this.radAUTONOMO.Name = "radAUTONOMO";
            this.radAUTONOMO.Size = new System.Drawing.Size(108, 21);
            this.radAUTONOMO.TabIndex = 13;
            this.radAUTONOMO.TabStop = true;
            this.radAUTONOMO.Text = "AUTONOMO";
            this.radAUTONOMO.UseVisualStyleBackColor = true;
            // 
            // radCLT
            // 
            this.radCLT.AutoSize = true;
            this.radCLT.Checked = true;
            this.radCLT.Location = new System.Drawing.Point(7, 26);
            this.radCLT.Name = "radCLT";
            this.radCLT.Size = new System.Drawing.Size(52, 21);
            this.radCLT.TabIndex = 11;
            this.radCLT.TabStop = true;
            this.radCLT.Text = "CLT";
            this.radCLT.UseVisualStyleBackColor = true;
            // 
            // radPJ
            // 
            this.radPJ.AutoSize = true;
            this.radPJ.Location = new System.Drawing.Point(7, 49);
            this.radPJ.Name = "radPJ";
            this.radPJ.Size = new System.Drawing.Size(42, 21);
            this.radPJ.TabIndex = 12;
            this.radPJ.TabStop = true;
            this.radPJ.Text = "PJ";
            this.radPJ.UseVisualStyleBackColor = true;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radAUTONOMO;
        private System.Windows.Forms.RadioButton radCLT;
        private System.Windows.Forms.RadioButton radPJ;
    }
}